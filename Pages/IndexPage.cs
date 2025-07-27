using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _Task__Page_Object_Pattern.Pages
{
    public class IndexPage(IWebDriver driver) : BasePage(driver)
    {
        private const string PageUrl = "https://www.epam.com/";
        private readonly By careersLinkBy = By.LinkText("Careers");

        public IndexPage Open()
        {
            driver.Navigate().GoToUrl(PageUrl);
            return this;
        }

        public CareersPage ClickCareersLink()
        {
            driver.FindElement(careersLinkBy).Click();
            return new CareersPage(driver);
        }
    }
}
