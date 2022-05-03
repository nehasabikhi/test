using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Action;

namespace TestProject.Pages
{
    internal class LoginPage
    {
        private IWebDriver browser;

        public LoginPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        internal void LoginIntoAccount(string email , string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            RememberMe.Click();
            SignIn.Click();

        }

        internal void VerifyLoginPage()
        {
            Email.Displayed.Should().BeTrue();
        }

        internal void VerifyErrorMessage()
        {
            BaseActions.wait.WaitAWhile(2);
            ErrorMessage.Text.Should().Contain("We didn't recognize that email and/or password");
            SignIn.Enabled.Should().BeFalse();
        }

        internal void ClickNeedHelpLink()
        {
            BaseActions.wait.WaitAWhile(1);
            NeedHelp.Click();
        }

        
        internal void ClickSignUPLink()
        {
            BaseActions.wait.WaitAWhile(1);
            SignUp.Click();
        }

        internal void VerifyLoginPageWithError()
        {
            BaseActions.wait.WaitAWhile(2);
            ErrorMessage.Text.Should().Contain("This account can't log in with an organization yet");
        }

        internal void ClickLoginWIthOrgnization()
        {
            LoginWithOrgnization.Click();
        }
        IWebElement SignUp => browser.FindElement(By.CssSelector("a[class*='signUpLink']"));
        IWebElement Email => browser.FindElement(By.CssSelector("input[data-qa-id='email-input']"));
        IWebElement Password => browser.FindElement(By.CssSelector("input[data-qa-id='password-input']"));
        IWebElement SignIn => browser.FindElement(By.CssSelector("button[data-qa-id='login-btn']"));
        IWebElement LoginWithOrgnization => browser.FindElement(By.CssSelector("button[data-qa-id='log-in-with-organization-btn']"));
        IWebElement RememberMe => browser.FindElement(By.CssSelector("label[data-qa-id='remember-me-checkbox-label']"));
        IWebElement NeedHelp => browser.FindElement(By.CssSelector("a[data-qa-id='need-help-link']"));
        IWebElement ErrorMessage => browser.FindElement(By.CssSelector("p[data-qa-id*='error-display']"));
    }

}