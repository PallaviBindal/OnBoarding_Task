Feature: Login
Check if login funtionality works 

@mytag
Scenario: Login user as valid crendentials 
Given I navigate to url 
When  I enter username and password and click button
Then  I should be able to see home page 