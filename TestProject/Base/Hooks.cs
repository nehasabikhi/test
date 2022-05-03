using TechTalk.SpecFlow;
using TestProject.Drivers;
using TestProject.Helpers;

namespace TestProject.Base
{
    [Binding]
    public class Hooks : BaseSteps
    {
        private readonly ScenarioContext _scenarioContext;
        string Driver;
        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Driver = ConfigurationManager.GetConfigvalue().BrowserType;
        }
        [BeforeScenario]
        public void FirstBeforeScenario()
        { 
            driver = BrowserSetup.LaunchDriver(Driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //var Driver = ConfigurationManager.GetConfigvalue().BrowserType;
            driver.ScreenshotOfPage(_scenarioContext);
            BrowserSetup.QuitDriver(driver);
        }
    }
}