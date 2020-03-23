using System;
using System.Collections.Generic;
using System.Data;
using global::System.IO;
using global::System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace SM64_ROM_Manager.UserRequests
{
    public class UserRequestManager
    {
        private async Task<string> GenerateInfo(UserRequest request)
        {
            var writer = new StringWriter();
            foreach (UserRequestProperty prop in request.Properties)
            {
                await writer.WriteLineAsync(prop.Name);
                var switchExpr = prop.Type;
                switch (switchExpr)
                {
                    case UserRequestPropertyType.Text:
                    case UserRequestPropertyType.LongText:
                        await writer.WriteLineAsync(prop.Value);
                        break;
                    case UserRequestPropertyType.Files:
                        break;
                }

                await writer.WriteLineAsync();
            }

            return writer.ToString();
        }

        private void CopyAttachments(UserRequest request, DirectoryInfo destDir)
        {
            foreach (UserRequestProperty prop in request.Properties.Where(n => n.Type == UserRequestPropertyType.Files))
            {
                if (!string.IsNullOrEmpty(prop.Value))
                {
                    var dir = destDir.CreateSubdirectory(prop.Name);
                    foreach (string f in TranslateFilesStringToArray(prop.Value))
                        File.Copy(f, Path.Combine(dir.FullName, Path.GetFileName(f)));
                }
            }
        }

        public async Task<bool> UploadRequest(UserRequest request)
        {
            var curDate = DateAndTime.Now.ToUniversalTime();
            string zipFileName = curDate.ToString("yyyy.MM.dd HH.mm.ss.fffffff") + ".zip";
            var files = new Dictionary<string, string>();
            DirectoryInfo zipDir;
            DirectoryInfo tempDir;

            // Create temporary folder
            tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), @"SM64 ROM Manager\UserRequestUploads"));
            if (tempDir.Exists)
            {
                tempDir.Delete(true);
            }

            tempDir.Create();
            zipDir = tempDir.CreateSubdirectory("pkg");

            // Copy attachments
            CopyAttachments(request, zipDir);

            // Write help text
            string info = await GenerateInfo(request);
            File.WriteAllText(Path.Combine(zipDir.FullName, "request.txt"), info);

            // Zip temporary folder
            string zipFilePath = Path.Combine(tempDir.FullName, zipFileName);
            ZipFile.CreateFromDirectory(zipDir.FullName, zipFilePath);

            // Delete package directory
            zipDir.Delete(true);

            // Upload
            var mgr = new UserRequestUploadManager();
            bool result = await mgr.Upload(zipFilePath, zipFileName, request.UploadSettings);

            // Return result
            return result;
        }

        public static bool CheckMaxAttachmentFileLength(UserRequest request, long maxAttachmentLength)
        {
            long size = 0;
            foreach (UserRequestProperty prop in request.Properties)
            {
                if (prop.Type == UserRequestPropertyType.Files)
                {
                    foreach (string f in TranslateFilesStringToArray(prop.Value))
                        size += new FileInfo(f).Length;
                }
            }

            return size <= maxAttachmentLength;
        }

        public static string[] TranslateFilesStringToArray(string files)
        {
            return files?.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
        }

        public static string TranslateFilesArrayToString(string[] files)
        {
            return string.Join("|", files);
        }
    }
}