using CustomDriver.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Pages.Microsoft 
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
            driver.Navigate().GoToUrl("https://www.microsoft.com/");
            return this;
        }

        public bool VerifyOficial()
        {
            var item_Locator = By.TagName("li");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(item_Locator));
            var oficialValidator = driver.FindElements(item_Locator).Any(x => x.Text == "© Microsoft 2019");
            return oficialValidator;
        }

    }
}
