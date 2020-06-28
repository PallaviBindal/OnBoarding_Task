using MarsQA_1.Helpers;
using MongoDB.Driver.Core.Authentication;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class SignIn
    {
        public SignIn()
        { 
        ExcelLibHelper.PopulateInCollection(@"C:\repo\onboarding.specflow\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Credentials");
           username = ExcelLibHelper.ReadData(2, "username");
           password = ExcelLibHelper.ReadData(2, "password");
        }

        private string username;
        private string password;
        private  IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
          private IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
           private  IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
            private IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
            public void SigninStep()
            {
            //new SignIn();
            Driver.NavigateUrl();
            SignInBtn.Click();
            SignIn signin = new SignIn();
            Email.SendKeys(username);
            Password.SendKeys(password);
            //signin.password;


         // Email.SendKeys("pallavigupta@gmail.com");
           //Password.SendKeys("123456");
              //Email.SendKeys(username);
             //Password.SendKeys(password);
                LoginBtn.Click();
            }

        
        public void Login()
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("");

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }
    }
}