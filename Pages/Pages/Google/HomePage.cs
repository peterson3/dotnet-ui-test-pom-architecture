using CustomDriver.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages.Google
{
    public class HomePage : Page<HomePage>
    {
        private readonly ICustomWebDriver driver;

        public HomePage(ICustomWebDriver _driver)
        {
            this.driver = _driver;
        }

        public override HomePage GoTo()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            return this;
        }

        public HomePage InputOnSearch(string searchText)
        {
            var search_Locator = By.Name("q");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(search_Locator));
            driver.FindElement(search_Locator).SendKeys(searchText);
            return this;
        }

        public SearchResultPage ClickOnSearch()
        {
            var button_Locator = By.Name("btnK");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(button_Locator));
            driver.FindElement(button_Locator).Click();
            return new SearchResultPage(driver);
        }
    }
}
