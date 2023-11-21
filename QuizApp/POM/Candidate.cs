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
    class Candidate
    {

        public void Candidatemenu()
        {
            string Candidate = "//a[normalize-space()='Candidate']";
            Hooks1.driver.FindElement(By.XPath(Candidate)).Click();
        }

        public void Candidatepage()
        {
            Thread.Sleep(3000);
            string Page = Hooks1.driver.FindElement(By.XPath("//*[contains(text(),'ADD CANDIDATE')]")).Text;

            String Actual_Page = "ADD CANDIDATE";
            Assert.AreEqual(Actual_Page, Page);
        }

        public void Candidatedetails(String Name, String Username, String Email, String Phone, String Address )
        {
           
            String CName = "//input[@id='name']";
            Hooks1.driver.FindElement(By.XPath(CName)).SendKeys(Name);
            Thread.Sleep(3000);
            String CUserName = "//input[@id='username']";
            Hooks1.driver.FindElement(By.XPath(CUserName)).SendKeys(Username);
            Thread.Sleep(3000);
            String CEmail = "//input[@id='email']";
            Hooks1.driver.FindElement(By.XPath(CEmail)).SendKeys(Email);
            Thread.Sleep(3000);
            String CPhone = "//input[@id='phone']";
            Hooks1.driver.FindElement(By.XPath(CPhone)).SendKeys(Phone);
            Thread.Sleep(3000);
            String CAddress = "//input[@id='address']";
            Hooks1.driver.FindElement(By.XPath(CAddress)).SendKeys(Address);
            Thread.Sleep(3000);
        }

        public void AddcandidateClick()
        {
           
            string Candidate = "//button[@type='button']";
            Hooks1.driver.FindElement(By.XPath(Candidate)).Click();
            Thread.Sleep(5000);
        }

        public void Candidateverify()
        {
            
            string Candidate = Hooks1.driver.FindElement(By.XPath("//td[normalize-space()='1']")).Text;

            String Actual_Candidate = "1";
            Assert.AreEqual(Actual_Candidate, Candidate);
        }

        public void Resetbutton()
        {
            Thread.Sleep(4000);
            String CName = "//input[@id='name']";
            Hooks1.driver.FindElement(By.XPath(CName)).SendKeys("Test User");
            Thread.Sleep(3000);
            String CUserName = "//input[@id='username']";
            Hooks1.driver.FindElement(By.XPath(CUserName)).SendKeys("Testuser55");
            Thread.Sleep(3000);
            String CEmail = "//input[@id='email']";
            Hooks1.driver.FindElement(By.XPath(CEmail)).SendKeys("Testuser86@gmail.com");
            Thread.Sleep(3000);
            String CPhone = "//input[@id='phone']";
            Hooks1.driver.FindElement(By.XPath(CPhone)).SendKeys("8876567897");
            Thread.Sleep(3000);
            String CAddress = "//input[@id='address']";
            Hooks1.driver.FindElement(By.XPath(CAddress)).SendKeys("Ranchi");
            Thread.Sleep(3000);
            string Resetbtn = "//button[@class='ml-6 px-4 py-2 rounded-md text-white bg-gray-400 hover:bg-gray-600']";
            Hooks1.driver.FindElement(By.XPath(Resetbtn)).Click();

        }

        public void ViewClick()
        {


            Thread.Sleep(3000);
            string Viewbtn = "//tbody/tr[1]/td[7]/div[1]/button[1]//*[name()='svg']";
            Hooks1.driver.FindElement(By.XPath(Viewbtn)).Click();
            Thread.Sleep(3000);

            string exitbtn = " //*[name()='path' and contains(@d,'M19 6.41 1')]";
            Hooks1.driver.FindElement(By.XPath(exitbtn)).Click();
            Thread.Sleep(3000);
           
        }

        public void EditClick()
        {
            Thread.Sleep(3000);
            string Editbtn = "//tbody/tr[1]/td[7]/div[1]/button[2]//*[name()='svg']";
            Hooks1.driver.FindElement(By.XPath(Editbtn)).Click();

            Thread.Sleep(3000);
            string Cancelbtn = "//button[@class='text-red-500 hover:text-red-600 shadow-md bg-red border border-blue rounded-lg px-2 pb-1']";
            Hooks1.driver.FindElement(By.XPath(Cancelbtn)).Click();
        }

        public void DeleteClick()
        {
            Thread.Sleep(3000);
            string Deletebtn = "//tbody/tr[1]/td[4]/div[1]/button[2]//*[name()='svg']";
            Hooks1.driver.FindElement(By.XPath(Deletebtn)).Click();
            Thread.Sleep(3000);
            string Nobtn = " //button[@class='px-4 py-2 bg-red-400 text-white rounded-lg']";
            Hooks1.driver.FindElement(By.XPath(Nobtn)).Click();

        }

    }
}
