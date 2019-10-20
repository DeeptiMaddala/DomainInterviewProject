using NUnit.Framework;
using OpenQA.Selenium;
using DomainProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProject.Tests
{
    [TestFixture]
    public class NavigationTest : TestBase
    {
  
        [Test]
        public void NavigationToTabs()
        {
            HomePage homePage = new HomePage(driver);
            //Navigate to BuyTab;
            homePage.ClickBuyTab();
            string buyPageUrl = homePage.GetUrl();
            Assert.AreEqual(EnvironmentUrl+"/", buyPageUrl);
            Console.WriteLine("Buy Page is opened");

            //Navigate to RentTab
            RentPage rentPage = homePage.ClickRentTab();
            Assert.IsNotNull(rentPage);
            Assert.AreEqual(EnvironmentUrl + "/?mode=rent", homePage.GetUrl());
            Console.WriteLine("Rent page is opened");

            //Navigate to NewHomesTab
            NewHomesPage newHomesPage = homePage.ClickNewHomeTab();
            Assert.IsNotNull(newHomesPage);
            Assert.AreEqual(EnvironmentUrl + "/new-homes",homePage.GetUrl());
            Console.WriteLine("New homes page is opened");

            //Navigate to SoldTab
            SoldPage soldPage = homePage.ClickSoldTab();
            Assert.IsNotNull(soldPage);
            Assert.AreEqual(EnvironmentUrl + "/?mode=sold",homePage.GetUrl());
            Console.WriteLine("Sold Page is opened");

            //Navigate to RuralTab
            RuralPage ruralPage = homePage.ClickRuralTab();
            Assert.IsNotNull(ruralPage);
            Assert.AreEqual(EnvironmentUrl + "/rural",homePage.GetUrl());
            Console.WriteLine("Rural page is opened");

            //Navigate to SignupPage
            SignUpPage signupPage = homePage.ClickSingUpButton();
            Assert.IsNotNull(signupPage);
            Assert.IsTrue(driver.Url.Contains("https://auth.domain.com.au/v1/signup"));
            Console.WriteLine("Signup Page is opened");
            signupPage.goBack();
            //Re-verify the rural page is visible again
            Assert.AreEqual(EnvironmentUrl + "/rural", homePage.GetUrl());
            Console.WriteLine("Rural page is opened again");
        }
    }
}
