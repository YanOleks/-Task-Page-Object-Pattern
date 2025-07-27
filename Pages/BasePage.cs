using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _Task__Page_Object_Pattern.Pages
{
    public class BasePage
    {     
        protected IWebDriver driver;
        protected TimeSpan defaultTimeout = TimeSpan.FromSeconds(2);
        public BasePage(IWebDriver driver)
        {
            ArgumentNullException.ThrowIfNull(driver);
            this.driver = driver;
        }
    }
}
