using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using DomainProject.Webdriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProject.PageObjects
{
    public class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='search-box-a__search-mode-nav']//button[text()='Buy']")]
        private IWebElement BuyTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='search-box-a__search-mode-nav']//button[text()='Rent']")]
        private IWebElement RentTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='domain-home-content']//button[text()='New Homes']")]
        private IWebElement NewHomesTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='domain-home-content']//button[text()='Sold']")]
        private IWebElement SoldTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='domain-home-content']//button[text()='Rural']")]
        private IWebElement RuralTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='header-member__sign-in']")]
        private IWebElement LogInButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@class='header-member__sign-up']")]
        private IWebElement SignUpButton { get; set; }

        public string GetUrl()
        {
             return _driver.Url.ToString();
        }

        public void ClickBuyTab()
        {
            //BuyTab.Click();
            WebdriverExtensions.WaitAndClick(BuyTab);
        }

        public RentPage ClickRentTab()
        {
            //RentTab.Click();
            WebdriverExtensions.WaitAndClick(RentTab);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            return new RentPage(_driver);
        }

        public NewHomesPage ClickNewHomeTab()
        {
            //NewHomesTab.Click();
            WebdriverExtensions.WaitAndClick(NewHomesTab);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            return new NewHomesPage(_driver);
        }


        public SoldPage ClickSoldTab()
        {
            SoldTab.Click();
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            return new SoldPage(_driver);
        }

        public RuralPage ClickRuralTab()
        {
            RuralTab.Click();
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            return new RuralPage(_driver);
        }

        public SignUpPage ClickSingUpButton()
        {
            SignUpButton.Click();
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            return new SignUpPage(_driver);
        }


    }
}
