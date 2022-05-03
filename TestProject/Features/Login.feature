@Login
Feature: Check Login
As a user I want to check login functionality 

Scenario Outline: Login into Hudl 
	Given I navigate to site 
	When I click login 
	Then Login Page is displayed 
	And I enter <username> and <password>
	Then Verify login <username>
	Examples: 
	| username               | password |
	| sharma.neha9@gmail.com | P@$$w0rD |

Scenario Outline: Login with wrong username and passowrd 
	Given I navigate to site 
	When I click login 
	Then Login Page is displayed 
	And I enter <username> and <password>
	Then Verify user not able to login 
	Examples: 
	| username | password |
	| abc      | abc      |
	| abc      |          |
	|          | abc      |

Scenario: Verify need help on login page 
	Given I navigate to site 
	When I click login 
	Then Login Page is displayed 
	When I click needHelp link
	Then I will be able to verify Need help link

Scenario: Verify Login with orgnization 
	Given I navigate to site 
	When I click login 
	Then Login Page is displayed 
	When I click login with orgnization
	Then it show heading login with orgnization

Scenario: Verify Login with orgnization Page
	Given I navigate to site 
	When I click login 
	Then Login Page is displayed 
	When I click login with orgnization
	Then it show heading login with orgnization
	When I enter my email sharma.neha9@gmail.com
	And click submit 
	Then it will redirect to login with email page with error message

Scenario: Verify SignUp on login page 
	Given I navigate to site 
	When I click login 
	Then Login Page is displayed 
	When I click sign up link
	Then I am redirected to sign up page