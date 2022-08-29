using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ProjektTESTY.BaseClass;
using System.Threading;

namespace ProjektTESTY
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("TutorialTest")]
        public void SetLoginEmail()
        {
            IWebElement emailField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailField.SendKeys("Mateusz");
            Thread.Sleep(5000);
        }
        [Test, Category("TutorialTest")]
        public void SetMonthValue()
        {
            IWebElement cookiesButton = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            cookiesButton.Click();
            Thread.Sleep(1000);

            IWebElement registerButton = driver.FindElement(By.XPath(".//*[@data-testid='open-registration-form-button']"));
            registerButton.Click();
            Thread.Sleep(1000);

            //Linijki 22-30 nie były uwzględnione w kursie, lecz od czasu publikacji kursu zmieniła się budowa strony logowania przez co musiałem przejść przez dwa dodatkowe przyciski do dostać się do "Rejestracji"
            // Bez linijek             Thread.Sleep(1000);        z ajkiegoś powodu nie działa test ( nie przechodzi - świeci się na czerwono).

            IWebElement monthValue = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthValue);
            element.SelectByIndex(10);
            //element.SelectByText("lis"); //działa tylko dla polskiej wersji językowej !
            //element.SelectByValue("11");
            Thread.Sleep(5000);
        }
    }
}
