using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProject.Webdriver
{
    public class Browser
    {
        private IWebDriver _driver;
        private string EnvironmentUrl = ConfigurationManager.AppSettings["BaseUrl"];

        public IWebDriver GetDriver
        {
            get { return _driver; }
        }

        public IWebDriver InitializeDriver(string browsername)
        {
            switch (browsername.ToLower())
            {
                case "firefox":
                    _driver = new FirefoxDriver();
                    break;
                default:
                    _driver = new ChromeDriver();
                    break;
            }

            return _driver;
        }

        public void LoadUrl(string url)
        {
            _driver.Navigate().GoToUrl(EnvironmentUrl+url);
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
           
        public void CloseAllDrivers()
        {
            _driver.Quit();
            _driver.Close();
        }

    }
}
