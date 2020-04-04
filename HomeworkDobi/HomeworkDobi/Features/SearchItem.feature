Feature: SearchItem
	In order to buy a toy 
	As a user
	I want to be able to search Star Wars Toys 

@positive
Scenario: Search Star Wars Toys into Comsed page
	Given Navigate to Comsed homepage
	When I enter "Star Wars" to the searching field	 
	And Click on the searching button
	Then All Star Wars items should be listed
