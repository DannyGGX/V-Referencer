using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class ConvertCitation : Citation
    {
        public ConvertCitation(string citation)
        {
            try
            {
                PublishYear = GetPublishYear(citation);
                if (HasSeparateAuthorAndWebsite(citation))
                {
                    WebsiteName = GetWebsiteName(citation);
                }
                else
                {
                    WebsiteName = GetPublisher(citation);
                }
                Name = GetPublisher(citation);
                Title = GetTitle(citation);
                Url = GetUrl(citation);
                //AccessDateFormatted = ConvertDateFormat(GetAccessDate(citation));

                int day = GetDateDay(GetAccessDate(citation));
                Months month = ConvertMonthFormat(GetMonthAbbreviation(GetAccessDate(citation)));
                int year = GetDateYear(GetAccessDate(citation));
                AccessDate = ToDate(day, month, year);
            }
            catch
            {
                MessageBox.Show($"Could not properly convert the citation.{Environment.NewLine}Only citations from MyBib Citation Generator work.", "Convert Citation Error");
                AccessDate = DateTime.Today; // To not crash when setting dateTimePicker values
                Title = "";
            }
        }
        private int GetPublishYear(string citation)
        {
            bool numberNotFound = true;
            int bracketIndex;
            while(numberNotFound)
            {
                bracketIndex = citation.IndexOf('(');
                if (citation[bracketIndex + 5] == ')')
                {
                    string yearStr = citation.Substring(bracketIndex + 1, 4);
                    if(int.TryParse(yearStr, out int yearInt))
                    {
                        numberNotFound = false;
                        return yearInt;
                    }
                }
                else
                {
                    citation = citation.Remove(bracketIndex, 1);
                }
            }
            throw new NullReferenceException();
        }

        private string GetPublisher(string citation)
        {
            int start = 0;
            int end = citation.IndexOf(" (");
            end += MinusFullStop(citation, end);
            return citation.Substring(start, end - start); // length = end - start
        }
        private string GetTitle(string citation)
        {
            int start = citation.IndexOf(").") + 3;
            try
            {
                int end = citation.IndexOf(" [online]");
                end += MinusFullStop(citation, end);
                return citation.Substring(start, end - start);
            }
            catch
            {
                int end = citation.IndexOf(" YouTube. ");
                end += MinusFullStop(citation, end);
                return citation.Substring(start, end - start);
            }
        }

        private string GetUrl(string citation)
        {
            int start = citation.IndexOf("http");
            int end = citation.IndexOf(" [Accessed ");
            return citation.Substring(start, end - start);
        }
        private string GetAccessDate(string citation)
        {
            int start = citation.IndexOf("[Accessed ") + 10;
            int end = citation.LastIndexOf("].");
            return citation.Substring(start, end - start);
        }
        private string GetMonthAbbreviation(string accessDate)
        {
            int start = accessDate.IndexOf(' ') + 1;
            int length = 3;
            return accessDate.Substring(start, length);
        }

        private string[] monthAbbreviations = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private Months ConvertMonthFormat(string month)
        {
            int monthIndex = Array.IndexOf(monthAbbreviations, month);
            return (Months)monthIndex + 1; // +1 to zero based monthIndex
        }
        private string ConvertDateFormat(string accessDate)
        {
            string month = ConvertMonthFormat(GetMonthAbbreviation(accessDate)).ToString();
            return accessDate.Replace(GetMonthAbbreviation(accessDate), month);
        }
        private DateTime ToDate(int day, Months month, int year)
        {
            string dateStr = $"{(int)month}/{day}/{year}";
            return Convert.ToDateTime(dateStr);
        }
        private int GetDateDay(string accessDate)
        {
            string dayStr = accessDate.Substring(0, 2);
            return int.Parse(dayStr);
        }
        private int GetDateYear(string accessDate)
        {
            string yearStr = accessDate.Substring(accessDate.Length - 4, 4);
            return Convert.ToInt32(yearStr);
        }
        private bool HasSeparateAuthorAndWebsite(string citation)
        {
            return !citation.Contains("[online] Available");
        }
        private string GetWebsiteName(string citation)
        {
            int start = citation.IndexOf("[online] ") + 9;
            int end = citation.IndexOf("Available") - 2;
            return citation.Substring(start, end - start);
        }

        private int MinusFullStop(string text, int startIndex)
        {
            // look 1 letter before startIndex to see if it is a fullstop
            if (text[startIndex - 1] == '.')
            {
                return -1; // minus it from substring selections
            }
            else return 0;
        }
    }
}
