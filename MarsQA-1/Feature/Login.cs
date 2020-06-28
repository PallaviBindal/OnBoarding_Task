using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public sealed class Login
    {

        [Given(@"I navigate to url")]
        public void GivenINavigateToUrl()
        {
            
            Console.WriteLine("I navigate to url");
        }

        [When(@"I enter username and password and click button")]
        public void WhenIEnterUsernameAndPasswordAndClickButton()
        {
            //SignIn.SigninStep();
            Console.WriteLine("I logged into the portal");
        }

        [Then(@"I should be able to see home page")]
        public void ThenIShouldBeAbleToSeeHomePage()
        {
            //assertion to check the title of the page 
           
            string s1 = Driver.driver.Title;
            Console.WriteLine(s1);
            
            Assert.That(s1,Is.EqualTo("Home"));
            Console.WriteLine("Assertion Pass");
            Console.WriteLine("home page opened successfully");
        }

    }
}
