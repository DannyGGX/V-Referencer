using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class OwnDrawing : Image
    {
        public enum Places
        {
            Johannesburg,
            CapeTown,
            Pretoria,
            Durban,
        }
        private Places Place;
        public const int NumberOfPlaces = 4;

        public OwnDrawing(string title, string name, int year, int placeIndex) : base(title)
        {
            Title = title;
            Name = name;
            PublishYear = year;
            Place = (Places)placeIndex;
            BeforeItalics = $"{NameFormatted}. {PublishYear}. {Title}. [Personal drawing]. {EnumNameToString(Place)}: Unpublished."; // Whole reference is not in italics
        }

        public override void CreateFigure(int figureNum = 0)
        {
            base.CreateFigure(figureNum);
            figureText.Italics = Title;
            figureText.AfterItalics = $" ({Surname}, {PublishYear})";
        }
    }
}
