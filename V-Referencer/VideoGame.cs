using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace V_Referencer
{
    public abstract class VideoGame : Citation
    {
        public string Publisher { get; set; }
        public string PublishCity { get; set; }

        public enum Websites
        {
            Steam
        }

        public static string[] Platforms =
        {
            "PC", "PS4", "PS5", "Xbox One", "Nintendo Switch",
        };
        public string Platform { get; set; }
        public IWebElement webTitle { get; set; }
        public IWebElement webDeveloperName { get; set; }
        public IWebElement webPublisher { get; set; }
        public IWebElement webPublishDate { get; set; }

        public Webscraper webscraper { get; set; }

        public VideoGame(string url)
        {
            webscraper = new Webscraper(url);
        }

        public virtual void ScrapeWebsite()
        {
            
        }

        public void CreateCitation()
        {
            BeforeItalics = $"{Name}. {PublishYear}. ";
            Italics = Title;
            AfterItalics = $" [Digital Game], {Platform}. {PublishCity}: {Publisher}.";
        }

        public int GetPublishYear(string dateText)
        {
            string yearStr = dateText.Substring(dateText.Length - 4, 4);
            return int.Parse(yearStr);
        }
    }
}
