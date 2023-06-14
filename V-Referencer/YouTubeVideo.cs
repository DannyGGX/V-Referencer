﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;

// Instead of using Selenium, download the webpage temporariliy to scrape off the info with HtmlAgility

namespace V_Referencer
{
    public class YouTubeVideo : Citation
    {
        public YouTubeVideo(DateTime accessDate, string url)
        {
            AccessDate = accessDate;
            Url = url;
            webscraper = new Webscraper(url);
            ScrapeYouTube();
        }
        private Webscraper webscraper;

        //private static IWebDriver Driver { get; set; }
        //private WebDriverWait Wait { get; set; }

        //private void InitialiseChromeDriver(string url)
        //{
        //    try
        //    {
        //        var service = ChromeDriverService.CreateDefaultService();
        //        service.HideCommandPromptWindow = true; // Does this do anything?
        //        var options = new ChromeOptions();
        //        options.AddArguments("--window-position=-32000,-32000", "mute-audio"); // hide browser and mute audio
        //        Driver = new ChromeDriver(options);
        //    }
        //    catch (Exception e)
        //    {
        //       // Driver.Quit();
        //        MessageBox.Show(e.Message, "Browser Driver failed to start"); // maybe need to update package
        //        //return;
        //    }
        //    try
        //    {
        //        Driver.Navigate().GoToUrl(url);
        //    }
        //    catch (WebDriverArgumentException)
        //    {
        //        Driver.Quit();
        //        MessageBox.Show("Invalid Link");
        //        return;
        //    }

        //    // Explicit wait to ensure that the relavent elements are loaded before reading them.
        //    int timeout = 50000; // Maximum wait time of 50 seconds
        //    Wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout));
        //    ScrapeYouTube();

        //}

        private void ScrapeYouTube()
        {
            int adssuck = 5; // try 5 times
            while(adssuck > 0)
            {
                try
                {
                    webscraper.Wait.Until(d => d.FindElement(By.CssSelector("#below > ytd-watch-metadata")));
                    break;
                }
                catch(Exception e)
                {
                    adssuck--;
                    if(adssuck == 0)
                    {
                        MessageBox.Show($"Ads stopped scraper from working. The scraper may have timed out.{Environment.NewLine}{e.Message}", "Ads Suck Error");
                    }
                }

            }
            
            IWebElement title;
            IWebElement channelName;
            IWebElement uploadDate;
            try
            {
                title = Webscraper.Driver.FindElement(By.CssSelector("#title > h1 > yt-formatted-string"));
                Title = title.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show("Couldn't scrape the title.", "Webscrape Title Error");
            }
            try
            {
                channelName = Webscraper.Driver.FindElement(By.Id("channel-name"));
                Name = channelName.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show("Coudn't scrape the channel name.", "Webscrape Channel Name Error");
            }
            try
            {
                Webscraper.Driver.FindElement(By.Id("expand")).Click(); // Show Description to get accurate date, not a date that is rounded off to the nearest year or month.
            }
            catch
            {
                MessageBox.Show($"Coudn't expand the description.{Environment.NewLine}This is needed for getting an accurate upload date");
            }
            try
            {
                uploadDate = Webscraper.Driver.FindElement(By.CssSelector("#info > span:nth-child(3)"));
                yearStr = uploadDate.Text.Substring(uploadDate.Text.Length - 4, 4);
                //PublishYear = int.Parse(yearStr);
            }
            catch (Exception e)
            {
                MessageBox.Show("Couldn't find the video upload date");
            }

            Webscraper.Driver.Quit();
        }
        private string yearStr;
        public string ItalicsText()
        {
            return $"{Title} - {Name}.";
        }
        public string AfterItalicsText()
        {
            return $" {yearStr}. YouTube video, added by {Name}. [Online]. Available at: {Url} [Accessed {AccessDateFormatted}].";
        }

        public string InText()
        {
            return $"(see {Title} - {Name}, {yearStr})";
        }
    }
}
