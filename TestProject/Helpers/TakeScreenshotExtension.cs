using OpenQA.Selenium;

namespace TestProject.Helpers
{
    internal static class TakeScreenshotExtension
    {
        public static void ScreenshotOfPage(this IWebDriver driver, ScenarioContext context)
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                string filename = context.ScenarioInfo.Title.ToString()
                    + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                Directory.CreateDirectory("screenshots");

                ss.SaveAsFile(Directory.GetCurrentDirectory()
                    + Path.DirectorySeparatorChar + "screenshots" + Path.DirectorySeparatorChar + filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }
    }
}
