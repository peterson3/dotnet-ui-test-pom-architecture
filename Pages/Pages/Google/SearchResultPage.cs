using CustomDriver.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace Pages.Google
{
    public class SearchResultPage : Page<SearchResultPage>
    {
        private readonly ICustomWebDriver driver; 

        public SearchResultPage(ICustomWebDriver _driver)
        {
            this.driver = _driver;
        }

        public override SearchResultPage GoTo()
        {
            throw new WebDriverException("Cannot Go To Page Directly");
        }

        public Pages.Microsoft.HomePage ClickOnMicrosoftLink()
        {
            var link_Locator = By.PartialLinkText("Microsoft - Official Home Page");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(link_Locator));
            driver.FindElement(link_Locator).Click();
            return new Pages.Microsoft.HomePage(driver);
        }


    }
}
