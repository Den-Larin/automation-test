using OpenQA.Selenium;

namespace AutomationFramework.PageObject
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        IWebElement btnShop => driver.FindElement(By.XPath("//a[@href='/shop']"));

        IWebElement linkContact => driver.FindElement(By.XPath("//a[@href='/contact']"));

        public void ClickShopButton()
        {
            btnShop.Click();
        }

        public bool IsContactLinkVisible()
        {
            return linkContact.Displayed;
        }
    }
}
