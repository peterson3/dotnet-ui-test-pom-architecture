using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CustomDriver.Driver
{
    public interface ICustomWebDriver : IWebDriver
    {
        IWait<IWebDriver> Wait { get; set; }
    }
}
