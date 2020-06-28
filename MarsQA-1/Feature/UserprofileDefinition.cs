using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UserprofileDefinition

    {
        Profile profile;
    

        [Given(@"I have logged in to the Mars Portal successfully")]
        public void GivenIHaveLoggedInToTheMarsPortalSuccessfully()
        {
           


            //call the SignIn class
            SignIn signin= new SignIn();
            signin.SigninStep();
            profile= new Profile();

            Console.WriteLine("******************************");
            Console.WriteLine("I login into the portal");
        }
        [When(@"I have entered multiple languages, skills,eductaion and certification")]
        public void WhenIHaveEnteredMultipleLanguagesSkillsEductaionAndCertification()
        {
        //call profile class 
      
          profile.AddOperation();
        
        Console.WriteLine("I have entered langugage,skills,education and certification");
        }
        [Then(@"I should able to validate new record")]
        public void ThenIShouldAbleToValidateNewRecord()
        {
            Console.WriteLine("************************");
            profile.ValidateAdd();
        }
        public void WhenIEditMyProfileDatils()
        {
            profile.UpdateLanguageButton();
            profile.UpdateSkillsButton();
            profile.UpdateEducationButton();
            profile.UpdateCertificationButton();
            Console.WriteLine("I edit my profile details");
        }
        [Then(@"I should be able to validate updated record successfully")]
        public void ThenIShouldBeAbleToValidateUpdatedRecordSuccessfully()
        {
            profile.ValidateUpdation();
        }
        [When(@"I click on delete button")]
        public void WhenIClickOnDeleteButton()
        {

            profile.deletebutton();
        }
        [Then(@"I should be able to delete successfully")]
        public void ThenIShouldBeAbleToDeleteSuccessfully()
        {
            Assert.IsTrue(profile.IsRecordExist("first"));
            Assert.IsTrue(profile.IsRecordExist("second"));
            Assert.IsTrue(profile.IsRecordExist("third"));
            Assert.IsTrue(profile.IsRecordExist("fourth"));

            Console.WriteLine("I deleted the record successfully");
        }


        [Then(@"I should able to see  updated profile details")]
        public void ThenIShouldAbleToSeeUpdatedProfileDetails()
        {

            Console.WriteLine("I should be able to see updated profile");
        }


        [When(@"I click on Addnew Language button")]
        public void WhenIClickOnAddnewLanguageButton()
        {
            //Profile.clickLanguage();
            Console.WriteLine("I click on button");
        }

        [When(@"I enter null value in language field")]
        public void WhenIEnterNullValueInLanguageField()
        {
            //Profile.enternullvalue();
            Console.WriteLine("I enter null value");
        }

        [Then(@"I should be able to get an error message Please Enter language and level")]
        public void ThenIShouldBeAbleToGetAnErrorMessagePleaseEnterLanguageAndLevel()
        {
            Console.WriteLine("error message");
        }
      
      
        [When(@"I enter invalid values in language and skill")]
        public void WhenIEnterInvalidValuesInLanguageAndSkill()
        {
            //Profile.invalidinput();
            Console.WriteLine("I enter invalid values");
        }

        [Then(@"I should be able to get an error message Undefined")]
        public void ThenIShouldBeAbleToGetAnErrorMessageUndefined()
        {
            Console.WriteLine("get an error message undefined");
        }
        [When(@"I edit my profile datils")]
       

        [Then(@"I should be able to update successfully")]
        public void ThenIShouldBeAbleToUpdateSuccessfully()
        {
            Console.WriteLine("updated successfully ");
        }
        [Given(@"I go to the profile page")]
        public void GivenIGoToTheProfilePage()
        {
            Console.WriteLine("click on profile page");
        }

        [Given(@"I should see the login pop up")]
        public void GivenIShouldSeeTheLoginPopUp()
        {
            Console.WriteLine("able to see login pop up ");
        }

        [Given(@"I can login to the portal")]
        public void GivenICanLoginToThePortal()
        {
            Console.WriteLine("login into the portal");
        }

        [Then(@"I can accsess the profile")]
        public void ThenICanAccsessTheProfile()
        {
            Console.WriteLine("access the protal successfully");
        }

        [When(@"I click on upload profile image")]
        public void WhenIClickOnUploadProfileImage()
        {
            Console.WriteLine("uploaded image");
        }

        [Then(@"I should be able to upload successfully")]
        public void ThenIShouldBeAbleToUploadSuccessfully()
        {

        }

        [Given(@"Given I have logged in to the Mars Portal successfully")]
        public void GivenGivenIHaveLoggedInToTheMarsPortalSuccessfully()
        {

        }
        [When(@"I click on profile image")]
        public void WhenIClickOnProfileImage()
        {

        }

        [Then(@"I should be able to update the image successfully")]
        public void ThenIShouldBeAbleToUpdateTheImageSuccessfully()
        {

        }

        [When(@"I edit name and password")]
        public void WhenIEditNameAndPassword()
        {
           // Profile.addProfile();
        }

        [Then(@"I should be able to see edited profile name")]
        public void ThenIShouldBeAbleToSeeEditedProfileName()
        {
            Console.WriteLine("I should able to update profile name ");
        }


        [When(@"I enter invalid values in language and skill , education and certification")]
        public void WhenIEnterInvalidValuesInLanguageAndSkillEducationAndCertification()
        {
           
        }

        [When(@"I enter nullvalues in lanuguage, skill, education and certification")]
        public void WhenIEnterNullvaluesInLanuguageSkillEducationAndCertification()
        {

        }

        [Then(@"I should get an error message")]
        public void ThenIShouldGetAnErrorMessage()
        {

        }
        [When(@"I add availability , hours and earn target")]
        public void WhenIAddAvailabilityHoursAndEarnTarget()
        {

            //Profile.AddAvalability("part time");
            //Profile.AddHours("More than 30hours a week");
            //Profile.AddEarnTarget("Between $500 And $1000 per month");
        }

        [Then(@"I should be able to see successfully")]
        public void ThenIShouldBeAbleToSeeSuccessfully()
        {
            
        }

      

        [Then(@"i should able to see added profile successfully")]
        public void ThenIShouldAbleToSeeAddedProfileSuccessfully()
        {
            Console.WriteLine("added successfully");

        }
        [When(@"I enter value in certification name and click on add button")]
        public void WhenIEnterValueInCertificationNameAndClickOnAddButton()
        {
            Console.WriteLine("I enter certification name");
            //Profile.addCertificationname();

        }
        [Then(@"I should get an error message please enter all information")]
        public void ThenIShouldGetAnErrorMessagePleaseEnterAllInformation()
        {
            Console.WriteLine("Error message");

        }
        [When(@"I add values in languagge, skill, education and certification")]
        public void WhenIAddValuesInLanguaggeSkillEducationAndCertification()
        {
            //Profile.AddValidInputs();
            //Profile.AddValidInputs();
            Console.WriteLine("values are already been added ");
        }

        [Then(@"I should be able to get an error message Values already exist")]
        public void ThenIShouldBeAbleToGetAnErrorMessageValuesAlreadyExist()
        {
            Console.WriteLine("");
        }

        [When(@"I add description")]
        public void WhenIAddDescription()
        {
            // profile.addDescription();
        }

        [Then(@"I should able to see description successfully")]
        public void ThenIShouldAbleToSeeDescriptionSuccessfully()
        {
            Console.WriteLine("description addd successfully");
        }

        [Then(@"Ishould able to see successfully")]
        public void ThenIshouldAbleToSeeSuccessfully()
        {

        }



    }
}
