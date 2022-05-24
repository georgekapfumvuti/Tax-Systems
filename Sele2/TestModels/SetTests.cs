using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Sele2.TestModels
{
    class SetTests
    {
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "id")
            {
                driver.FindElement(By.Id(element)).Click();

            }
            if (elementtype == "name")
            {
                driver.FindElement(By.Name(element)).Click();

            }
            if (elementtype == "class")
            {
                driver.FindElement(By.ClassName(element)).Click();

            }
        }

        public static void TextBox(IWebDriver driver, string element, string value, string elementtype)
        {
            
            if (elementtype == "id")
            {
                driver.FindElement(By.Id(element)).Clear();
                driver.FindElement(By.Id(element)).SendKeys(value);

            }
            if (elementtype == "name")
            {
                driver.FindElement(By.Name(element)).Clear();
                driver.FindElement(By.Name(element)).SendKeys(value);

            }
        }
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);

            }
            if (elementtype == "name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);

            }
        }
    }
}
