using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestCases
{
    [TestFixture]
    public class AutomationPracticeFormTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
        }

        [Test]
        public void Test_FillNameField()
        {
            var nameField = driver.FindElement(By.XPath("//label[contains(text(),'Name')]/following::input[1]"));
            nameField.Clear();
            nameField.SendKeys("Sahana");
        }

        [Test]
        public void Test_FillEmailField()
        {
            var emailField = driver.FindElement(By.XPath("//label[contains(text(),'Email')]/following::input[1]"));
            emailField.Clear();
            emailField.SendKeys("test@example.com");
        }

        [Test]
        public void Test_SelectGender()
        {
            var gender = driver.FindElement(By.XPath("//label[contains(text(),'Gender')]/following::input[1]"));
            gender.Click();
        }
    }
}
