using System;
using global::System.IO;
using global::System.Net;
using System.Threading.Tasks;
using global::WebDav;

namespace SM64_ROM_Manager.UserRequests
{
    internal class UserRequestUploadManager
    {

        // F e a t u r e s

        private WebDavClientParams CreateParams(UserRequestUploadSettings settings)
        {
            return new WebDavClientParams()
            {
                BaseAddress = new Uri(settings.Link),
                Credentials = new NetworkCredential(settings.Username, settings.Password),
                UseProxy = false,
            };
        }

        private WebDavClient CreateClient(UserRequestUploadSettings settings)
        {
            var @params = CreateParams(settings);
            return new WebDavClient(@params);
        }

        private async Task<bool> UploadFile(WebDavClient client, string filePath, string uploadName)
        {
            var sFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var result = await client.PutFile(uploadName, sFile);
            sFile.Close();
            return result.IsSuccessful;
        }

        public async Task<bool> Upload(string filePath, string uploadName, UserRequestUploadSettings settings)
        {
            return await UploadFile(CreateClient(settings), filePath, uploadName);
        }
    }
}