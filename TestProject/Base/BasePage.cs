using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Pages;

namespace TestProject.Base
{
    public class BasePage : BaseSteps
    {
        IWebDriver browser;
        public BasePage()
        {
            browser = driver;
        }
        internal LoginPage LoginPage => new LoginPage(browser);
        internal LoggedinPage LoggedinPage => new LoggedinPage(browser);
        internal NavigatePage NavigatePage => new NavigatePage(browser);
        internal LandingPage LandingPage => new LandingPage(browser);
        internal SignUpPage SignUpPage => new SignUpPage(browser);
        internal NeedHelpPage NeedHelpPage => new NeedHelpPage(browser);
        internal LoginWithOrgnizationPage LoginWithOrgnizationPage => new LoginWithOrgnizationPage(browser);
    }
}
