using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Action;

namespace TestProject.Pages
{
    internal class NeedHelpPage
    {
        private IWebDriver browser;

        public NeedHelpPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        IWebElement Heading => browser.FindElement(By.CssSelector("h2[data-qa-id='login-help-headline']"));

        internal void NeedHelpLink()
        {
            BaseActions.wait.WaitAWhile(1);
            Heading.Text.Should().Be("Login Help");
        }
    }
}
