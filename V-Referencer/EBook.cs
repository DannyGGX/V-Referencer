using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class EBook : Book
    {
        public string[] websiteChoices =
        {
            "EBSCOhost",
            "Wizebooks",
            "Other"
        };

        private ConvertCitation convert;
        public EBook(int year, string title, int edition, string publisher, string publicationPlace, string url, int websiteChoiceIndex, DateTime accessDate, params string[] authors) : base(year, title, edition, publisher, publicationPlace, authors)
        {
            Url = url;
            AccessDate = accessDate;
            if (websiteChoices[websiteChoiceIndex] != "Other")
            {
                WebsiteName = websiteChoices[websiteChoiceIndex];
            }

            BeforeItalics = $"{WriteNames()}{PublishYear}. {ToSentenceCase(Title)}. {PublicationPlace}: {Publisher}. [eBook]. Available on {WebsiteName} at: {Url} [Accessed {AccessDateFormatted}]."; // Whole reference is not in italics
        }
    }
}
