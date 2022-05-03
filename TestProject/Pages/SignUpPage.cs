using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Action;

namespace TestProject.Pages
{
    internal class SignUpPage
    {
        private IWebDriver browser;

        public SignUpPage(IWebDriver browser)
        {
            this.browser = browser;
        }
        //request demo
        IWebElement Button => browser.FindElement(By.CssSelector("a[id='register_demo']"));

        internal void VerifySignUPPage()
        {
            BaseActions.wait.WaitAWhile(2);
            Button.Displayed.Should().BeTrue();
        }
    }
}
