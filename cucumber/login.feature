Feature: Main
	Login to zonar systems

	Scenario: Enter login informaiton and submit
		Given I have opened "http://qa1.zonarsystems.net"
		Then I input the credentials
		When I hit submit
		Then I should see a link to "https://qa1.zonarsystems.net/gtc/report.php?action=adminusers&operation=edit&target=53" with text "Welcome, paras (dev0002)"

		

	Scenario: Log out
		Given I am logged in to "https://qa1.zonarsystems.net/dashboard/reports" as "paras (dev0002)"
		When I click the link to "https://qa1.zonarsystems.net/user/logout/" with text "Logout"
		Then I should see a div with Id "loginTitle"