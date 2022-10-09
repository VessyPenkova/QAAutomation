using OpenQA.Selenium;

namespace SeleniumWebDriverTests.Objects
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public virtual string PageUrl { get; }

        public IWebElement PageHeading =>
            driver.FindElement(By.CssSelector("body > header"));
        public IWebElement LinkHome =>
            driver.FindElement(By.CssSelector("body > aside > ul > li > a"));
        public IWebElement LinkContacts =>
            driver.FindElement(By.CssSelector("body > aside > ul > li:nth-child(2) > a"));
        public IWebElement LinkCreate =>
            driver.FindElement(By.CssSelector("body > aside > ul > li:nth-child(3) > a"));
        public IWebElement LinkSearch =>
            driver.FindElement(By.CssSelector("body > aside > ul > li:nth-child(4) > a"));

        public void Open()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsOpen()
        {
            return driver.Url == PageUrl;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetPageHeadingText()
        {
            return PageHeading.Text;
        }
    }
}
