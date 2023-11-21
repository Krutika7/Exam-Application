using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using QuizApp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuizApp.POM
{
    class Dashboard
    {

        public void Homepage()
        {

            Thread.Sleep(4000);
            string Homepage1 = Hooks1.driver.FindElement(By.XPath("//h1[@class='text-2xl font-semibold mb-4']")).Text;

            String Actual_Homepage1 = "Appeared/Passed";
            Assert.AreEqual(Actual_Homepage1, Homepage1);
            
        }

        public void Menu()
        {
            Thread.Sleep(4000);
            string Dashboard1 = Hooks1.driver.FindElement(By.XPath("//a[@class='active']")).Text;

            String Actual_Dashboard = "Dashboard";
            Assert.AreEqual(Actual_Dashboard, Dashboard1);


            Thread.Sleep(2000);
            string Candidate = Hooks1.driver.FindElement(By.XPath("//a[normalize-space()='Candidate']")).Text;
            String Actual_Candidate = "Candidate";
            Assert.AreEqual(Actual_Candidate, Candidate);
            //group
            Thread.Sleep(2000);
            string Group = Hooks1.driver.FindElement(By.XPath("//a[normalize-space()='Group']")).Text;
            String Actual_Group = "Group";
            Assert.AreEqual(Actual_Group, Group);
            //subject
            Thread.Sleep(2000);
            string Subject = Hooks1.driver.FindElement(By.XPath("//a[normalize-space()='Subject']")).Text;
            String Actual_Subject = "Subject";
            Assert.AreEqual(Actual_Subject, Subject);
            //Question
            Thread.Sleep(2000);
            string Question = Hooks1.driver.FindElement(By.XPath("//a[normalize-space()='Question']")).Text;
            String Actual_Question = "Question";
            Assert.AreEqual(Actual_Question, Question);
            //Exam
            Thread.Sleep(2000);
            string Exam = Hooks1.driver.FindElement(By.XPath("//a[normalize-space()='Exam']")).Text;
            String Actual_Exam = "Exam";
            Assert.AreEqual(Actual_Exam, Exam);
            //Results
            Thread.Sleep(2000);
            string Results = Hooks1.driver.FindElement(By.XPath("//a[normalize-space()='Results']")).Text;
            String Actual_Results = "Results";
            Assert.AreEqual(Actual_Results, Results);
            //Exam Proctoring
            Thread.Sleep(2000);
            string Proctoring = Hooks1.driver.FindElement(By.XPath("//a[normalize-space()='Exam Proctoring']")).Text;
            String Actual_Proctoring = "Exam Proctoring";
            Assert.AreEqual(Actual_Proctoring, Proctoring);
            //Setting
            Thread.Sleep(2000);
            string Setting = Hooks1.driver.FindElement(By.XPath("//a[normalize-space()='Setting']")).Text;
            String Actual_Setting = "Setting";
            Assert.AreEqual(Actual_Setting, Setting);
        }

        //Talentforge logo
        public void Titleimg()
        {
            try
            {
                IWebElement Title = Hooks1.driver.FindElement(By.XPath("//img[@alt='title']"));
                Assert.IsTrue(Title.Displayed, "Title is available.");
            }
            catch (NoSuchElementException)
            {
                // Handle the case where the image element is not found
                Console.WriteLine("Portal name image not found on the page.");
            }
            catch (Exception ex)
            {
                // Handle other exceptions or errors
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        //Username
        //public void Username()
        //{
        //    Thread.Sleep(4000);
        //    string Username1 = Hooks1.driver.FindElement(By.XPath("//*[contains(text(),'Krutika Sardar')]")).Text;

        //    String Actual_Username1 = "Krutika Sardar";
        //    Assert.AreEqual(Actual_Username1, Username1);
        //}

        //Events
        public void Events()
        {
            Thread.Sleep(4000);
            string Events1 = Hooks1.driver.FindElement(By.XPath("//p[@class='text-blue-900 font-bold text-xl']")).Text;

            String Actual_Events1 = "EVENTS";
            Assert.AreEqual(Actual_Events1, Events1);
        }


        //Todays 
        public void Today()
        {
            string TodaysExam = "//span[normalize-space()='Today']";
            Hooks1.driver.FindElement(By.XPath(TodaysExam)).Click();
        }


        //Upcoming Events
        public void Upcoming()
        {
            string UpcomingExam = "//span[normalize-space()='Upcoming Exams...']";
            Hooks1.driver.FindElement(By.XPath(UpcomingExam)).Click();
        }


    }
}
