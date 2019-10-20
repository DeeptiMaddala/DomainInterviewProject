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
    public class SignUpPage
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public SignUpPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void goBack()
        {
            _driver.Navigate().Back();
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }


    }
}
