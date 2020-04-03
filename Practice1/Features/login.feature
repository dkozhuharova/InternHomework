Feature: login
	As a registered user,
	I want to log in successfully

@positive
Scenario: Log In to Web Scraper website
	Given I navigate to Web Scraper home page
	When I enter "admin" in the username field
	And I enter "12345" in the password field
	And I click on Log in button
	Then I should see Welcome message
