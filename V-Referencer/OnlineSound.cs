using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class OnlineSound : Citation
    {

        public OnlineSound(string publisher, string title, int publishYear, string link, DateTime accessDate)
        {
            Name = publisher;
            Title = title;
            PublishYear = publishYear;
            Url = link;
            AccessDate = accessDate;

            BeforeItalics = $"{Name}. {PublishYear}. ";
            Italics = Title;
            AfterItalics = $". [Sound Recording]. Available at: {Url} (Accessed {AccessDateFormatted}).";
        }

        public string CreateInText()
        {
            return $"{Name} ({PublishYear})";
        }
    }
}
