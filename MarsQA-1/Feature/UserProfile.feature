Feature: UserProfile
@mytag 
Scenario: A seller add profile image
Given I have logged in to the Mars Portal successfully 
When I click on upload profile image 
Then I should be able to upload successfully
@mytag 
Scenario: A seller add description maximum of 600 characters
Given: I have logged in to the Mars Portal successfully 
When I add description
Then I should able to see description successfully
@mytag
Scenario: A seller edit profile name
Given Given I have logged in to the Mars Portal successfully 
When I edit name and password 
Then I should be able to see edited profile name 

@Automate1 
Scenario: A seller Add profile details with valid inputs  
Given I have logged in to the Mars Portal successfully 
When  I have entered multiple languages, skills,eductaion and certification
Then I should able to validate new record 


@Automate3
Scenario: A seller delete existing language, skill , education and certification
Given I have logged in to the Mars Portal successfully 
When I click on delete button 
Then I should be able to delete successfully 

@Automate2 
Scenario: A seller update profile details 
Given I have logged in to the Mars Portal successfully 
When I edit my profile datils 
Then I should be able to validate updated record successfully 


@mytag
Scenario: A seller add profile using null input 
Given I have logged in to the Mars Portal successfully 
When I click on Addnew Language button 
And I enter null value in language field 
Then I should be able to get an error message Please Enter language and level
@mytag
Scenario: A seller update profile detail  with null value 
Given I have logged in to the Mars Portal successfully 
When I enter nullvalues in lanuguage, skill, education and certification
Then I should get an error message 
@mytag
Scenario: A seller add Certification name without entering certification year and certification from
Given I have logged in to the Mars Portal successfully 
When I enter value in certification name and click on add button
Then I should get an error message please enter all information
@mytag
 Scenario: A seller add availability,hoursand earn target
 Given I have logged in to the Mars Portal successfully 
 When I add availability , hours and earn target 
 Then I should be able to see successfully
 @mytag
 Scenario: A seller add same values which are already been added
 Given I have logged in to the Mars Portal successfully 
 When I add values in languagge, skill, education and certification
 Then I should be able to get an error message Values already exist






