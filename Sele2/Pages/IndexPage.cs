using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sele2.Pages
{
    class IndexPage
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]

        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test]

        public void ExecuteTest()
        {
            Sele2.TestModels.SetTests.TextBox(driver, "search_query", "Printed Summer Dress", "name");
            Sele2.TestModels.SetTests.Click(driver, "submit_search", "name");
        }

        [TearDown]

        public void CleanUp()
        {
            driver.Close();
        }
    }
}

