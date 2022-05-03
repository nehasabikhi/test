using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Utilities
{
    internal class Element
    {
        public Func<IWebDriver, bool> IsDisplayed(IWebElement element)
        {
            return driver =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
            };
        }
    }
}
