using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektTESTY
{
    [TestFixture]

    public class OrderSkipAttribute
    {
        [Test,Order(1), Category("TutorialTest")]
        public void TestChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailField.SendKeys("Mateusz");
            Thread.Sleep(5000);
            driver.Close();
        }
        [Test, Order(0),Category("TutorialTest")]
        public void TestFirefox()
        {
            Assert.Ignore("Lack of Browser"); //Ignorowanie Testu

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailField.SendKeys("Mateusz");
            Thread.Sleep(5000);
            driver.Close();
        }
        [Test, Order(2), Category("TutorialTest")]
        public void TestIE()
        {
            Assert.Ignore(); //Ignorowanie Testu

            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailField.SendKeys("Mateusz");
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
