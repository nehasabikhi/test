using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Action;

namespace TestProject.Pages
{
    internal class LoggedinPage
    {
        private IWebDriver browser;

        public LoggedinPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        IWebElement UsernamePanel=> browser.FindElement(By.CssSelector("div[class*='globalusermenu']"));
        IWebElement Email => browser.FindElement(By.Id("email"));
        IWebElement YourProfile => browser.FindElement(By.CssSelector("a[data-qa-id*='usermenu-yourprofile']"));
        //a[data-qa-id*='usermenu-yourprofile']
        internal void VerifyLogin(string email)
        {
            BaseActions.wait.WaitAWhile(3);
            UsernamePanel.Click();
            YourProfile.Click();

            BaseActions.wait.WaitAWhile(1);
            string emailAddress = Email.GetAttribute("value");
            emailAddress.Should().Be(email);
        }
    }
}
