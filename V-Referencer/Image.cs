using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public abstract class Image : Citation
    {

        public struct ReferenceText
        {
            public string BeforeItalics, Italics, AfterItalics;
        }
        public struct FigureText
        {
            public string BeforeItalics, Italics, AfterItalics;
        }
        public struct CaptionText
        {
            public string BeforeItalics, Italics, AfterItalics;
        }
        public ReferenceText referenceText = new ReferenceText();
        public FigureText figureText = new FigureText();
        public CaptionText captionText = new CaptionText();

        public Image(string title)
        {
            Title = title;
        }

        public virtual void CreateFigure(int figureNum = 0)
        {
            if (figureNum == 0)
            {
                figureText.BeforeItalics = "";
            }
            else
            {
                figureText.BeforeItalics = $"Figure {figureNum}: ";
            }
            
        }

        public virtual void CreateReference()
        {

        }
    }
}
