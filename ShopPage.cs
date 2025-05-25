using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFramework.PageObject
{
    public class ShopPage : BasePage
    {
        public ShopPage(IWebDriver driver) : base(driver) { }

        IWebElement headingQuickShop => driver.FindElement(By.XPath("//h1[contains(translate(text(), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), 'quick shop')]"));

        public bool IsQuickShopHeadingVisible()
        {
            return headingQuickShop.Displayed;
        }
    }
}