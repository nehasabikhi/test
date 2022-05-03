using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace TestProject.Drivers
{
    internal class BrowserSetup
    {
        static IWebDriver Driver;

        public static IWebDriver LaunchDriver(string browser)
        {

            switch (browser.ToLower())
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("headless");
                    Driver = new ChromeDriver(chromeOptions);
                    break;
                case "firefox":
                    Driver = new FirefoxDriver();
                    break;
                case "ie":
                    Driver = new InternetExplorerDriver();
                    break;
                default:
                    Driver = new ChromeDriver();
                    break;
            }
            Driver.Manage().Window.Maximize();
            return Driver;
        }

        public static void QuitDriver(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
