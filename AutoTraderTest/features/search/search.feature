Feature: Search for cars
	In order to search cars
	As a customer
	I want to be shown search categories

Scenario Outline: Search categories
	Given I am on the homepage
	When I choose More Options
	Then search <categories> are shown

	Examples: 
	| categories                                               |
	| MPV,Convertible,SUV,Estate,Coupe,Pickup,Hatchback,Saloon |
	