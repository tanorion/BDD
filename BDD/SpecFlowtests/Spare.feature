﻿Feature: Spare
	In order to get an accurate score
	As a game player	
	I want to be able to roll a spare and get the correct score

@mytag
Scenario: Roll spare
	Given A new bowling game
	And I roll a 5
	And I roll a 5
	And I roll a 5
	When I get my score
	Then The score should be 20
