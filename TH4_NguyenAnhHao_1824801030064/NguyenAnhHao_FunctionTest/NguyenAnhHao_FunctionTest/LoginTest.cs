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
    [TestFixture]
    public class LoginTestTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void tCLogin01()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(962, 810);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("1824801030064@student.tdmu.edu.vn");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys("123456");
            driver.FindElement(By.CssSelector("#SubmitLogin > span")).Click();
            Assert.That(driver.Title, Is.EqualTo("My account - My Store"));
            Assert.That(driver.FindElement(By.CssSelector(".account > span")).Text, Is.EqualTo("Nguyễn Anh hào"));
            driver.FindElement(By.LinkText("Sign out")).Click();
            driver.Close();
        }
        [Test]
        public void tCLogin02()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(961, 808);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("abcxyyz11@gmail.com");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys("12345");
            driver.FindElement(By.CssSelector("#SubmitLogin > span")).Click();
            Assert.That(driver.Title, Is.EqualTo("My account - My Store"));
            Assert.That(driver.FindElement(By.CssSelector(".account > span")).Text, Is.EqualTo("aaaa aaaaa"));
            driver.FindElement(By.LinkText("Sign out")).Click();
            driver.Close();
        }
        [Test]
        public void tCLogin03()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(961, 808);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys("12345");
            driver.FindElement(By.CssSelector("#SubmitLogin > span")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).Text, Is.EqualTo("An email address required."));
            driver.Close();
        }
        [Test]
        public void tCLogin04()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(961, 808);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("abcd");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys("12345");
            driver.FindElement(By.CssSelector("#SubmitLogin > span")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).Text, Is.EqualTo("Invalid email address."));
            driver.Close();
        }
        [Test]
        public void tCLogin05()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(961, 808);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("hahahaha@gmail.com");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys("12345");
            driver.FindElement(By.CssSelector("#SubmitLogin > span")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).Text, Is.EqualTo("Authentication failed."));
            driver.Close();
        }
        [Test]
        public void tCLogin06()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(961, 808);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("1824801030064@student.tdmu.edu.vn");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.CssSelector("#SubmitLogin > span")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).Text, Is.EqualTo("Password is required."));
            driver.Close();
        }
        [Test]
        public void tCLogin07()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(961, 808);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("1824801030064@student.tdmu.edu.vn");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys("1111");
            driver.FindElement(By.CssSelector("#SubmitLogin > span")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).Text, Is.EqualTo("Invalid password."));
            driver.Close();
        }
        [Test]
        public void tCLogin08()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Size = new System.Drawing.Size(960, 808);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("1824801030064@student.tdmu.edu.vn");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys("12345");
            driver.FindElement(By.CssSelector("#SubmitLogin > span")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).Text, Is.EqualTo("Authentication failed."));
            driver.Close();
        }
    }
}
