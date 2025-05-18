using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace CSharpSeleniumDemo1
{
    [TestFixture]
    public class SampleTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            _driver = new ChromeDriver(options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void HomePageTitle_ShouldContain_Google()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
            Assert.That(_driver.Title, Does.Contain("Google"));
        }

        [TestCase("Selenium WebDriver")]
        [TestCase("OpenAI")]
        [TestCase("ChatGPT")]
        public void SearchQuery_ShouldAppearInTitle(string query)
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
            var searchBox = _driver.FindElement(By.Name("q"));
            searchBox.SendKeys(query);
            searchBox.SendKeys(Keys.Enter);
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Contains(query));
            Assert.That(_driver.Title, Does.Contain(query));
        }

        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Dispose(); // Explicitly dispose of the WebDriver
                _driver = null;    // Set to null to avoid potential reuse
            }
        }

    }
}