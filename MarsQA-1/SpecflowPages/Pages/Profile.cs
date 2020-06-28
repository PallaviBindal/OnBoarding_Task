using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using MarsQA_1.Pages;
using NUnit.Framework;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Profile
    {
        public Profile()

        {

            ExcelLibHelper.PopulateInCollection(@"C:\repo\onboarding.specflow\MarsQA-1\SpecflowTests\Data\Data.xlsx", "FieldValues");

        }
        //click on langauge
        private IWebElement LanguageButton => Driver.driver.FindElement(By.XPath("//a[text()='Languages']"));
        //click on skill
        private IWebElement SkillsButton => Driver.driver.FindElement(By.XPath("//a[text()='Skills']"));
        //click on education
        private IWebElement EducationButton => Driver.driver.FindElement(By.XPath("//a[text()='Education']"));
        //click on  Certifications
        private IWebElement Certificationbutton => Driver.driver.FindElement(By.XPath("//a[text()='Certifications']"));

        //Search for the button for each field(language,skill,education,certification) and click on Add button
        public void AddButton(String element)
        {
            if (element.Equals("LanguageButton"))
            {
                Driver.driver.FindElement(By.XPath("//div[2]//div//div//div[3]//input[@type='button'][@value='Add']")).Click();
            }
            else if (element.Equals("SkillsButton"))
            {
                Driver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@type='button'][@value='Add']")).Click();
            }
            else if (element.Equals("EducationButton"))
            {
                Driver.driver.FindElement(By.XPath("//div[2]//div//div[3]//div//input[@type='button'][@value='Add']")).Click();
            }
            else if (element.Equals("Certificationbutton"))
            {
                Driver.driver.FindElement(By.XPath("//div[@class='ui fluid container']//div//div//div[3]//form//div[5]//div//div[2]/div//div[1]//div[3]//input[@type='button'][@value='Add']")).Click();
            }
        }
        //Search for the button for each field(language,skill,education,certification) and click on Add New Button
        public void AddNewButton(String element)
        {
            Driver.TurnOnWait();
            if (element.Equals("LanguageButton"))
            {

                //Driver.driver.FindElement(By.XPath("//div[contains(.,'Add New')][11])")).Click();
                Driver.driver.FindElement(By.XPath("//div[@class='eight wide column']/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead/tr/th[3]/div[1]")).Click();
            }
            else if (element.Equals("SkillsButton"))
            {
                Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();
                // Driver.driver.FindElement(By.XPath("//div[contains(.,'Add New')])[16]")).Click();
            }
            else if (element.Equals("EducationButton"))
            {
                Driver.driver.FindElement(By.XPath("//div[1]/div[2]/div[1]/table[1]/thead/tr/th[6]/div[1]")).Click();

            }
            else if (element.Equals("Certificationbutton"))
            {
                Driver.driver.FindElement(By.XPath("//div[1]/div[2]/div[1]/table[1]/thead/tr/th[4]/div[1]")).Click();
            }
        }
        //select dropdown for education and certification
        public void selectdropdown1(string dropdownname, string value)
        {
            new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@name,'" + dropdownname + "')]"))).SelectByValue(value);
        }
        //Perform add operation in all fields(language,skill,education,certification)
        public void AddOperation()
        {
            AddLanguage();
            AddSkills();
            AddEducation();
            AddCertification();

        }
        //Add Language (Performing clicking,inserting the value)
        public void AddLanguage()
        {
            Console.WriteLine("******************************");
            //firstly click on language button
            LanguageButton.Click();
            //implicit wait 
            Driver.TurnOnWait();
            Assert.That(Driver.driver.FindElement(By.XPath("//th[contains(.,'Language')]")).Text, Is.EqualTo("Language"));
            //click on add new button
            AddNewButton("LanguageButton");
            //enter text in language field

            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]")).SendKeys(ExcelLibHelper.ReadData(3, "Language"));
            //Driver.driver.FindElement(By.XPath("(//input[contains(@type,'text')])[4]")).SendKeys(ExcelLibHelper.ReadData(3, "Language"));
            //select level from drop down
            new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']"))).SelectByText("Conversational");
            //click on add button
            AddButton("LanguageButton");
            //get the pop up message after adding the language
            var addlanguageMessage = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]"));
            Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            Console.WriteLine(addlanguageMessage.Text);
            //String expectedAddMessage = "Hindi has been added to your languages";
            //Assert.AreEqual(addlanguageMessage, expectedAddMessage);
        }

        //Add Skills (Performing clicking,inserting the value)
        public void AddSkills()
        {
            Console.WriteLine("******************************");
            //click on skill
            SkillsButton.Click();
            Driver.TurnOnWait();

            Assert.That(Driver.driver.FindElement(By.XPath("//th[contains(.,'Skill')]")).Text, Is.EqualTo("Skill"));
            //click on add new button
            AddNewButton("SkillsButton");
            Driver.TurnOnWait();
            //add value in skill text 
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]")).SendKeys(ExcelLibHelper.ReadData(3, "Skills"));
            // Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']//parent::div[@class='five wide field']//preceding-sibling::div['five wide field']//input[@type='text'][@name='name']")).SendKeys("auntomation testing");
            new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"))).SelectByText("Expert"); ;
            //click on add button
            AddButton("SkillsButton");
            var actualskillMessage = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]"));
            Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            //String expectedskillMessage = "Performance has been added to your skills";
            //Assert.AreEqual(actualskillMessage, expectedskillMessage);
            Console.WriteLine(actualskillMessage.Text);
        }

        //Add Education (Performing clicking,inserting the value)
        public void AddEducation()
        {
            Console.WriteLine("******************************");
            Driver.TurnOnWait();
            EducationButton.Click();
            Driver.TurnOnWait();
            //Assert.That(Driver.driver.FindElement(By.XPath("//th[contains(.,'Country')]")).Text, Is.EqualTo("Country"));
            AddNewButton("EducationButton");
            //adding text in institute name
            Driver.driver.FindElement(By.XPath("//input[@type='text'][@name='instituteName']")).SendKeys(ExcelLibHelper.ReadData(3, "Education"));
            //Driver.driver.FindElement(By.XPath("(//input[contains(@type,'text')])[4]")).SendKeys(ExcelLibHelper.ReadData(3, "Language"))
            //select dropdown 
            selectdropdown1("country", "India");
            selectdropdown1("title", "B.Sc");
            selectdropdown1("yearOfGraduation", "2005");
            //enter degree 
            Driver.driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys(ExcelLibHelper.ReadData(4, "Degree"));
            Driver.TurnOnWait();
            AddButton("EducationButton");
            String addMessage = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            Console.WriteLine(addMessage);
            Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
        }
        //Add Certification (Performing clicking,inserting the value)
        public void AddCertification()
        {
            Console.WriteLine("******************************");
            Certificationbutton.Click();
            Driver.TurnOnWait();
            AddNewButton("Certificationbutton");
            //add value in certificate field andcertification from
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]")).SendKeys(ExcelLibHelper.ReadData(3, "Certificate"));
            Driver.driver.FindElement(By.XPath("//input[@name='certificationFrom']")).SendKeys(ExcelLibHelper.ReadData(4, "Certified from"));
            selectdropdown1("certificationYear", "2005");
            AddButton("Certificationbutton");
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Console.WriteLine(Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text);
            Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            Driver.TurnOnWait();
            Console.WriteLine("******************************");
        }
        public void ValidateAdd()
        {
            try
            {
                //language test
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                LanguageButton.Click();
                String Lang = Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//table//tbody//tr[1]//td[1])[1]")).Text;
                Assert.AreEqual(Lang, "Hindi");

                String level = Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//table//tbody//tr[1]//td[2])[1]")).Text;
                Assert.AreEqual(level, "Conversational");

                //skills test
                SkillsButton.Click();
                String skill = Driver.driver.FindElement(By.XPath("(//div[@data-tab='second']//table//tbody//tr[1]//td[1])[1]")).Text;
                Assert.AreEqual(skill, "Performance");

                String skilllevel = Driver.driver.FindElement(By.XPath("(//div[@data-tab='second']//table//tbody//tr[1]//td[2])[1]")).Text;
                Assert.AreEqual(skilllevel, "Expert");

                //education test 
                EducationButton.Click();
                String country = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[1])[1]")).Text;
                Assert.AreEqual(country, "India");
                String university = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[2])[1]")).Text;
                Assert.AreEqual(university, "MBA");
                String title = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[3])[1]")).Text;
                Assert.AreEqual(title, "B.Sc");
                String degree = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[4])[1]")).Text;
                Assert.AreEqual(degree, "MBBS");
                String graduationyear = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[5])[1]")).Text;
                Assert.AreEqual(graduationyear, "2005");

                //certification test
                Certificationbutton.Click();
                String Certificate = Driver.driver.FindElement(By.XPath("(//div[@data-tab='fourth']//table//tbody//tr[1]//td[1])[1]")).Text;
                Assert.AreEqual(Certificate, "Bachelor Degree");
                String certifiedfrom = Driver.driver.FindElement(By.XPath("(//div[@data-tab='fourth']//table//tbody//tr[1]//td[2])[1]")).Text;
                Assert.AreEqual(certifiedfrom, "IUK");
                String certifiedyear = Driver.driver.FindElement(By.XPath("(//div[@data-tab='fourth']//table//tbody//tr[1]//td[3])[1]")).Text;
                Assert.AreEqual(certifiedyear, "2005");
                Console.WriteLine("Test passed");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        //Search and Click on update for each field
        public void UpdateButton(String element)
        {
            if (element.Equals("LanguageButton"))
            {
                Driver.TurnOnWait();
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
            }
            else if (element.Equals("SkillsButton"))
            {
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
            }
            else if (element.Equals("EducationButton"))
            {
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")).Click();
            }
            else if (element.Equals("Certificationbutton"))
            {
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")).Click();
            }
        }
        //Update operation performs on language field
        public void UpdateLanguageButton()
        {
            LanguageButton.Click();
            Driver.TurnOnWait();
            //click the pen icon to edit 
            UpdateButton("LanguageButton");
            Driver.TurnOnWait();
            //ClearText("//input[@placeholder='Add Language']");
            //clear the text and enter the value 
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]")).Clear();
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]")).SendKeys(ExcelLibHelper.ReadData(4, "Language"));
            //select from drop down
            new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']"))).SelectByText("Conversational");
            //click on update button
            Driver.driver.FindElement(By.XPath("//input[contains(@type,'button')][1]")).Click();
            Console.WriteLine(Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text);
            Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            Console.WriteLine("*******************************");
        }
        //Update operation performs on skills field
        public void UpdateSkillsButton()
        {
            SkillsButton.Click();
            Driver.TurnOnWait();
            //click the pen icon to edit 
            UpdateButton("SkillsButton");
            Driver.TurnOnWait();
            //clear text and enter value 
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]")).Clear();
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]")).SendKeys(ExcelLibHelper.ReadData(4, "Skills"));
            new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"))).SelectByText("Expert");
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
            Console.WriteLine(Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text);
            Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            Console.WriteLine("******************************");
        }
        //Update operation performs on Education field
        public void UpdateEducationButton()
        {
            EducationButton.Click();
            Driver.TurnOnWait();
            //click the pen icon to edit 
            UpdateButton("EducationButton");
            Driver.TurnOnWait();
            // clear text and enter value
            Driver.driver.FindElement(By.XPath("//input[@type='text'][@name='instituteName']")).Clear();
            Driver.driver.FindElement(By.XPath("//input[@type='text'][@name='instituteName']")).SendKeys(ExcelLibHelper.ReadData(4, "Education"));
            // select drop down
            selectdropdown1("country", "India");
            selectdropdown1("title", "BFA");
            selectdropdown1("yearOfGraduation", "2003");
            // clear text and enter value
            Driver.driver.FindElement(By.XPath("//input[@name='degree']")).Clear();
            Driver.driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys(ExcelLibHelper.ReadData(4, "Degree"));
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();
            //click on update button
            Console.WriteLine(Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text);
            Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));

            Console.WriteLine("*******************************");
        }
        //update operation performs on Certification field
        public void UpdateCertificationButton()
        {
            Certificationbutton.Click();
            Driver.TurnOnWait();
            //click the pen icon to edit 
            UpdateButton("Certificationbutton");
            Driver.TurnOnWait();
            // clear text and enter value
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]")).Clear();
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]")).SendKeys(ExcelLibHelper.ReadData(4, "Certificate"));
            Driver.driver.FindElement(By.XPath("//input[@name='certificationFrom']")).Click();
            Driver.driver.FindElement(By.XPath("//input[@name='certificationFrom']")).SendKeys(ExcelLibHelper.ReadData(4, "Certified from"));
            selectdropdown1("certificationYear", "2005");
            //click on update button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
            Console.WriteLine(Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text);
            Driver.driver.FindElement(By.XPath("//a[contains(@class,'ns-close')]"));
            Console.WriteLine("*******************************");
        }
        public void ValidateUpdation()
        {
            //check language
            LanguageButton.Click();
            String Lang = Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual(Lang, "Italian");
            String level = Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//table//tbody//tr[1]//td[2])[1]")).Text;
            Assert.AreEqual(level, "Conversational");

            //check skill
            SkillsButton.Click();
            Driver.TurnOnWait();
            String skill = Driver.driver.FindElement(By.XPath("(//div[@data-tab='second']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual(skill, "Testing");

            String skilllevel = Driver.driver.FindElement(By.XPath("(//div[@data-tab='second']//table//tbody//tr[1]//td[2])[1]")).Text;
            Assert.AreEqual(skilllevel, "Expert");

            //check education
            EducationButton.Click();
            Driver.TurnOnWait();
            String country = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual(country, "India");
            String university = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[2])[1]")).Text;
            Assert.AreEqual(university, "MMA");
            String title = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[3])[1]")).Text;
            Assert.AreEqual(title, "BFA");
            String degree = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[4])[1]")).Text;
            Assert.AreEqual(degree, "MBBS");
            String graduationyear = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[5])[1]")).Text;
            Assert.AreEqual(graduationyear, "2003");

            //check certification
            Certificationbutton.Click();
            Driver.TurnOnWait();
            String Certificate = Driver.driver.FindElement(By.XPath("(//div[@data-tab='fourth']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual(Certificate, "Post Graduate Degree");
            String certifiedfrom = Driver.driver.FindElement(By.XPath("(//div[@data-tab='fourth']//table//tbody//tr[1]//td[2])[1]")).Text;
            Assert.AreEqual(certifiedfrom, "IUKIUK");
            String certifiedyear = Driver.driver.FindElement(By.XPath("(//div[@data-tab='fourth']//table//tbody//tr[1]//td[3])[1]")).Text;
            Assert.AreEqual(certifiedyear, "2005");
            Console.WriteLine("Test Passed");
        }


        //Search and click for delete button for each field 
        public void DeleteButton(String element)
        {
            if (element.Equals("LanguageButton"))
            {//click on pen to delete 
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();
            }
            else if (element.Equals("SkillsButton"))
            {//click on pen to delete 
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();
            }
            else if (element.Equals("EducationButton"))
            {   //click on pen to delete       
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i")).Click();
            }
            else if (element.Equals("Certificationbutton"))
            {  //click on pen to delete 
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")).Click();
            }
        }
        //perform delete operation on all fields
        public void deletebutton()
        {
            LanguageButton.Click();
            DeleteButton("LanguageButton");

            String LangMessage = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;
            Console.WriteLine("****************************************************************");
            Console.WriteLine(LangMessage);

            SkillsButton.Click();
            Driver.TurnOnWait();
            //delete skill
            DeleteButton("SkillsButton");
            Console.WriteLine("****************************************************************");
            //validate whether it has been deleted or not
            String SkillMessage = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;

            Console.WriteLine(SkillMessage);
            Console.WriteLine("****************************************************************");


            EducationButton.Click();
            Driver.TurnOnWait();

            DeleteButton("EducationButton");
            Console.WriteLine("****************************************************************");
            string EducationMessage = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;

            Console.WriteLine(EducationMessage);
            Console.WriteLine("****************************************************************");


            Driver.TurnOnWait();
            Certificationbutton.Click();
            Console.WriteLine("****************************************************************");
            DeleteButton("Certificationbutton");
            string CertifiacteMessage = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;

            Console.WriteLine(CertifiacteMessage);
            Console.WriteLine("****************************************************************");
        }

        public bool IsRecordExist(String tabname)
        {
            try
            {
                Driver.driver.FindElement(By.XPath("//*[@data-tabname='" + tabname + "']//table//tbody//tr[1]//td[1])[1])"));
                return false;



            }
            catch (NoSuchElementException)
            {
                return true;
            }

        }
        //Add Availabliity 
        public static void AddAvalability(string availType)
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//i[contains(@class,'right floated outline small write icon')][1]")).Click();
            if (availType.ToLower() == "part time")
            {
                new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui right labeled dropdown')]"))).SelectByValue("0");

                Console.WriteLine("added");
            }
            else if (availType.ToLower() == "full time")
            {
                new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui right labeled dropdown')]"))).SelectByValue("1");
                Console.WriteLine("added");
            }
        }
        //Add hours
        public static void AddHours(string hours)
        {
            Driver.TurnOnWait();
            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")).Click();
            if (hours.ToLower() == "Less than 30hours a week")
            {
                new SelectElement(Driver.driver.FindElement(By.XPath("(//select[contains(@name,'availabiltyHour')]"))).SelectByValue("0");

                Console.WriteLine("hours added");
            }
            else if (hours.ToLower() == "More than 30hours a week")
            {
                new SelectElement(Driver.driver.FindElement(By.XPath("(//select[contains(@name,'availabiltyHour')]"))).SelectByValue("1");
                Console.WriteLine("hours added");
            }
            else if (hours.ToLower() == "As needed")
            {
                new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyHour')]"))).SelectByValue("2");
                Console.WriteLine("hour added");
            }

        }
        //add Earn Target
        public static void AddEarnTarget(string addEarnTarget)
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")).Click();
            if (addEarnTarget.ToLower() == "Less than $500 per month")
            {
                new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyTarget')]"))).SelectByValue("0");

                Console.WriteLine("hours added");
            }
            else if (addEarnTarget.ToLower() == "Between $500 And $1000 per month")
            {
                new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyTarget')]"))).SelectByValue("1");
                Console.WriteLine("hours added");
            }
            else if (addEarnTarget.ToLower() == "More than 1000 per month")
            {
                new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@name,'availabiltyTarget')]"))).SelectByValue("2");
                Console.WriteLine("hour added");
            }

        }
        //add description
        public static void addDescription()
        {
            Driver.driver.FindElement(By.XPath("//i[contains(@class,'outline write icon')]")).Click();
            Driver.driver.FindElement(By.XPath("//h3//span//i[@class='outline write icon']")).SendKeys("I am currently intern at MVP studio");
            Driver.driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button'][text()='Save']")).Click();

        }
        //edit profile name
        public static void addProfile()
        {
            Driver.driver.FindElement(By.XPath("//i[contains(@class,'dropdown icon)][2]")).Click();
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//input[@name='firstName']")).SendKeys("pallavi");
            Driver.driver.FindElement(By.XPath("//input[@name='lastName']")).SendKeys("bindal");
            Driver.driver.FindElement(By.XPath("//div[@class='user - details']//button[@class='ui teal button'][text()='Save']")).Click();
        }
        //Add Certification without entering Certification details 
        public static void addCertificationname()
        {
            // Certificationbutton.Click();
            Driver.TurnOnWait();
            //AddNewButton("Certificationbutton");
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]")).SendKeys("testing analyst1");
            //AddButton("Certificationbutton");
            var v1 = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text; ;
            Console.WriteLine(v1);
            try
            {
                Assert.That(v1, Is.EqualTo("Please enter Certification Name, Certification From and Certification Year"));
                Assert.Pass();
                Console.WriteLine("test passed");

            }
            catch (Exception)
            {
                Assert.Fail();
                Console.WriteLine("test failed");
            }

        }
        //add skill without entering skill level
        public static void addSkill()
        {
            // SkillsButton.Click();
            Driver.TurnOnWait();
            //AddNewButton("SkillsButton");
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]")).SendKeys(ExcelLibHelper.ReadData(4, "Skills"));
            //AddButton("SkillsButton");
            var message = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text; ;
            Console.WriteLine(message);
            //try
            //{
            //    Assert.That(v1, Is.EqualTo(""));
            //    Assert.Pass();
            //    Console.WriteLine("test passed");

            //}
            //catch (Exception)
            //{
            //    Assert.Fail();
            //    Console.WriteLine("test failed");
            //}







        }
    }


}
























       