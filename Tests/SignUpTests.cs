using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxuallyTest.Common;
using TaxuallyTest.PageObjects;

namespace TaxuallyTest.Tests
{
    internal class SignUpTests : TestBase
    {

        [Test]
        public void SingUpSubscriptions()
        {
            //1.step and 2.step
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.Login();
            SignUpPage signUpPage = new SignUpPage(Driver);
            //signUpPage.RegisterNewBusiness();

            //3.step
            signUpPage.SelectBusinessLocation("hungary");
            signUpPage.SelectFirstLocationFromDropDown();

            //4.step
            //Please add 1 to 10 value for the SelectCountry()
            signUpPage.SelectCountry(3);

            //5.step
            signUpPage.GetVATNumber();

            //6.step
            signUpPage.NextStep();

            
        }
    }
}
