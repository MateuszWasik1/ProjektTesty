using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektTESTY.MyOwnTest
{
    [TestFixture]
    public class Tests : BaseMethods
    {
        [Test]
        public void UserRegistration()
        {
            Assert.Ignore("Test is working but I already created account based on this data using this test, so this test is only for illustrative reason.");
            IWebElement cookiesButton = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            cookiesButton.Click();
            Thread.Sleep(1000);

            IWebElement registerButton = driver.FindElement(By.XPath(".//*[@data-testid='open-registration-form-button']"));
            registerButton.Click();
            Thread.Sleep(1000);

            IWebElement firstName = driver.FindElement(By.XPath(".//*[@name='firstname']"));
            firstName.SendKeys("Mateusz");
            //Pole wyboru imienia

            IWebElement surName = driver.FindElement(By.XPath(".//*[@name='lastname']"));
            surName.SendKeys("Wąsik");
            //Pole wyboru nazwiska

            IWebElement email = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            email.SendKeys("testgrafik04@wp.pl");
            //Pole wyboru emailu
            Thread.Sleep(1000);

            IWebElement emailConfirmation = driver.FindElement(By.XPath(".//*[@name='reg_email_confirmation__']"));
            emailConfirmation.SendKeys("testgrafik04@wp.pl");
            //Pole potwierdzające email

            IWebElement password = driver.FindElement(By.XPath(".//*[@id='password_step_input']"));
            password.SendKeys("Password22@");
            //Pole wyboru hasła

            IWebElement dayValue = driver.FindElement(By.XPath(".//*[@id='day']"));
            SelectElement dayValueElement = new SelectElement(dayValue);
            dayValueElement.SelectByIndex(24);
            //Pole wyboru dnia

            IWebElement monthValue = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement monthValueElement = new SelectElement(monthValue);
            monthValueElement.SelectByIndex(10);
            //Pole wyboru miesiąca

            IWebElement yearValue = driver.FindElement(By.XPath(".//*[@id='year']"));
            SelectElement yearValueElement = new SelectElement(yearValue);
            yearValueElement.SelectByText("2000");
            //Pole wyboru roku

            IWebElement userSex = driver.FindElement(By.XPath(".//*[@name='sex']"));
            userSex.Click();
            //Pole płeć

            IWebElement submitButton = driver.FindElement(By.XPath(".//*[@name='websubmit']"));
            submitButton.Click();
            //Kliknięcie przycisku "Utwórz nowe konto"
            Thread.Sleep(20000);
        }
        [Test, Order(0)]
        public void Login()
        {
            IWebElement cookiesButton = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            cookiesButton.Click();
            Thread.Sleep(1000);
            //Usunięcie info o Cookies
            
            IWebElement emailField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailField.SendKeys("testgrafik04@wp.pl");
            //logowanie email

            IWebElement password = driver.FindElement(By.XPath(".//*[@id='pass']"));
            password.SendKeys("Password22@");
            //logowanie hasło

            IWebElement loginButton = driver.FindElement(By.XPath(".//*[@name='login']"));
            loginButton.Click();
            //Zalogowanie się
            Thread.Sleep(8000);
        }
        
        [Test, Order(1)]
        public void ViewProfile()
        {
            IWebElement searchProfile = driver.FindElement(By.XPath(".//*[@href='https://www.facebook.com/profile.php?id=100085269878946']"));
            searchProfile.Click();
            Thread.Sleep(5000);
            //Wyświetlenie profilu
        }
        [Test, Order(2)]
        public void SelectProfilTabs()
        {
            IWebElement info = driver.FindElement(By.LinkText("Informacje"));
            info.Click();
            Thread.Sleep(1000);

            IWebElement friends = driver.FindElement(By.XPath(".//*[@href='https://www.facebook.com/profile.php?id=100085269878946&sk=friends']"));
            friends.Click();
            Thread.Sleep(1000);

            IWebElement photos = driver.FindElement(By.XPath(".//*[@href='https://www.facebook.com/profile.php?id=100085269878946&sk=photos']"));
            photos.Click();
            Thread.Sleep(1000);

            IWebElement videos = driver.FindElement(By.XPath(".//*[@href='https://www.facebook.com/profile.php?id=100085269878946&sk=videos']"));
            videos.Click();
            Thread.Sleep(1000);

            IWebElement locations = driver.FindElement(By.XPath(".//*[@href='https://www.facebook.com/profile.php?id=100085269878946&sk=map']"));
            locations.Click();
            Thread.Sleep(1000);

            IWebElement posts = driver.FindElement(By.LinkText("Posty"));
            posts.Click();
            Thread.Sleep(1000);

        }
        [Test, Order(3)]
        public void AddBio()
        {
            IWebElement addBIOBtn = driver.FindElement(By.XPath(".//*[@aria-label='Dodaj biogram']"));
            addBIOBtn.Click();
            Thread.Sleep(1000);

            IWebElement addBIO = driver.FindElement(By.XPath(".//*[@aria-label='Wprowadź tekst biogramu']"));
            addBIO.SendKeys("Przykładowy tekst BIO");
            Thread.Sleep(1000);

            IWebElement saveBio = driver.FindElement(By.XPath(".//*[@aria-label='Zapisz']"));
            saveBio.Click();
            Thread.Sleep(5000);

            IWebElement cleanBIOBtn = driver.FindElement(By.XPath(".//*[@aria-label='Edytuj biogram']"));
            cleanBIOBtn.Click();
            Thread.Sleep(1000);

            IWebElement cleanBIO = driver.FindElement(By.XPath(".//*[@aria-label='Wprowadź tekst biogramu']"));
            cleanBIO.Clear();
            Thread.Sleep(1000);

            IWebElement saveCleanBio = driver.FindElement(By.XPath(".//*[@aria-label='Zapisz']"));
            saveCleanBio.Click();
            Thread.Sleep(1000);
        }
        [Test, Order(4)]
        public void LogOut()
        {
            IWebElement saveCleanBio = driver.FindElement(By.XPath(".//*[@aria-label='Twój profil']"));
            saveCleanBio.Click();
            Thread.Sleep(1000);

            IWebElement logOut = driver.FindElement(By.XPath(".//*[@data-nocookies='true']"));
            logOut.Click();
            Thread.Sleep(1000);
        }
    }
}
