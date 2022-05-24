using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sele2.TestModels;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;

namespace Sele2.Pages
{
    class SelectItem
    {
        private ExtentReports extenct;
        ExtentReports reports;

        ExtentHtmlReporter htmlReporter;
        ExtentTest test;


        IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]

        public void setUpOnce()
        {
            htmlReporter = new ExtentHtmlReporter(@"C:\extent\joesreport.html");
            extenct = new ExtentReports();
            extenct.AttachReporter(htmlReporter);
        }

        [SetUp]

        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_product=5&controller=product&search_query=Printed+Summer+Dress&results=3");
        }

        [Test]

        public void SelectItemTest()
        {
            Sele2.TestModels.SetTests.TextBox(driver, "quantity_wanted", "2", "id");
            Sele2.TestModels.SetTests.SelectDropDown(driver, "group_1", "M", "id");
            Sele2.TestModels.SetTests.Click(driver, "color_14", "id");
            Sele2.TestModels.SetTests.Click(driver, "Submit", "name");
            Sele2.TestModels.SetTests.Click(driver, "btn btn-default button button-medium", "class");
        }


    
        [TearDown]

        public void CleanUp()
        {
            driver.Close();
        }
    }
}

