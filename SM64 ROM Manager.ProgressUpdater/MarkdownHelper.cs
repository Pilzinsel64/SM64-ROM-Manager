using Markdig;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using static Microsoft.VisualBasic.CompilerServices.LikeOperator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

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
            var mdNew = md;

            if (endBlock.Span.End + 1 < mdNew.Length)
                mdNew = mdNew.Remove(endBlock.Span.End + 1);

            if (startBlock.Span.Start > 0)
                mdNew = mdNew.Substring(startBlock.Span.Start);

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

            var currentVersionText = string.Empty;
            Block startBlock = null;
            Block endBlock = null;

            void addDocument()
            {
                if (startBlock is object && endBlock is object)
                {
                    var mdNew = GetPart(md, startBlock, endBlock);
                    versions.Add(currentVersionText, mdNew);
                    startBlock = endBlock = null;
                    currentVersionText = string.Empty;
                }
            }

            foreach (var block in mdDoc)
            {
                if (block is HeadingBlock)
                {
                    var hblock = (HeadingBlock)block;
                    var content = (hblock.Inline.FirstOrDefault() as LiteralInline).Content.ToString();

                    if (!string.IsNullOrEmpty(content) && LikeString(content, "Version *", CompareMethod.Text))
                    {
                        addDocument();
                        startBlock = hblock;
                        currentVersionText = content;
                    }
                }
                else if (block is ThematicBreakBlock)
                    addDocument();

                endBlock = block;
            }

            addDocument();

            return versions;
        }
    }
}
