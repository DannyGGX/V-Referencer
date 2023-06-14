using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class OwnPhoto : Image
    {

        private int year;
        public OwnPhoto(string name, string title, int year) : base(title)
        {
            Name = name;
            this.year = year;
            PublishYear = year;
        }

        public override void CreateFigure(int figureNum = 0)
        {
            base.CreateFigure(figureNum);
            figureText.Italics = Title;
            figureText.AfterItalics = $" ({Surname}, {PublishYear})";
        }

        public override void CreateReference()
        {
            //return $"{NameFormatted}. {year}. {Title}. [Photograph] [Personal Collection]. Unpublished.";
            referenceText.BeforeItalics = $"{NameFormatted}. {year}. ";
            referenceText.Italics = Title;
            referenceText.AfterItalics = $". [Photograph] [Personal Collection]. Unpublished.";
        }
        
    }
}
