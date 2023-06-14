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
    public class SteamVideoGame : VideoGame
    {
        public SteamVideoGame(string url) : base(url)
        {
            ScrapeWebsite();
        }

        public override void ScrapeWebsite()
        {
            try
            {
                webTitle = Webscraper.Driver.FindElement(By.Id("appHubAppName"));
                Title = webTitle.Text;
            }
            catch
            {
                MessageBox.Show("Couldn't find the title");
            }
            try
            {
                webDeveloperName = Webscraper.Driver.FindElement(By.CssSelector("#developers_list > a"));
                Name = webDeveloperName.Text;
            }
            catch
            {
                MessageBox.Show("Couldn't find the developer");
            }
            try
            {
                webPublisher = Webscraper.Driver.FindElement(By.CssSelector("#game_highlights > div.rightcol > div > div.glance_ctn_responsive_left > div:nth-child(4) > div.summary.column > a"));
                Publisher = webPublisher.Text;
            }
            catch
            {
                MessageBox.Show("Couldn't find the publisher");
            }
            try
            {
                webPublishDate = Webscraper.Driver.FindElement(By.CssSelector("#game_highlights > div.rightcol > div > div.glance_ctn_responsive_left > div.release_date > div.date"));
                PublishYear = GetPublishYear(webPublishDate.Text);
            }
            catch
            {
                MessageBox.Show("Couldn't find the publish year");
            }
            Webscraper.Driver.Quit();

            base.ScrapeWebsite();
        }
    }
}
