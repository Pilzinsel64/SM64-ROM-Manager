using System;
using global::System.IO;
using global::System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::Newtonsoft.Json.Linq;
using global::WebDav;
using System.Drawing;

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

        private async void LoadUsedVersions()
        {
            Invoke(new Action(() => ComboBoxEx_Version.Items.Clear()));

            foreach (var version in await wdmgr.GetUsedVersions())
                Invoke(new Action(() => ComboBoxEx_Version.Items.Add(version)));
        }

        private void InvertImage()
        {
            Bitmap pic = new Bitmap(PictureBox1.Image);

            for (int y = 0; y < pic.Height; y++)
            {
                for (int x = 0; x < pic.Width; x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, 255 - inv.R, 255 - inv.G, 255 - inv.B);
                    pic.SetPixel(x, y, inv);
                }
            }

            PictureBox1.Image = pic;
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
                ToastNotification.Show(this, "Discord ist noch nicht bereit!", eToastGlowColor.Orange, eToastPosition.BottomCenter);
            }
            else
            {
                Enabled = false;
                circularProgress1.Start();
                if (await wdmgr.UploadImage(PictureBox1.Image))
                {
                    if (dmgr is object && dmgr.IsReady)
                        await dmgr.SendMessage();
                    ToastNotification.Show(this, "Erfolgreich hochgeladen!", eToastGlowColor.Green, eToastPosition.BottomCenter);
                }
                else
                {
                    ToastNotification.Show(this, "Fehler beim Hochladen!", eToastGlowColor.Orange, eToastPosition.BottomCenter);
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

        private void ButtonX_PasteDocument_Click(object sender, EventArgs e)
        {
            var frm = new PasteFromDocument(settings);
            if (frm.ShowDialog(this) == DialogResult.OK)
                PictureBox1.Image = frm.DocumentImage;
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            InvertImage();
        }
    }
}