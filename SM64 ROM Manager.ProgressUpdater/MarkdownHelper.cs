using Markdig;
using Markdig.Syntax;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.ProgressUpdater
{
    class MarkdownHelper
    {
        public static MarkdownDocument GetDocument(string md)
        {
            return Markdown.Parse(md);
        }

        public static string GetPart(string md, Block startBlock, Block endBlock)
        {
            var mdNew = md.Remove(endBlock.Span.End + 1).Substring(startBlock.Span.Start);
            return mdNew;
        }

        public static Image GetAsImage(string md)
        {
            var html = Markdown.ToHtml(md);
            var img = TheArtOfDev.HtmlRenderer.WinForms.HtmlRender.RenderToImage(html, 500);
            return img;
        }

        public static IReadOnlyDictionary<string, string> SplitToVersions(string md)
        {
            var versions = new Dictionary<string, string>();
            var mdDoc = Markdown.Parse(md);

            foreach (var block in mdDoc)
            {

            }

            return versions;
        }
    }
}
