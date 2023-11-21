using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using QuizApp.Hooks;
using QuizApp.POM;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace QuizApp.Step_definition
{
    [Binding]
    public class QuizappSteps
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks1.driver;
        Login loginobj = new Login();
        Dashboard Boardobj = new Dashboard();
        Candidate Candidateobj = new Candidate();
        Group Groupobj = new Group();
        Subject Subobj = new Subject();



        //[Given(@"Navigate to the website URL and click on Sign in with google button")]
        //public void GivenNavigateToTheWebsiteURLAndClickOnSignInWithGoogleButton()
        //{

        //    Thread.Sleep(4000);

        //    loginobj.Loginwithgoogle();

        //   //cenarioContext.Current.Pending();
        //}
        
        //[Given(@"Enter email (.*) and password (.*) and click on next button")]
        //public void GivenEnterEmailAndPasswordAndClickOnNextButton(string Username, string Password)
        //{
        //    Thread.Sleep(4000);
        //    loginobj.Fillcredentials(Username,Password);
          

        //}
        
        //[Then(@"Username should appear at top right\.")]
        //public void ThenUsernameShouldAppearAtTopRight_()
        //{
           
        //}


        [Given(@"Navigate to website's dashboard URL")]
        public void GivenNavigateToWebsiteSDashboardURL()
        {
           //
        }

        [Then(@"User should be in the dashboard page")]
        public void ThenUserShouldBeInTheDashboardPage()
        {
            Boardobj.Homepage();
        }

        [Then(@"the Dashboard menu should contain Dashboard,Candidate,Group,Subject,Question,Exam,Result,Exam Proctoring and Settings")]
        public void ThenTheDashboardMenuShouldContainDashboardCandidateGroupSubjectQuestionExamResultExamProctoringAndSettings()
        {
            Boardobj.Menu();
        }

        [Then(@"the header should display the portal name on the left")]
        public void ThenTheHeaderShouldDisplayThePortalNameOnTheLeft()
        {
            Boardobj.Titleimg();
        }

        //[Then(@"the header should display the user's name on the right")]
        //public void ThenTheHeaderShouldDisplayTheUserSNameOnTheRight()
        //{
        //    Boardobj.Username();
        //}

        [Then(@"there should be an event displayed in the bottom right corner")]
        public void ThenThereShouldBeAnEventDisplayedInTheBottomRightCorner()
        {
            Boardobj.Events();
        }

        [Then(@"When click on Today, today's exams should appear")]
        public void ThenWhenClickOnTodayTodaySExamsShouldAppear()
        {
            Boardobj.Today();
        }

        [Then(@"When click on Upcoming Exams, upcoming exams should appear")]
        public void ThenWhenClickOnUpcomingExamsUpcomingExamsShouldAppear()
        {
            Boardobj.Upcoming();
        }

//************************Candidate module verification code************
//*********************************************************************
        [Given(@"Navigate to the Dashbaord Url and click on Candidate from the left menu")]
        public void GivenNavigateToTheDashbaordUrlAndClickOnCandidateFromTheLeftMenu()
        {
            Candidateobj.Candidatemenu();
        }

        [Then(@"Add Candidate page should open")]
        public void ThenAddCandidatePageShouldOpen()
        {
            Candidateobj.Candidatepage();
        }

        [Then(@"Fill the Name(.*), Username(.*), Email(.*), Phone No(.*), Address(.*)")]
        public void ThenFillTheNameUsernameEmailPhoneNoAddress(string Name, string Username, string Email, string Phone, string Address)
        {
            Candidateobj.Candidatedetails(Name, Username, Email, Phone, Address);
        }

        [Then(@"Click on Add Candidate button")]
        public void ThenClickOnAddCandidateButton()
        {
            Candidateobj.AddcandidateClick();
        }

        [Then(@"Candidate should be added")]
        public void ThenCandidateShouldBeAdded()
        {

            js.ExecuteScript("window.scrollBy(0,3000)");
            Candidateobj.Candidateverify();
        }

        [Then(@"Add all the details and click on reset button")]
        public void ThenAddAllTheDetailsAndClickOnResetButton()
        {
            Candidateobj.Resetbutton();
        }

        [Then(@"Add Candidate field should be clear")]
        public void ThenAddCandidateFieldShouldBeClear()
        {
            //ScenarioContext.Current.Pending();
        }


        [Then(@"Click on View icon to view the candidate details")]
        public void ThenClickOnViewIconToViewTheCandidateDetails()
        {
            js.ExecuteScript("window.scrollBy(0,8000)");
            Candidateobj.ViewClick();
        }

        [Then(@"Click on edit to edit the candidate details")]
        public void ThenClickOnEditToEditTheCandidateDetails()
        {

            Candidateobj.EditClick();
        }

        [Then(@"Click on Delete to delete the candidate")]
        public void ThenClickOnDeleteToDeleteTheCandidate()
        {
            Candidateobj.DeleteClick();
        }
//**************************GROUP MODULE**************************
//********************************************************************


        [Given(@"Navigate to the Dashbaord Url and click on Group from the left menu")]
        public void GivenNavigateToTheDashbaordUrlAndClickOnGroupFromTheLeftMenu()
        {
            Groupobj.Groupmenu();
        }

        [Then(@"Add Group page should open")]
        public void ThenAddGroupPageShouldOpen()
        {
            Groupobj.Grouppage();

        }

        [Then(@"Add new group by filling the group name, Total number of candidates, click on candidate button and select candidates")]
        public void ThenAddNewGroupByFillingTheGroupNameTotalNumberOfCandidatesClickOnCandidateButtonAndSelectCandidates()
        {
            Groupobj.Groupadd();
        }

        [Then(@"Add all the details and click on reset button to verify the reset button")]
        public void ThenAddAllTheDetailsAndClickOnResetButtonToVerifyTheResetButton()
        {
            Groupobj.Resetbtn();
        }

        [Then(@"Group should be added")]
        public void ThenGroupShouldBeAdded()
        {
           // ScenarioContext.Current.Pending();
        }
        [Then(@"Click on edit to edit the Group details")]
        public void ThenClickOnEditToEditTheGroupDetails()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Click on Delete to delete the Group")]
        public void ThenClickOnDeleteToDeleteTheGroup()
        {
            //ScenarioContext.Current.Pending();
        }

        //************SUBJECT MODULE********************************
        //******************************************************************
        [Given(@"Navigate to the Dashbaord Url and click on Subject from the left menu")]
        public void GivenNavigateToTheDashbaordUrlAndClickOnSubjectFromTheLeftMenu()
        {
            Subobj.Subjectmenu();
           
        }

        [Then(@"Add Subject page should open")]
        public void ThenAddSubjectPageShouldOpen()
        {
            Subobj.Subjectpage();
           
        }

        [Then(@"Add new Subject by filling the Subject name and description")]
        public void ThenAddNewSubjectByFillingTheSubjectNameAndDescription()
        {
            Subobj.Subjects();
            Subobj.Addsubjectbtn();
        }

        [Then(@"Fill subject name and description and click on reset button to verify the reset button")]
        public void ThenFillSubjectNameAndDescriptionAndClickOnResetButtonToVerifyTheResetButton()
        {
            Subobj.Resetbtn();

            js.ExecuteScript("window.scrollBy(0,5000)");
        }

        [Then(@"Subject should be added")]
        public void ThenSubjectShouldBeAdded()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"Click on edit to edit the Subject name  and description")]
        public void ThenClickOnEditToEditTheSubjectNameAndDescription()
        {
            Subobj.Subjectedit();
        }

        [Then(@"Click on Delete to delete the Subject")]
        public void ThenClickOnDeleteToDeleteTheSubject()
        {
            Subobj.Subjectdelete();
        }




    }


}
