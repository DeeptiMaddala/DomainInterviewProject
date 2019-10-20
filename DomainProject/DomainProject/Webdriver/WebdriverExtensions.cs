using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProject.Webdriver
{
    public static class WebdriverExtensions
    {

        public static bool WaitAndClick(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.Timeout = TimeSpan.FromSeconds(20);

            bool isElementVisible = wait.Until<bool>(ele =>
            {
                if (ele.Displayed && ele.Enabled)
                {
                    ele.Click();
                    return true;
                }
                else
                {
                    return false;
                }
            });

            return isElementVisible;
        }
    }
}
