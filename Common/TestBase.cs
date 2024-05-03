using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxuallyTest.PageObjects;

namespace TaxuallyTest.Common
{
    internal class TestBase
    {
        protected IWebDriver Driver { get; private set; }
        protected LoginPage LoginTo { get; private set; }
        protected SignUpPage SignUp { get; private set; }
 

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://app.taxually.com/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //share the instance with the PageObjects
            LoginTo = new LoginPage(Driver);
            SignUp = new SignUpPage(Driver);
        }

        [TearDown]

        public void TearDown() 
        {
            Driver.Quit();
        }
    }
}
