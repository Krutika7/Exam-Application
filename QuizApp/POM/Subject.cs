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
    class Subject
    {
        public void Subjectmenu()
        {
            string Group = "//a[normalize-space()='Subject']";
            Hooks1.driver.FindElement(By.XPath(Group)).Click();
        }

        public void Subjectpage()
        {
            Thread.Sleep(3000);
            string Page = Hooks1.driver.FindElement(By.XPath("//p[@class='pb-4 font-bold text-gray-600']")).Text;

            String Actual_Page = "ADD SUBJECT";
            Assert.AreEqual(Actual_Page, Page);
        }
        public void Subjects()
        {

            string Subname = "//input[@id='subjectName']";
            Hooks1.driver.FindElement(By.XPath(Subname)).SendKeys("Software Testing");
            Thread.Sleep(5000);
            string Subdescription = "//textarea[@id='description']";
            Hooks1.driver.FindElement(By.XPath(Subdescription)).SendKeys("Evaluating and verifying of software product or application");
            Thread.Sleep(5000);
        }
        public void Addsubjectbtn()
        {
            string Addbtn = "//button[@type='button']";
            Hooks1.driver.FindElement(By.XPath(Addbtn)).Click();
            Thread.Sleep(5000);
        }

        public void Resetbtn()
        {
            string Subname = "//input[@id='subjectName']";
            Hooks1.driver.FindElement(By.XPath(Subname)).SendKeys("Software Testing");
            Thread.Sleep(5000);
            string Subdescription = "//textarea[@id='description']";
            Hooks1.driver.FindElement(By.XPath(Subdescription)).SendKeys("Evaluating and verifying of software product or application");
            Thread.Sleep(5000);
            string Addbtn = "//button[@type='reset']";
            Hooks1.driver.FindElement(By.XPath(Addbtn)).Click();
            Thread.Sleep(5000);

        }

        public void Subjectedit()
        {
            string Editicon = "//tbody/tr[1]/td[4]/div[1]/button[1]//*[name()='svg']";
            Hooks1.driver.FindElement(By.XPath(Editicon)).Click();
            Thread.Sleep(5000);
            string Cancelbtn = " //button[@class='text-red-500 hover:text-red-600 shadow-md bg-red border border-blue rounded-lg px-2 pb-1']";
            Hooks1.driver.FindElement(By.XPath(Cancelbtn)).Click();
            Thread.Sleep(5000);
        }
        public void Subjectdelete()
        {
            string Deleteicon = "//tbody/tr[1]/td[4]/div[1]/button[2]//*[name()='svg']//*[name()='path' and contains(@d,'M5.5 5.5A.')]";
            Hooks1.driver.FindElement(By.XPath(Deleteicon)).Click();
            Thread.Sleep(5000);
            string Nobtn = " //button[@class='px-4 py-2 bg-red-400 text-white rounded-lg']";
            Hooks1.driver.FindElement(By.XPath(Nobtn)).Click();
            Thread.Sleep(5000);
        }
        


    }
}
