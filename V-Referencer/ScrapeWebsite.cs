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

namespace V_Referencer
{
    public interface ScrapeWebsite
    {
        IWebElement TitleElement { get; set; }
        IWebElement Publisher { get; set; }

    }
}
