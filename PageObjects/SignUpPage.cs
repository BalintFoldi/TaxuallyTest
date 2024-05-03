using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaxuallyTest.PageObjects
{
    public class SignUpPage
    {
        
        //login page locator
        IWebElement UserName => driver.FindElement(By.CssSelector("span[class='username']"));

        //locators
        IWebElement CountryDropDown => driver.FindElement(By.CssSelector("ng-select[data-unique-id='payment-service-subscriptions_select-country-establishment'] input"));
        IWebElement RegNewBusiness => driver.FindElement(By.CssSelector("a[title='Register business']"));
        IWebElement ClickToScrollMenu => driver.FindElement(By.CssSelector("div.scrollable-content>div"));
        IWebElement CountryButton => driver.FindElement(By.CssSelector("div[class='col-lg-3 col-md-4 col-6 d-flex justify-content-center']"));
        IWebElement NextStepButton => driver.FindElement(By.CssSelector("button[data-unique-id='payment-service-subscriptions_button-next-step']"));
        IWebElement LegalStatusDropDown => driver.FindElement(By.Id("companyLegalStatus"));


        /*div[class='col-lg-3 col-md-4 col-6 d-flex justify-content-center ng-star-inserted']:nth-of-type(1)*/

        IWebDriver driver;

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //methods
        public string GetUserName()
        {
            return UserName.Text;
        }

        public SignUpPage SelectBusinessLocation(string text)
        {
            CountryDropDown.SendKeys(text);    
            
            return this;
        }

        public SignUpPage RegisterNewBusiness()
        {
            UserName.Click();
            RegNewBusiness.Click();
            return this;
        }

        public SignUpPage SelectFirstLocationFromDropDown()
        {
            ClickToScrollMenu.Click();

            return this; 
        }

        public SignUpPage SelectCountry(int number)
        {  
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("button[data-unique-id='payment-service-subscriptions_button-country-option']"));
            try
            {
                for (int i = 0; i < number; i++)
                {
                    elements[i].Click();
                }
                return this;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }     

        public SignUpPage GetVATNumber()
        {
            IList<IWebElement> vatButtons = driver.FindElements(By.CssSelector("button[data-unique-id='payment-service-subscriptions_add-vatreg-to-cart-button']"));
            for (int i = 0; i < vatButtons.Count; i++)
            {
                vatButtons[i].Click();
            }

            return this;
        }

        public SignUpPage NextStep()
        {
            NextStepButton.Click();
            return this;
        }

        public SignUpPage FillUpBusinessDetials(string text)
        {
            LegalStatusDropDown.SendKeys(text);

            return this;
        }
            
    }
}
