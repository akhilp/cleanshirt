Feature: Main
	Login to zonar systems

	Scenario: Enter login informaiton and submit
		Given I have opened "https://qa1.zonarsystems.net/mobile/"
		Then I input the credentials
		When I hit submit
		Then I should see a link to "https://qa1.zonarsystems.net/mobile/dash" with text "Dashboard"
		
	Scenario: Log out
		Given I am logged in to "https://qa1.zonarsystems.net/mobile/"
		When I see the word "Dashboard"(.*?)"$/"
		Then I should logout "http://qa1.zonarsystems.net/user/logout"