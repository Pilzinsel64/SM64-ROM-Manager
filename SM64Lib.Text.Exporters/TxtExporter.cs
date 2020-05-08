using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Text.Exporters
{
    public class TxtExporter
    {
        public async Task Export(string destFilePath, TextGroup[] groups)
        {
            var sw = new StreamWriter(destFilePath);

            for (int itg = 0; itg < groups.Length; itg++)
            {
                var tg = groups[itg];

                if (itg != 0)
                    await sw.WriteLineAsync("------------------------------\n");
                await sw.WriteLineAsync($"Text Group - {tg.TextGroupInfo.Name}\n");
                await sw.WriteLineAsync("------------------------------\n");

                for (int iti = 0; iti < tg.Count; iti++)
                {
                    var ti = tg[iti];
                    
                    if (ti is TextTableDialogItem)
                    {
                        await sw.WriteLineAsync($"Dialog #{iti}\n");
                        await sw.WriteLineAsync(ti.Text);
                        await sw.WriteLineAsync("\n\n");
                    }
                    else
                    {
                        await sw.WriteLineAsync($"Text Item #{iti}");
                        await sw.WriteLineAsync(ti.Text);
                        await sw.WriteLineAsync();
                    }
                }
            }

            await sw.FlushAsync();
            sw.Close();
        }
    }
}
