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
        public Form1()
        {
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
            InitializeComponent();
        }

        // C o n s t a n t s

        private const string TEMP_DIR_FOLDER_NAME = "SM64RM Progress Updater";
        private const string TEMP_CONF_FILE_NAME = "config.dat";
        private const string CONF_PROXY_USR = "ProxyUsr";
        private const string CONF_PROXY_PWD = "ProxyPwd";
        private const string CONF_WEBDAV_USR = "WebDavUsr";
        private const string CONF_WEBDAV_PWD = "WebDavPwd";
        private const string CONF_WEBDAV_URI = "WebDavUri";
        private const string CONF_VERSION = "Version";

        // F i e l d s

        private readonly drsPwEnc.drsPwEnc crypter = new drsPwEnc.drsPwEnc();

        private void PasteFromClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                PictureBox1.Image = Clipboard.GetImage();
            }
        }

        private async Task<bool> Upload()
        {
            bool result;
            string usr = TextBoxX_ProxUsr.Text.Trim();
            string pwd = TextBoxX_ProxPwd.Text;
            string vers = TextBoxX_Version.Text.Trim();
            string uri = TextBoxX_WebDavUploadUri.Text.Trim();
            if (string.IsNullOrEmpty(uri) || string.IsNullOrEmpty(vers))
            {
                result = false;
            }
            else
            {
                // Set web proxy
                if (!string.IsNullOrEmpty(usr) || !string.IsNullOrEmpty(pwd))
                {
                    WebRequest.DefaultWebProxy.Credentials = new NetworkCredential(usr, pwd);
                }

                // Create client
                var clientparams = new WebDavClientParams()
                {
                    BaseAddress = new Uri(uri),
                    Credentials = new NetworkCredential(TextBoxX_WebDavUploadUsr.Text.Trim(), TextBoxX_WebDavUploadPwd.Text)
                };
                var client = new WebDavClient(clientparams);

                // Save image to memory
                var msImage = new MemoryStream();
                PictureBox1.Image.Save(msImage, System.Drawing.Imaging.ImageFormat.Png);
                msImage.Position = 0;

                // Upload image
                try
                {
                    var res = await client.PutFile($"{vers}.png", msImage);
                    result = res.IsSuccessful;
                }
                catch (Exception)
                {
                    result = false;
                }
                finally
                {
                    msImage.Close();
                }
            }

            return result;
        }

        private DirectoryInfo GetTempDirPath()
        {
            return new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), TEMP_DIR_FOLDER_NAME));
        }

        private void SaveConfig()
        {
            var obj = new JObject();
            obj[CONF_PROXY_USR] = TextBoxX_ProxUsr.Text;
            obj[CONF_PROXY_PWD] = TextBoxX_ProxPwd.Text;
            obj[CONF_WEBDAV_URI] = TextBoxX_WebDavUploadUri.Text;
            obj[CONF_WEBDAV_USR] = TextBoxX_WebDavUploadUsr.Text;
            obj[CONF_WEBDAV_PWD] = TextBoxX_WebDavUploadPwd.Text;
            obj[CONF_VERSION] = TextBoxX_Version.Text;
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
                TextBoxX_ProxUsr.Text = (string)obj[CONF_PROXY_USR];
                TextBoxX_ProxPwd.Text = (string)obj[CONF_PROXY_PWD];
                TextBoxX_WebDavUploadUri.Text = (string)obj[CONF_WEBDAV_URI];
                TextBoxX_WebDavUploadUsr.Text = (string)obj[CONF_WEBDAV_USR];
                TextBoxX_WebDavUploadPwd.Text = (string)obj[CONF_WEBDAV_PWD];
                TextBoxX_Version.Text = (string)obj[CONF_VERSION];
            }
        }

        // G u i

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            PasteFromClipboard();
        }

        private async void ButtonX_Upload_Click(object sender, EventArgs e)
        {
            if (await Upload())
            {
                MessageBoxEx.Show("Erfolgreich hochgeladen!", "Hochladen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Fehler beim Hochladen!", "Hochladen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
            PasteFromClipboard();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }
    }
}