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
    class Login
    {
        public void Loginwithgoogle()
        {
            string Button = "//p[@class='ml-2']";
            Hooks1.driver.FindElement(By.XPath(Button)).Click();
        }

        public void Fillcredentials(string Username , string Password)
        {

            string mainWindowHandle = Hooks1.driver.CurrentWindowHandle;
            foreach (string handle1 in Hooks1.driver.WindowHandles)
            {
                if (handle1 != mainWindowHandle)
                {
                    Hooks1.driver.SwitchTo().Window(handle1);
                    break;
                }
            }

            string Email = " //input[@id='identifierId']";
            Hooks1.driver.FindElement(By.XPath(Email)).SendKeys(Username);

            Thread.Sleep(4000);

            string Next = "//span[normalize-space()='Next']";
            Hooks1.driver.FindElement(By.XPath(Next)).Click();
            Thread.Sleep(4000);

            string Password1 = "//input[@name='Passwd']";
            Hooks1.driver.FindElement(By.XPath(Password1)).SendKeys(Password);
            Thread.Sleep(4000);

            string Next1 = "//span[normalize-space()='Next']";
            Hooks1.driver.FindElement(By.XPath(Next1)).Click();

          }
       }
    }

