Feature: SpecFlowFeature2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with mandatory details
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form
	| Name    | Age | Phone  | Email            |
	| Karthik | 28  | 925631 | Karthik@exec.com |
	| John | 26  | 12346 | John@exec.com |
	| Sam | 32  | 62541 | Sam@exec.com |
	#And I click the save button
	#Then I should see all the details saved in my application and DB

Scenario Outline: Create a new employee with mandatory details for different operations
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form <Name>, <Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples: 
	| Name    | Age | Phone  |
	| Karthik | 28  | 925631 |
	| John | 26  | 12346 |
	| Sam | 32  | 62541 |