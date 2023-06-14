using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace V_Referencer
{
    public class SaveSettings
    {
        private const string saveFileName = "V-ReferencerSave.txt";
        private string[] DataPoints = new string[Enum.GetValues(typeof(Data)).Length];

        // Save data variables for other parts of the program to access
        public string FontName { get; set; }
        public float FontSize { get; set; }
        public string Username { get; set; }
        public int FigureNum { get; set; }

        public Webscraper.BrowserChoices BrowserChoice { get; set; }

        public const string DefaultFontName = "Arial";
        public const float DefaultFontSize = 11f;

        public enum Data // For accessing datapoints by name and casting to int if can't remember the right index
        {
            FontName,
            FontSize,
            Username,
            FigureNum,
            BrowserChoice,
        }

        public SaveSettings()
        {
            ReadFileAll();
            try // Check if there's save data for citation font
            {
                FontName = DataPoints[(int)Data.FontName];
                FontSize = float.Parse(DataPoints[(int)Data.FontSize]);
            }
            catch // ArguementNullException and FormatException
            {
                FontName = DefaultFontName;
                FontSize = DefaultFontSize;
            }
            //if (DataPoints[0] != "" || DataPoints[1] != null)
            //{
            //}
            //else
            //{
            //    FontName = "Arial";
            //    FontSize = 11f;
            //}
            Username = DataPoints[(int)Data.Username];
            try
            {
                FigureNum = int.Parse(DataPoints[(int)Data.FigureNum]);
            }
            catch
            {
                FigureNum = 1;
            }
            try
            {
                BrowserChoice = (Webscraper.BrowserChoices)int.Parse(DataPoints[(int)Data.BrowserChoice]);
            }
            catch 
            {
                BrowserChoice = Webscraper.BrowserChoices.Chrome;
            }
        }

        public bool SpecificSaveExists(params int[] indexs)
        {
            ReadFileAll();
            for(int i = 0; i < indexs.Length; i++)
            {
                if (DataPoints[indexs[i]] == "" || DataPoints[indexs[i]] == null)
                {
                    return false; // doesn't exist
                }
            }
            return true; // does exist
        }

        public void ReadFileAll()
        {
            if(File.Exists(saveFileName))
            {
                DataPoints = File.ReadAllLines(saveFileName);
            }
        }

        public void SaveCitationFont(string fontName, float fontSize)
        {
            ReadFileAll();
            DataPoints[0] = fontName;
            DataPoints[1] = fontSize.ToString();
            File.WriteAllLines(saveFileName, DataPoints);
        }

        public void SaveName(string name)
        {
            ReadFileAll();
            DataPoints[(int)Data.Username] = name;
            File.WriteAllLines(saveFileName, DataPoints);
        }
        public void SaveFigureNum(int number)
        {
            ReadFileAll();
            DataPoints[(int)Data.FigureNum] = number.ToString();
            File.WriteAllLines(saveFileName, DataPoints);
        }

        public void SaveBrowserChoice(Webscraper.BrowserChoices choice)
        {
            ReadFileAll();
            DataPoints[((int)Data.BrowserChoice)] = ((int)choice).ToString();
            File.WriteAllLines(saveFileName, DataPoints);
        }
        
        public void DeleteSave()
        {
            File.Delete(saveFileName);
        }
    }
}
