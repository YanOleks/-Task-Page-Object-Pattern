using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using _Task__Page_Object_Pattern.Pages;

namespace _Task__Page_Object_Pattern
{
    public class BaseTest
    {
        private IWebDriver driver;
        protected IndexPage indexPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            indexPage = new IndexPage(driver);

            indexPage.Open();
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
