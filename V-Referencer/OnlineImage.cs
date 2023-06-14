using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class OnlineImage : Image
    {
        private string publishYear; // string because it can be s.a.
        private int websiteYear;
        private bool hasArtistName;
        public OnlineImage(string name, string title, string year, string websiteName, string url, DateTime accessDate, int websiteYear) : base(title)
        {
            this.publishYear = year;
            Name = name;
            WebsiteName = websiteName;
            Url = url;
            hasArtistName = true;

            AccessDate = accessDate;
            this.websiteYear = websiteYear;
        }
        public OnlineImage(string title, string year, string websiteName, string url, DateTime accessDate, int websiteYear) : base (title)
        {
            this.publishYear=year;
            WebsiteName = websiteName;
            Url=url;
            hasArtistName = false;

            AccessDate = accessDate;
            this.websiteYear = websiteYear;
        }
        public void CreateCaption(bool hasArist, int figureNum = 0)
        {
            if (figureNum == 0)
            {
                captionText.BeforeItalics = "";
            }
            else
            {
                captionText.BeforeItalics = $"Figure {figureNum}: ";
            }
            if(hasArist)
            {
                captionText.BeforeItalics += $"{Name}. [{publishYear}]. ";
                captionText.AfterItalics = $". ({WebsiteName}, {websiteYear})";
            }
            else
            {
                captionText.BeforeItalics += $"";
                captionText.AfterItalics = $". [{publishYear}]. ({WebsiteName}, {websiteYear})";
            }
            captionText.Italics = Title;
        }
        public void CreateFigure(bool hasArist, int figureNum = 0)
        {
            if (figureNum == 0)
            {
                figureText.BeforeItalics = "";
            }
            else
            {
                figureText.BeforeItalics = $"Figure {figureNum}: ";
            }
            if (hasArist)
            {
                figureText.BeforeItalics += $"{Name}. [{publishYear}]. ";
                figureText.AfterItalics = $".";
            }
            else
            {
                figureText.BeforeItalics += $"";
                figureText.AfterItalics = $". [{publishYear}].";
            }
            figureText.Italics = Title;
        }

        public override void CreateReference()
        {
            referenceText.BeforeItalics = $"{WebsiteName}. {websiteYear}. ";
            referenceText.Italics = Title;
            referenceText.AfterItalics = $". [Online]. Available at: {Url} [Accessed {AccessDateFormatted}].";
        }

        public struct InText
        {
            public string BeforeItalics, Italics;
        }
        public InText inText = new InText();

        public void CreateInText()
        {
            if(String.IsNullOrEmpty(Name))
            {
                inText.BeforeItalics = $"{WebsiteName}'s ({publishYear}) image, ";
            }
            else
            {
                inText.BeforeItalics = $"{Name}'s ({publishYear}) image, ";
            }
            inText.Italics = Title;
        }
    }
}
