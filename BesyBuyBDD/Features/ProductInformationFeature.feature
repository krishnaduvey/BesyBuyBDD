﻿Feature: ProductInformationFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@scenarioOne
Scenario: Check all the products information
	Given I have connected with the BestBuy API client 'http://localhost:3030'
	When User has access to Product '/Product'
	Then Status is 'OK'
	And Product information fetched


@scenarioTwo
Scenario: Check Product information
	Given I have connected with the BestBuy API client 'http://localhost:3030'
	And I have 'ProductId'
	When User has access to Product '/Product/{id}'
	Then Status is 'OK'
	And Product information fetched
