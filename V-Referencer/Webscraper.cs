using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;

namespace V_Referencer
{
    public class Webscraper
    {
        public static IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        //public IWebElement Title, Publisher, UploadDate;
        private string Url;
        public enum BrowserChoices
        {
            Chrome,
            Edge,
            Firefox,
        }
        private BrowserChoices DriverChoice;
        public enum ElementType
        {
            CssSelector,
            Id,
            Class,
        }

        SaveSettings save;

        public Webscraper(string url)
        {
            Url = url;
            save = new SaveSettings();
            DriverChoice = save.BrowserChoice;
            StartDriver(DriverChoice);
        }
        private void StartDriver(BrowserChoices browser)
        {
            try
            {
                switch(browser)
                {
                    case BrowserChoices.Chrome:
                        StartChromeDriver(Url);
                        break;
                    case BrowserChoices.Edge:
                        StartEdgeDriver(Url);
                        break;
                    case BrowserChoices.Firefox:
                        StartFirefoxDriver(Url);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("The webscraper may need to be updated.", $"{browser} Browser Driver failed to start");
            }

            try
            {
                Driver.Navigate().GoToUrl(Url);
            }
            catch (WebDriverArgumentException)
            {
                Driver.Quit();
                MessageBox.Show("Invalid Link");
                return;
            }

            // Explicit wait to ensure that the relavent elements are loaded before reading them.
            int timeout = 50000; // Maximum wait time of 50 seconds
            Wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout));

        }
        private void StartChromeDriver(string url)
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true; // Does this do anything?
            var options = new ChromeOptions();
            options.AddArguments("--window-position=-32000,-32000", "mute-audio"); // hide browser and mute audio
            Driver = new ChromeDriver(options);
        }
        private void StartEdgeDriver(string url)
        {
            var service = EdgeDriverService.CreateDefaultService();
            var options = new EdgeOptions();
            options.AddArguments("--window-position=-32000,-32000", "mute-audio");
            Driver = new EdgeDriver(options);
        }
        private void StartFirefoxDriver(string url)
        {
            var service = FirefoxDriverService.CreateDefaultService();
            var options = new FirefoxOptions();
            options.AddArguments("--window-position=-32000,-32000", "mute-audio");
            Driver=new FirefoxDriver(options);
        }

        public string FindTextElement(ElementType type, string elementToFind)
        {
            IWebElement element = null;
            element = FindElement(type, elementToFind);
            if(element != null)
            {
                return element.Text;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        private IWebElement FindElement(ElementType type, string elementToFind)
        {
            IWebElement element = null;
            switch (type)
            {
                case ElementType.CssSelector:
                    element = Driver.FindElement(By.CssSelector(elementToFind));
                    break;
                case ElementType.Id:
                    element = Driver.FindElement(By.Id(elementToFind));
                    break;
                case ElementType.Class:
                    element = Driver.FindElement(By.ClassName(elementToFind));
                    break;
            }
            return element;
        }
        public void ClickElement(ElementType type, string elementToFind)
        {
            IWebElement element = null;
            element = FindElement(type, elementToFind);
            element.Click();
        }
    }
}
