using AutomationFramework.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationFramework
{
    public class Tests
    {
        IWebDriver browser;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("SetUp почався");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            browser = new ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Url = "https://www.hempitecture.com/";
            Console.WriteLine("SetUp закінчився");
        }

        [Test]
        public void TestShopNavigation()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickShopButton();

            string expectedURL = "https://www.hempitecture.com/shop/";
            Assert.AreEqual(expectedURL, browser.Url);

            ShopPage shopPage = new ShopPage(browser);
            Assert.IsTrue(shopPage.IsQuickShopHeadingVisible());
        }

        [Test]
        public void TestContactLinkVisibleOnHomePage()
        {
            HomePage homePage = new HomePage(browser);
            Assert.IsTrue(homePage.IsContactLinkVisible());
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown почався");
            browser.Quit();
            Console.WriteLine("TearDown закінчився");
        }
    }
}