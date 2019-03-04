using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace CustomDriver.Driver
{
    public class CustomWebDriver : ChromeDriver, ICustomWebDriver
    {
        public IWait<IWebDriver> Wait { get; set; }

        public CustomWebDriver() : base()
        {
            this.Wait = new WebDriverWait(this, new TimeSpan(0, 0, 40));
            this.Manage().Window.Maximize();
        }

    }
}
