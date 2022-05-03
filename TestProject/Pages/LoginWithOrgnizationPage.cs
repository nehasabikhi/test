using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    internal class LoginWithOrgnizationPage
    {
        private IWebDriver browser;

        public LoginWithOrgnizationPage(IWebDriver browser)
        {
            this.browser = browser;
        }

        IWebElement LoginWithOrgnizationPageHeading => browser.FindElement(By.XPath("//h2[text()= 'Log into Hudl with your Organization']"));
        IWebElement email => browser.FindElement(By.CssSelector("input[type= 'email']"));
        IWebElement submit => browser.FindElement(By.CssSelector("button[data-qa-id= 'log-in-with-sso']"));

        internal void ClickSubmit()
        {
            submit.Click();
        }

        internal void EnterEmail(string emailAddress)
        {
            email.SendKeys(emailAddress);
        }

        internal void VerifyLoginWithOrgnizationPage()
        {
            LoginWithOrgnizationPageHeading.Text.Should().Be("Log into Hudl with your Organization");
        }
    }
}
