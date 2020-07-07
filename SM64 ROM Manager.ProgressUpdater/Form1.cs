using System;
using global::System.IO;
using global::System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::Newtonsoft.Json.Linq;
using global::WebDav;

namespace SM64_ROM_Manager.ProgressUpdater
{
    public partial class Form1
    {
        // C o n s t a n t s

        private const string TEMP_DIR_FOLDER_NAME = "SM64RM Progress Updater";
        private const string TEMP_CONF_FILE_NAME = "config.dat";

        // F i e l d s

        private readonly drsPwEnc.drsPwEnc crypter = new drsPwEnc.drsPwEnc();
        private Settings settings = new Settings();
        private WebDavMgr wdmgr = null;
        private DiscordMgr dmgr = null;
        private string upcommingVersions = string.Empty;

        // C o n s t r u c t o r

        public Form1()
        {
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
            InitializeComponent();
        }

        // F e a t u r e s

        private void PasteFromClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                PictureBox1.Image = Clipboard.GetImage();
            }
        }

        private DirectoryInfo GetTempDirPath()
        {
            return new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), TEMP_DIR_FOLDER_NAME));
        }

        private void LoadTextBoxes()
        {
            ComboBoxEx_Version.Text = settings.Version;
        }

        private void SaveConfig()
        {
            var obj = JObject.FromObject(settings);
            var dir = GetTempDirPath();
            string confFile = Path.Combine(dir.FullName, TEMP_CONF_FILE_NAME);

            if (!dir.Exists)
            {
                dir.Create();
            }

            string raw = crypter.EncryptData(obj.ToString());
            File.WriteAllText(confFile, raw);
        }

        private void LoadConfig()
        {
            var dir = GetTempDirPath();
            string confFile = Path.Combine(dir.FullName, TEMP_CONF_FILE_NAME);
            if (File.Exists(confFile))
            {
                string raw = File.ReadAllText(confFile);
                var obj = JObject.Parse(crypter.DecryptData(raw));
                settings = obj.ToObject<Settings>();
                LoadTextBoxes();
                LoadUpcommingVersions();
                LoadWebDavMgr();
                LoadDiscordMgr();
            }
        }

        private void LoadDiscordMgr()
        {
            if (dmgr is object && dmgr.IsReady)
                dmgr.Stop();
            dmgr = new DiscordMgr(settings);
            dmgr.GotReady += (_, __) => ButtonX_DiscordSetup.Enabled = true;
            dmgr.Start();
        }

        private Task LoadWebDavMgr()
        {
            ButtonX_Upload.Enabled = false;
            return Task.Run(() =>
            {
                wdmgr = new WebDavMgr(settings);
                if (wdmgr.Connect())
                {
                    Invoke(new Action(() => ButtonX_Upload.Enabled = true));
                    LoadUsedVersions();
                }
            });
        }

        private async void LoadUpcommingVersions()
        {
            upcommingVersions = await wdmgr.GetUpcommingVersions();
            var mdDocs = MarkdownHelper.SplitToVersions(upcommingVersions);

            foreach (var kvp in mdDocs)
            {
                // ...
            }
        }

        private async void LoadUsedVersions()
        {
            Invoke(new Action(() => ComboBoxEx_Version.Items.Clear()));

            foreach (var version in await wdmgr.GetUsedVersions())
                Invoke(new Action(() => ComboBoxEx_Version.Items.Add(version)));
        }

        // G u i

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            PasteFromClipboard();
        }

        private async void ButtonX_Upload_Click(object sender, EventArgs e)
        {
            if (settings.DiscordUploadEnabled && !dmgr.IsReady)
            {
                MessageBoxEx.Show("Discord ist noch nicht bereit!", "Hochladen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Enabled = false;
                circularProgress1.Start();
                if (await wdmgr.UploadImage(PictureBox1.Image))
                {
                    if (dmgr is object && dmgr.IsReady)
                        await dmgr.SendMessage();
                    MessageBoxEx.Show(this, "Erfolgreich hochgeladen!", "Hochladen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show(this, "Fehler beim Hochladen!", "Hochladen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                circularProgress1.Stop();
                Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
            PasteFromClipboard();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dmgr is object && dmgr.IsReady)
                dmgr.Stop();
            SaveConfig();
        }

        private void TextBoxX_Version_TextChanged(object sender, EventArgs e)
        {
            settings.Version = ComboBoxEx_Version.Text.Trim();
        }

        private void ButtonX_DiscordSetup_Click(object sender, EventArgs e)
        {
            var frm = new DiscordSettingsDialog(settings);
            frm.ShowDialog();
            LoadDiscordMgr();
        }

        private void ButtonX_SetupWebDav_Click(object sender, EventArgs e)
        {
            var frm = new WebDavSettingsDialog(settings);
            frm.ShowDialog();
            LoadWebDavMgr();
        }
    }
}