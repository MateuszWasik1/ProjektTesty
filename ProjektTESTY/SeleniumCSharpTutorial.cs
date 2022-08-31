using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektTESTY
{
    [TestFixture]
    public class SeleniumCSharpTutorial
    {
        [Test]
        [Author("Mateusz Wąsik 13349")]
        [Description("Add text to email field in Facebook login page.Test is created to FAIL, because in test is use try/catch block.")]
        [TestCaseSource("DataDriverTesting")]
        public void Test1(String urlNames)
        {
            IWebDriver driver = null;

            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = urlNames;

                IWebElement emailField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailField.SendKeys("Mateusz");
                Thread.Sleep(1000);

                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot tss = driver as ITakesScreenshot;
                Screenshot ss = tss.GetScreenshot();
                ss.SaveAsFile("C:\\Users\\McBezimienny\\source\\repos\\MateuszWasik1\\ProjektTesty\\ProjektTESTY\\Screenshots\\s1.jpg", ScreenshotImageFormat.Jpeg);
                //Postarać się jakoś zmienić ścieżkę bezwzględną na względną.
                Console.WriteLine(e.Message.ToString(), e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                    driver.Quit();
            }
        }
        static IList DataDriverTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            list.Add("https://www.youtube.com/");
            list.Add("https://www.gmail.com/");
            //Jeżeli chcemy by test przeszedł należy zakomentować linijki 56/57
            return list;
        }
    }
}
