using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class PhysicalBook : Book
    {

        public PhysicalBook(int year, string title, int edition, string publisher, string publicationPlace, params string[] authors) : base(year, title, edition, publisher, publicationPlace, authors)
        {
            BeforeItalics = $"{WriteNames()} {PublishYear}. ";
            Italics = Title;
            AfterItalics = ReferenceAfterItalics();
        }
        
        public string ReferenceAfterItalics()
        {
            string output = ". ";
            if (Edition != 1)
            {
                output += $"{ToOrdinal(Edition)} ed. ";
            }
            output += $"{PublicationPlace}: {Publisher}";
            return output;
        }

    }
}
