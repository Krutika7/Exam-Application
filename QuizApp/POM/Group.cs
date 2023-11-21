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
    class Group
    {
        public void Groupmenu()
        {
            string Group = "//a[normalize-space()='Group']";
            Hooks1.driver.FindElement(By.XPath(Group)).Click();
        }

        public void Grouppage()
        {
            Thread.Sleep(3000);
            string Page = Hooks1.driver.FindElement(By.XPath("//p[@class='pb-4 font-bold text-gray-600']")).Text;

            String Actual_Page = "ADD GROUP";
            Assert.AreEqual(Actual_Page, Page);
        }
        public void Groupadd()
        {

            string Gname = "//input[@id='groupname']";
            Hooks1.driver.FindElement(By.XPath(Gname)).SendKeys("2023-NC-NOV-G2");
            Thread.Sleep(5000);

            string Candidatesnum = "//input[@id='numbers']";
            Hooks1.driver.FindElement(By.XPath(Candidatesnum)).SendKeys("1");
            Thread.Sleep(5000);
       
            string Candidatebtn = "//button[normalize-space()='Candidates']";
            Hooks1.driver.FindElement(By.XPath(Candidatebtn)).Click();
            Thread.Sleep(5000);

            string Candidateselect = "//*[@id='root']/div[2]/div/div[2]/div/div[1]/form/div[4]/div/div[1]/table/tbody/tr/td[2]/input";
            Hooks1.driver.FindElement(By.XPath(Candidateselect)).Click();
            Thread.Sleep(5000);

            string Save = "//button[normalize-space()='Save']";
            Hooks1.driver.FindElement(By.XPath(Save)).Click();
            Thread.Sleep(5000);
      
            string Groupadd = "//button[normalize-space()='Add Group']";
            Hooks1.driver.FindElement(By.XPath(Groupadd)).Click();
            Thread.Sleep(5000);

        }
        public void Resetbtn()
        {
            string Gname = "//input[@id='groupname']";
            Hooks1.driver.FindElement(By.XPath(Gname)).SendKeys("2023-NC-NOV-G3");
            Thread.Sleep(5000);

            string Candidatesnumber = "//input[@id='numbers']";
            Hooks1.driver.FindElement(By.XPath(Candidatesnumber)).SendKeys("1");
            Thread.Sleep(5000);

            string Candidate = "//button[normalize-space()='Candidates']";
            Hooks1.driver.FindElement(By.XPath(Candidate)).Click();
            Thread.Sleep(5000);

            string Candidateselects = "//*[@id='root']/div[2]/div/div[2]/div/div[1]/form/div[4]/div/div[1]/table/tbody/tr/td[2]/input";
            Hooks1.driver.FindElement(By.XPath(Candidateselects)).Click();
            Thread.Sleep(5000);

            string Save = "//button[normalize-space()='Save']";
            Hooks1.driver.FindElement(By.XPath(Save)).Click();
            Thread.Sleep(5000);

            string Reset = "//button[@type='reset']";
            Hooks1.driver.FindElement(By.XPath(Reset)).Click();
            }
        //public void Groupverification()
        //{
        //     List<string> GetGroupNames(IWebDriver driver)
        //    {
        //        string Showbtn = "//select[@class='border border-gray-300 rounded-md py-2 px-3 ml-2 text-gray-700 bg-white focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent shadow-md']";
        //        Hooks1.driver.FindElement(By.XPath(Showbtn)).Click();
        //        Thread.Sleep(5000);
        //        Hooks1.driver.FindElement(By.XPath("//*[@id='root']/div[2]/div/div[2]/div/div[3]/div/div[1]/div/div[1]/select/option[5]")).Click();


        //        List<string> groupNames = new List<string>();

        //        // Locate the elements that represent group names
        //        IReadOnlyCollection<IWebElement> groupElements = driver.FindElements(By.XPath("//your_xpath_here"));

        //        // Extract the text of each group element and add it to the list
        //        foreach (var groupElement in groupElements)
        //        {
        //            groupNames.Add(groupElement.Text);
        //        }

        //        return groupNames;
        //    }

        //}

        }
    }
