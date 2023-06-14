using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public abstract class Book : Citation
    {
        private string[] Authors { get; set; }
        public int Edition { get; set; }
        public string PublicationPlace { get; set; }
        public string Publisher { get; set; }
        public override string NameFormatted => $"{base.NameFormatted}.";

        public struct InText
        {
            public string SentenceStart, SentenceEnd;
        }

        public Book(int year, string title, int edition, string publisher, string publicationPlace, params string[] authors)
        {
            Authors = authors;
            PublishYear = year;
            Title = title;
            Edition = edition;
            Publisher = publisher;
            PublicationPlace = publicationPlace;
            InText inText = new InText();
        }

        public string WriteNames()
        {
            string output = "";
            if(Authors.Length > 1)
            {
                for (int nameIndex = 0; nameIndex < Authors.Length - 1; nameIndex++)
                {
                    output += $"{FormatName(Authors[nameIndex])}, ";
                }
                output = output.Remove(output.Length - 2); // remove the last "," before "and"
                output += $" and {FormatName(Authors[Authors.Length - 1])}";
            }
            else
            {
                output = FormatName(Authors[0]);
            }
            return output;
        }
        private string FormatName(string rawName)
        {
            Name = rawName;
            return NameFormatted;
        }

        public string[] Surnames
        {
            get { return GetSurnames(); }
        }
        private string[] GetSurnames()
        {
            string[] surnames = new string[Authors.Length];
            for (int nameIndex = 0; nameIndex < Authors.Length; nameIndex++)
            {
                Name = Authors[nameIndex];
                surnames[nameIndex] = Surname;
            }
            return surnames;
        }

        public string CreateInText(bool endOfSentence = true)
        {
            string output = "";
            if (Surnames.Length > 1)
            {
                for (int nameIndex = 0; nameIndex < Surnames.Length - 1; nameIndex++)
                {
                    output += $"{Surnames[nameIndex]}, ";
                }
                output = output.Remove(output.Length - 2); // remove the last "," before "and"
                if(endOfSentence)
                {
                    output += " & ";
                }
                else
                {
                    output += " and ";
                }
            }
            output += Surnames[Surnames.Length - 1];
            if(endOfSentence)
            {
                output = output.Insert(0, "(");
                output += $", {PublishYear}). ";
            }
            else
            {
                output += $" ({PublishYear}) ";
            }
            return output;
        }

        public static string ToOrdinal(int value) // convert to ordinal number
        {// Works for values 0 to 110

            // Separate the ones digit from the rest of the number:
            string valueString = value.ToString();
            string onesInput = valueString.Substring(valueString.Length - 1);
            int onesNum = int.Parse(onesInput);

            if (value > 0)
            {
                if (value > 10 && value < 14) //if value is 11 to 13: add "th" instead
                {
                    return value + "th";
                }
                else
                {
                    return onesNum switch
                    {
                        1 => value + "st",
                        2 => value + "nd",
                        3 => value + "rd",
                        _ => value + "th", // "_" means default
                    };
                }
            }
            else return "(Value can't be negative)";
        }

        public int GetOrdinalIndex(string text)
        {
            int index = text.IndexOf(" ed. ") - 2;
            return index;
        }
        public void ToSuperscript(RichTextBox rtxt, int start)
        {
            // Select text to replace with superscript version of the text
            rtxt.Select(start, 2);

            string selectedRtf = rtxt.SelectedRtf;
            string selectedText = rtxt.SelectedText;

            selectedRtf = selectedRtf.Insert(selectedRtf.IndexOf(selectedText), "\\super ");

            // set the Rtf back to normal
            rtxt.SelectedRtf = selectedRtf;
        }
    }
}
