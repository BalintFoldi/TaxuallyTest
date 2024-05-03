using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxuallyTest.PageObjects
{
    public class LoginPage
    {
        //locators
        IWebElement email => driver.FindElement(By.Id("email"));
        IWebElement password => driver.FindElement(By.Id("password"));
        IWebElement button => driver.FindElement(By.Id("next"));

        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        { 
            this.driver = driver; 
        }


        //methods
        public void Login()
        {
            AddEmail("vizak-karikak.0q@icloud.com");
            AddPassword("Asde234!re5?");
            PressSignIn();
        }

        public LoginPage AddEmail(string text)
        {
            email.SendKeys(text);

            return this;
        }

        public LoginPage AddPassword(string text) 
        { 
            password.SendKeys(text);

            return this;
        }

        public SignUpPage PressSignIn()
        {
            button.Click();

            return new SignUpPage(driver);
        }

    }
}
