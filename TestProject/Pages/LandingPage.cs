using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    internal class LandingPage
    {
        private IWebDriver browser;

        public LandingPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        IWebElement Login => browser.FindElement(By.CssSelector("a[data-qa-id='login']"));

        internal void ClickLogin()
        {
            Login.Click();
        }
    }
}
