using CustomDriver.Driver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pages.Google;

namespace GoogleTests
{
    [TestClass]
    public class GoogleTests
    {
        private ICustomWebDriver driver;

        public GoogleTests()
        {
        }

        [TestInitialize]
        public void InitTests()
        {
            driver = new CustomWebDriver();
        }

        [TestCleanup]
        public void EndTests()
        {
            driver.Dispose();
        }

        [TestMethod]
        public void AcessarConteudoRestrito()
        {
            var microsoftPage =
                new HomePage(this.driver)
                .GoTo()
                .InputOnSearch("Microsoft")
                .ClickOnSearch()
                .ClickOnMicrosoftLink();

            Assert.IsTrue(microsoftPage.VerifyOficial());
        }
    }
}
