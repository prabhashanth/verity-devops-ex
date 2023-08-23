using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V109.DOM;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeleniumGrid
{
    
    public class BaseSetUp
    {
        public  static IWebDriver driver;
        
        public void BrowserOptions(string browser)
        {
            if (browser == "chrome")
            {
                ChromeOptions options = new ChromeOptions();
              //  driver = new RemoteWebDriver(new Uri(uriString: "http://10.61.220.106:4444"), options);
               
                driver.Url = "http://www.google.com/";
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            }
            if (browser == "Edge")
            {
                EdgeOptions options = new EdgeOptions();
                driver = new RemoteWebDriver(new Uri(uriString: "http://10.61.220.106:4444"), options);
                driver.Url = "http://www.google.com/";
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
            if (browser == "firefox")
            {
                FirefoxOptions options = new FirefoxOptions();
                driver = new RemoteWebDriver(new Uri(uriString: "http://10.61.220.106:4444"), options);
                driver.Url = "http://www.google.com/";
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
        }
        
    }
}