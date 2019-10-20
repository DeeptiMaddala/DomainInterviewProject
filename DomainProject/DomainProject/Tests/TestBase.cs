using DomainProject.Webdriver;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProject.Tests
{
    [TestFixture]
    public class TestBase
    {
        public static Browser browser;
        public static IWebDriver driver;
        public string EnvironmentUrl = ConfigurationManager.AppSettings["BaseUrl"];

        [OneTimeSetUp]
        public void FirstSetup()
        {
            browser = new Browser();
            driver = browser.InitializeDriver(ConfigurationManager.AppSettings["BrowserName"]);
            browser.LoadUrl("");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
           browser.CloseAllDrivers();
        }
    }
}
