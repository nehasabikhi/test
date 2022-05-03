using TestProject.Base;

namespace TestProject.StepDefinitions
{
    [Binding]
    [Scope(Tag = "Login")]
    public sealed class LoginStepDefination : BaseSteps
    {
        [Given(@"I navigate to site")]
        public void GivenINavigateToSite()
        {
            BasePage.NavigatePage.GotoUrl();
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            BasePage.LandingPage.ClickLogin();
        }

        [Then(@"Login Page is displayed")]
        public void ThenLoginPageIsDisplayed()
        {
            BasePage.LoginPage.VerifyLoginPage();
        }

        [Then(@"I enter (.*) and (.*)")]
        public void ThenIEnterSharma_NehaGmail_ComAndPWrD(string username, string password)
        {
            BasePage.LoginPage.LoginIntoAccount(username , password);
        }

        [Then(@"Verify login (.*)")]
        public void ThenVerifyLogin(string email)
        {
            BasePage.LoggedinPage.VerifyLogin(email);
        }

        //[Then(@"I enter abc and abc")]
        //public void ThenIEnterAbcAndAbc()
        //{
        //    throw new PendingStepException();
        //}

        [Then(@"Verify user not able to login")]
        public void ThenVerifyUserNotAbleToLogin()
        {
            BasePage.LoginPage.VerifyErrorMessage();
        }

        [When(@"I click needHelp link")]
        public void WhenIClickNeedHelpLink()
        {
            BasePage.LoginPage.ClickNeedHelpLink();
        }


        [Then(@"I will be able to verify Need help link")]
        public void ThenIWillBeAbleToVerifyNeedHelpLink()
        {
            BasePage.NeedHelpPage.NeedHelpLink();
        }

        [When(@"I click login with orgnization")]
        public void WhenIClickLoginWithOrgnization()
        {
            BasePage.LoginPage.ClickLoginWIthOrgnization();
        }

        [Then(@"it show heading login with orgnization")]
        public void ThenItShowHeadingLoginWithOrgnization()
        {
            BasePage.LoginWithOrgnizationPage.VerifyLoginWithOrgnizationPage();
        }

        [When(@"I enter my email (.*)")]
        public void WhenIEnterMyEmail(string email)
        {
            BasePage.LoginWithOrgnizationPage.EnterEmail(email);
        }

        [When(@"click submit")]
        public void WhenClickSubmit()
        {
            BasePage.LoginWithOrgnizationPage.ClickSubmit();
        }

        [Then(@"it will redirect to login with email page with error message")]
        public void ThenItWillRedirectToLoginWithEmailPageWithErrorMessage()
        {
            BasePage.LoginPage.VerifyLoginPageWithError();
        }

        [When(@"I click sign up link")]
        public void WhenIClickSignUpLink()
        {
            BasePage.LoginPage.ClickSignUPLink();
        }

        [Then(@"I am redirected to sign up page")]
        public void ThenIAmRedirectedToSignUpPage()
        {
            BasePage.SignUpPage.VerifySignUPPage();
        }

    }
}