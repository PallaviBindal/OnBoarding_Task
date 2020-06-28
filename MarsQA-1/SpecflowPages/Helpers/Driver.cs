using NUnit.Framework;
using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
            TurnOnWait();

            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }
       

            // generic method that allows driver to wait until element is clickable
            public static void waitClickableElement(IWebDriver driver, string locator, string locatorValue)
            {
                try
                {
                    if (locator == "Id")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
                    }
                    if (locator == "XPath")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                    }
                    if (locator == "CSSSelector")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
                    }
                }
                catch (Exception ex)
                {
                    Assert.Fail("Excetion at waitClickableElement", ex.Message);
                }

            }
    

    //Implicit Wait
    public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }
        public static void gettitle()
        {
          string s1=driver.Title;
            Console.WriteLine(s1);
        }
        //Close the browser
        public void Close()
        {
            driver.Quit();
        }

    }
}
