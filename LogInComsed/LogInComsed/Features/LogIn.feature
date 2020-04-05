Feature: LogIn
	In order to access my profile
	As a registered user
	I want to be able to Log In to Comsed site only with valid credentials

@positive
Scenario: Successful LogIn with valid credentials
	Given I load Comsed website
	And Click on the enter/registration button
	When I enter email address "testcases@abv.bg"
	And I enter password "Testing123"
	And I click on the Enter button
	Then The Profile page should be loaded

@negative
Scenario: LogIn message error is displayed when I enter wrong username or password
	Given I load Comsed website
	And Click on the enter/registration button
	When I enter email address "<email>"
	And I enter password "<password>"
	And I click on the Enter button
	Then An error message should be displayed
	Examples: 
	| email              | password   |
	| testcases@abv.bg   | Testing    |
	| testcases@abv.com  | Testing123 |