using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Utilities;

namespace TestProject.Action
{
    internal class Wait
    {
        Element Element = new Element();
        internal void ForElement(IWebDriver driver, IWebElement element, int TimeOutInSec = 0)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(TimeOutInSec)).Until(Element.IsDisplayed(element));
        }
        internal void WaitAWhile(int TimeOutInSec = 0)
        {
            Thread.Sleep(TimeSpan.FromSeconds(TimeOutInSec));
        }
    }
}
