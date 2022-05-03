using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TestProject.Helpers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    internal class NavigatePage
    {
        private IWebDriver browser;

        public NavigatePage(IWebDriver browser)
        {
            this.browser = browser;
        }

        internal void GotoUrl()
        {
            var url = ConfigurationManager.GetConfigvalue().BaseUrl;
            browser.Navigate().GoToUrl(url);
        }
    }
}
