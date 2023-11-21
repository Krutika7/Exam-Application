using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace QuizApp.Hooks
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver driver;

        public static string Path1 = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Result");
        public static string Path2 = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Screenshot");
        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentTest feature;
        AventStack.ExtentReports.ExtentTest scenario;
        AventStack.ExtentReports.ExtentTest step;
        //public static IWebDriver driver;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(Path1 + @"index.html");
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);

            //extent.AddSystemInfo("<div style = 'color:green;font-weight:Bold'>Website</div>", "https://melanatedhealthqa.web.app/");
            //extent.AddSystemInfo("<div style = 'color:red;font-weight:Bold'>OS</div>", "Windows 11");
            //extent.AddSystemInfo("<div style = 'color:blue;font-weight:Bold'>Browser</div>", "Chrome");

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title);

        }


        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://talentforgefrontends.azurewebsites.net/admin/home");
            Thread.Sleep(4000);

          
                scenario = feature.CreateNode(context.ScenarioInfo.Title);
            
            //featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

            //string Button = "//p[@class='ml-2']";
            //Hooks1.driver.FindElement(By.XPath(Button)).Click();
            //TODO: implement logic that has to run before executing each scenario
        }



        [BeforeStep]
        public void BeforeStep()
        {
            step = scenario;
        }

        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {
            Status stepStatus = context.TestError == null ? Status.Pass : Status.Fail;

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshotPath = Path2 + context.StepContext.StepInfo.Text + ".png";
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

            if (context.TestError != null)
            {
                step.Fail(context.StepContext.StepInfo.Text);
            }
            else
            {
                step.Pass(context.StepContext.StepInfo.Text);
            }

            step.AddScreenCaptureFromPath(screenshotPath);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
        }

        [AfterScenario]
        public void AfterScenario()
        {


            driver.Quit();
        }


    }
}
