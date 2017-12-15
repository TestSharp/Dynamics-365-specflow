Feature: LoginTest
	In order to see that everything working well during the login process
	As a user
	I want to be able to log in

@login @smoke
Scenario Outline: Login with demo user
	Given I am using '<browser>'
	Given I am on the main login page
	When I write in 'peter.halassy@re-gister.com' as my email address
    And I click next button
    And I write 'P@ssword' as my password
    And I click sign in button
    Then I should arrive to the main logged in page

	Examples: 
	| browser |
	| Chrome  |
	| Edge    |
	| Firefox |
