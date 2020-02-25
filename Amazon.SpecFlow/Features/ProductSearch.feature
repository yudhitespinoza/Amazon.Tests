Feature: Product search
	In order to search products
	As an online user
	I want to perform a search

Scenario: Search specific product which is found
	Given I have opened the amazon page
	And I set the language to English
	When I type the 'Just Dance 2019 (Nintendo Switch)' search text	
	And I press the search button	
	Then The products that matched search text is displayed

Scenario: Search specific product which is not found 
	Given I have opened the amazon page
	And I set the language to English
	When I type the 'abcdefghijklmnopqrstuvwxyzabc' search text	
	And I press the search button	
	Then The product is not found