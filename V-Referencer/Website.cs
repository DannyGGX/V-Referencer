using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class Website : Citation
    {

        
        public Website(string websiteName, string title, DateTime publicationDate, string url, DateTime accessDate)
        {
            WebsiteName = websiteName;
            Title = title;
            PublishYear = publicationDate.Year;
            PublishDate = publicationDate;
            Url = url;
            AccessDate = accessDate;

        }
        public Website(string websiteName, string title, int publishYear, string url, DateTime accessDate)
        {
            WebsiteName = websiteName;
            Title = title;
            PublishYear = publishYear;
            Url = url;
            AccessDate = accessDate;

        }

        //Try sentence casing. But that will need a dictionary API to see if words are proper nouns.

        public string CreateCitation(bool completeDate)
        {
            if (completeDate)
            {
                return $"{WebsiteName}. {PublishYear}. {Title}, {PublishDateFormatted}. [Online]. Available at: {Url} [Accessed {AccessDateFormatted}].";
            }
            else
            {
                return $"{WebsiteName}. {PublishYear}. {Title}. [Online]. Available at: {Url} [Accessed {AccessDateFormatted}].";
            }
        }

        public string CreateInText()
        {
            return $"({WebsiteName}, {PublishYear})";
        }
    }
}
