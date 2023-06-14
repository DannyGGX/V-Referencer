using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public abstract class Citation
    {
        public string WebsiteName { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string PublishDateFormatted
        { 
            get { return FormatDate(PublishDate); }
        }
        public int PublishYear { get; set; }
        public DateTime AccessDate { get; set; }
        public string AccessDateFormatted
        {
            get { return FormatDate(AccessDate); }
            set { }
        }
        public string Url { get; set; }

        public string Name { get; set; }
        public string Surname
        {
            get { return Name.Substring(Name.IndexOf(' ') + 1); }
        }
        private char NameInitial
        {
            get { return Name[0]; }
        }
        public virtual string NameFormatted
        {
            get { return $"{Surname}, {NameInitial}"; }
        }
        
        public Citation()
        {
        }
        
        private string FormatDate(DateTime date)
        {
            Months monthEnum = (Months)date.Month;
            string month = monthEnum.ToString();
            return $"{date.Day} {month} {date.Year}";
        }
        public enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        // Following variables is for reference text
        public string BeforeItalics { get; set; }
        public string Italics { get; set; }
        public string AfterItalics { get; set; }

        public string InTextPerson 
        { 
            get
            {
                return $"({Surname}, {PublishYear})";
            } 
        }
        public string InTextNotPerson
        {
            get
            {
                if (String.IsNullOrEmpty(Name))
                    return $"({WebsiteName}, {PublishYear})";
                else
                {
                    return $"({Name}, {PublishYear})";
                }
            }
        }

        // Copy of this method in UIController
        public string EnumNameToString(Enum enumName) // puts spaces after capital letters
        {
            string enumStr = enumName.ToString();
            string manipulatedStr = enumStr;
            int changes = 0;
            for (int index = 1; index < enumStr.Length; index++) // index = 1 because no space before first letter
            {
                if (Char.IsUpper(enumStr[index]))
                {
                    manipulatedStr = manipulatedStr.Insert(index + changes, " ");
                    changes++;
                }
            }
            return manipulatedStr;
        }

        public string ToSentenceCase(string text)
        {
            string[] words = text.Split(' ');
            for (int i = 1; i < words.Length; i++) // start at index 1 to keep first word capitalised
            {
                if (IsAcronym(words[i]) == false)
                {
                    words[i] = words[i].ToLower();
                }
            }
            return string.Join(" ", words);
        }
        private bool IsAcronym(string word)
        {
            bool isAcronym = true;
            for (int i = 0; i < word.Length - 1; i++) // Length - 1 in case there is a . , or : at end of word
            {
                if (!Char.IsUpper(word[i]))
                {
                    isAcronym = false;
                    break;
                }
            }
            return isAcronym;
        }
    }
}
