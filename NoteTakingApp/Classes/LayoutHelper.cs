using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.Classes
{
    public class LayoutHelper
    {
        private readonly PdfDocument _document;
        private readonly XUnit _topPosition;
        private readonly XUnit _bottomMargin;
        private XUnit _currentPosition;


        public LayoutHelper(PdfDocument document, XUnit topPosition, XUnit bottomMargin)
        {
            _document = document;
            _topPosition = topPosition;
            _bottomMargin = bottomMargin;
            // Set a value outside the page - a new page will be created on the first request.
            _currentPosition = bottomMargin + 10000;
            PageInfos = new List<PageInfo>();
        }

        public void setStartYPosition(double sp)
        {
            GetLinePosition(sp);
        }

        public double writeString(string str, XFont font, double x, double width, bool ignoreNewLine = false)
        {
            List<string> lines = g.GetSplittedLines(str, font, width);
            XPoint p = new XPoint(x, _currentPosition);
            int _x = 0;
            foreach (string line in lines)
            {
                if (line.Trim() == "") continue;
                //if (_x++ == 1 && !ignoreNewLine) p.Y = GetLinePosition(font.Height);
                p.Y = _currentPosition;
                g.DrawString(line, font, XBrushes.Black, p);
                if (!ignoreNewLine) GetLinePosition(font.Height);
                //if (lines.Count > 1 && !ignoreNewLine) GetLinePosition(font.Height);
            }
            //GetLinePosition(font.Height);
            return g.MeasureString(str, font).Width;
        }

        public XUnit GetLinePosition(XUnit requestedHeight)
        {
            return GetLinePosition(requestedHeight, -1f);
        }

        public XUnit GetLinePosition(XUnit requestedHeight, XUnit requiredHeight)
        {
            XUnit required = requiredHeight == -1f ? requestedHeight : requiredHeight;
            if (_currentPosition + required > _bottomMargin)
                CreatePage();
            XUnit result = _currentPosition;
            _currentPosition += requestedHeight;
            return result;
        }

        public double CurrentPosition => _currentPosition;
        public XGraphics g { get; private set; }
        public PdfPage Page { get; private set; }
        public List<PageInfo> PageInfos { get; private set; }
        public void CreatePage()
        {
            Page = _document.AddPage();
            Page.Size = PageSize.A4;
            g = XGraphics.FromPdfPage(Page);
            PageInfos.Add(new PageInfo(g, Page));
            _currentPosition = _topPosition;
        }


    }

    public class PageInfo
    {
        public XGraphics g { get; private set; }
        public PdfPage page { get; private set; }
        public PageInfo(XGraphics _g, PdfPage _p)
        {
            g = _g;
            page = _p;
        }
    }

    public static class gfxExtension
    {
        public static int GetSplittedLineCount(this XGraphics gfx, string content, XFont font, double maxWidth)
        {
            //handy function for creating list of string
            Func<string, IList<string>> listFor = val => new List<string> { val };
            // string.IsNullOrEmpty is too long :p
            Func<string, bool> nOe = str => string.IsNullOrEmpty(str);
            // return a space for an empty string (sIe = Space if Empty)
            Func<string, string> sIe = str => nOe(str) ? " " : str;
            // check if we can fit a text in the maxWidth
            Func<string, string, bool> canFitText = (t1, t2) => gfx.MeasureString($"{(nOe(t1) ? "" : $"{t1} ")}{sIe(t2)}", font).Width <= maxWidth;

            Func<IList<string>, string, IList<string>> appendtoLast =
                    (list, val) => list.Take(list.Count - 1)
                                       .Concat(listFor($"{(nOe(list.Last()) ? "" : $"{list.Last()} ")}{sIe(val)}"))
                                       .ToList();

            var splitted = content.Split(' ');

            var lines = splitted.Aggregate(listFor(""),
                    (lfeed, next) => canFitText(lfeed.Last(), next) ? appendtoLast(lfeed, next) : lfeed.Concat(listFor(next)).ToList(),
                    list => list.Count());

            return lines;
        }

        public static List<string> GetSplittedLines(this XGraphics gfx, string content, XFont font, double maxWidth)
        {
            int num = 0;
            var splitted = content.Split(' ');

            List<string> lines = new List<string>();
            string line = "";
            for (int i = 0; i < splitted.Length; i++)
            {
                line += splitted[i] + " ";
                if (gfx.MeasureString(line, font).Width > maxWidth)
                {
                    lines.Add(line.Trim());
                    num++;
                    line = "";
                }
            }
            if (line != "")
            {
                lines.Add(line.Trim());
                num++;
            }

            return lines;
        }
    }
}
