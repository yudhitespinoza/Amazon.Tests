Feature: Lenguage change
	In order to change the language
	As an online user
	I want to change to my prefer language

Scenario: Change language to English
	Given I have opened the amazon page
	When I click the change language option	
	And I select the 'English - EN' language	
	And I click on save changes button
	Then The site uses the language code 'EN' selected

Scenario: Change language to Spanish
	Given I have opened the amazon page
	When I click the change language option	
	And I click on save changes button
	And I select the 'Español - ES' language	
	Then The site uses the language code 'ES' selected