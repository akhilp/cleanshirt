Feature: Testing logout

	Scenario: Log out
		Given I am logged in to "https://qa1.zonarsystems.net/mobile/"
		When I see the word "Dashboard"(.*?)"$/"
		Then I should logout "http://qa1.zonarsystems.net/user/logout"