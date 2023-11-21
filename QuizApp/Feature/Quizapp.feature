Feature: Quizapp
	Online quiz website

#@Login 
#Scenario Outline: Login into the website
#	Given Navigate to the website URL and click on Sign in with google button
#	And Enter email <Username> and password <Password> and click on next button
#	Then Username should appear at top right.
#	@source:Credentials.xlsx:sheet1
#	Examples: 
#	     |Username|Password|

@Dashboard_verification
Scenario: Dashboard verification
	Given Navigate to website's dashboard URL 
	Then  User should be in the dashboard page
	And   the Dashboard menu should contain Dashboard,Candidate,Group,Subject,Question,Exam,Result,Exam Proctoring and Settings
	And   the header should display the portal name on the left
	#And   the header should display the user's name on the right
    And   there should be an event displayed in the bottom right corner
	And   When click on Today, today's exams should appear
	And   When click on Upcoming Exams, upcoming exams should appear

@Verifing Candidate Module
Scenario Outline:Verifying the Candidate Module
   Given Navigate to the Dashbaord Url and click on Candidate from the left menu
   Then  Add Candidate page should open
   And   Fill the Name<Name>, Username<Username>, Email<Email>, Phone No<Phone>, Address<Address> 
   And   Click on Add Candidate button
   Then  Candidate should be added
   And   Add all the details and click on reset button
   Then  Add Candidate field should be clear
   And   Click on View icon to view the candidate details
   And   Click on edit to edit the candidate details
   And   Click on Delete to delete the candidate 
   @Source:Credentials.xlsx:sheet2
   Examples: 
      |Name|Username|Email|Phone|Address|

@Verifing Group Module
Scenario:Verifying the Group Module
   Given Navigate to the Dashbaord Url and click on Group from the left menu
   Then  Add Group page should open
   And   Add new group by filling the group name, Total number of candidates, click on candidate button and select candidates
   And   Add all the details and click on reset button to verify the reset button
   Then  Group should be added
   And   Click on edit to edit the Group details
   And   Click on Delete to delete the Group 

@Verifying Subject Module
Scenario:Verifying the Subject Module
   Given Navigate to the Dashbaord Url and click on Subject from the left menu
   Then  Add Subject page should open
   And   Add new Subject by filling the Subject name and description
   And   Fill subject name and description and click on reset button to verify the reset button
   Then  Subject should be added
   And   Click on edit to edit the Subject name  and description 
   And   Click on Delete to delete the Subject
  

   