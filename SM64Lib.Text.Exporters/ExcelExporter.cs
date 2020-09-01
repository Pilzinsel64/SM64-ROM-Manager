using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Text.Exporters
{
    public class ExcelExporter
    {
        public ExcelExporter()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public async Task Export(string destFilePath, TextGroup[] groups)
        {
            var pkg = new ExcelPackage();

            foreach (var tg in groups)
            {
                var ws = pkg.Workbook.Worksheets.Add(tg.TextGroupInfo.Name);
                var hasDialogCells = false;

                ws.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;
                ws.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                ws.Row(1).Style.Font.Bold = true;
                ws.Cells[1, 1].Value = "#";
                ws.Cells[1, 2].Value = "Text";

                for (int i = 0; i < tg.Count; i++)
                {
                    var ti = tg[i];
                    var ri = i + 2;

                    ws.Cells[ri, 1].Value = i;
                    ws.Cells[ri, 2].Value = ti.Text;

                    if (ti is TextTableDialogItem)
                        hasDialogCells = true;
                }


                for (int ri = 1; ri <= ws.Cells.Rows; ri++)
                {
                    var r = ws.Row(ri);
                    r.CustomHeight = false;
                }

                if (hasDialogCells)
                {
                    var c = ws.Column(2);
                    c.Style.WrapText = true;
                    c.Width = 30;
                }

                for (int ci = 1; ci <= 2; ci++)
                {
                    var c = ws.Column(ci);
                    if (!c.Style.WrapText)
                        c.AutoFit();
                }
            }

            await pkg.SaveAsAsync(new FileInfo(destFilePath));
            pkg.Dispose();
        }

        public async Task Import(string filePath, TextGroup[] groups)
        {
            try
            {
                var pkg = new ExcelPackage();
                await pkg.LoadAsync(new FileInfo(filePath));

                foreach (var tg in groups)
                {
                    var ws = pkg.Workbook.Worksheets[tg.TextGroupInfo.Name];
                    if (ws is object)
                    {
                        for (int iti = 0; iti < tg.Count; iti++)
                        {
                            var ti = tg[iti];
                            var ri = iti + 2;
                            var c = ws.Cells[ri, 2];

                            ti.Text = ((string)c.Value).Replace("\r\n", "\n").Replace("\n", "\r\n");
                        }
                    }
                }

                pkg.Dispose();
            }
            catch (Exception)
            {
            }
        }
    }
}
