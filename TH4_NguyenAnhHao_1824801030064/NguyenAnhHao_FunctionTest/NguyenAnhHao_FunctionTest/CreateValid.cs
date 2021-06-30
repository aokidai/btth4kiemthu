using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
namespace NguyenAnhHao_FunctionTest
{
    class CreateValid
    {
        private IWebDriver driver;
        private string baseURL;

        [TestFixture]
        public class CreateTest
        {

        }

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://automationpractice.com";
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [TestCase("a12a12341231@gmail.com", "abcaa", "xyzhh", "111111", "mng", "Harway", "New York", "00084", "united states", "0122456789", "abcaa xyzhh")]
        public void TCCreate01(string email, string firstname, string lastname, string pass, string address, string city, string state, string postcode, string country, string phone, string expected)
        {
            driver.Navigate().GoToUrl(baseURL + "/index.php");
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email_create")).Click();
            driver.FindElement(By.Id("email_create")).SendKeys(email);
            driver.FindElement(By.Id("SubmitCreate")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("id_gender1")).Click();
            driver.FindElement(By.Id("customer_firstname")).Click();
            driver.FindElement(By.Id("customer_firstname")).SendKeys(firstname);
            driver.FindElement(By.Id("customer_lastname")).Click();
            driver.FindElement(By.Id("customer_lastname")).SendKeys(lastname);
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys(pass);
            driver.FindElement(By.Id("address1")).Click();
            driver.FindElement(By.Id("address1")).SendKeys(address);
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys(city);
            driver.FindElement(By.Id("id_state")).Click();
            driver.FindElement(By.Id("id_state")).SendKeys(state);
            driver.FindElement(By.Id("postcode")).Click();
            driver.FindElement(By.Id("postcode")).SendKeys(postcode);
            driver.FindElement(By.Id("id_country")).Click();
            driver.FindElement(By.Id("id_country")).SendKeys(country);
            driver.FindElement(By.Id("phone_mobile")).Click();
            driver.FindElement(By.Id("phone_mobile")).SendKeys(phone);
            driver.FindElement(By.Id("submitAccount")).Click();
            Assert.AreEqual(expected, driver.FindElement(By.ClassName("account")).Text);
        }
    }
}
