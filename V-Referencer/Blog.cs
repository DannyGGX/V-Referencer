using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class Blog : Citation
    {

        public Blog(string publisher, string websiteName, string title, string url, DateTime publishDate, DateTime accessDate)
        {
            Name = publisher;
            WebsiteName = websiteName;
            Title = title;
            Url = url;
            PublishDate = publishDate;
            AccessDate = accessDate;
        }
        
        public string CreateCitation(bool authorNameNeedFormatting = false)
        {
            string text;
            if(authorNameNeedFormatting)
            {
                text = NameFormatted;
            }
            else
            {
                text = Name;
            }
            text += $". {PublishDate.Year}. {Title}, {WebsiteName}, {PublishDateFormatted}. [Blog]. Available at: {Url} [Accessed {AccessDateFormatted}].";
            return text;
        }
        public string CreateInText(bool authorNameNeedFormatting = false)
        {
            if (authorNameNeedFormatting)
            {
                return $"{Surname} ({PublishDate.Year})";
            }
            else
            {
                return $"{Name} ({PublishDate.Year})";
            }
        }
    }
}
