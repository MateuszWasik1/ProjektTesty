using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjektTESTY.BaseClass;
using System.Threading;

namespace ProjektTESTY
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            IWebElement emailField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailField.SendKeys("Mateusz");
            Thread.Sleep(5000);
        }
    }
}
