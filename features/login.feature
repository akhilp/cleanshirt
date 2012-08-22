Feature: Login to zonar systems
	
	@bvt
	Scenario: Enter login informaiton and submit
		Given I have opened "http://qa1.zonarsystems.net/mobile/"
		Then I input the credentials
		When I hit submit
		Then I should see a link to "http://qa1.zonarsystems.net/mobile/dash" with text "Dashboard"
	
	@bvt
	Scenario: Log out
		Given I am logged in to "http://qa1.zonarsystems.net/mobile/"
		When I see the word "Dashboard"(.*?)"$/"
		Then I should logout "http://qa1.zonarsystems.net/user/logout"