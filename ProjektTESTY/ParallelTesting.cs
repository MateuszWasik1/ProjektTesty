using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ProjektTESTY.BaseClass;
using ProjektTESTY.Utilities;
using System.Threading;

namespace ProjektTESTY
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;
        [Test, Category("TutorialTest"), Category("Module1")]
        public void TestMethod()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailField.SendKeys("Mateusz");
            Driver.Close();
        }
    }
}
