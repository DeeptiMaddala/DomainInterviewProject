using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProject.PageObjects
{
    public class RuralPage
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public RuralPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='search-box-a__search-mode-nav']//button[text()='Buy']")]
        private IWebElement MainPageTab { get; set; }

        public HomePage GoToMainPage()
        {
            MainPageTab.Click();
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            return new HomePage(_driver);
        }
    }
}
