using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Drivers;

namespace TestProject.Base
{
    public class BaseSteps
    {
        public static IWebDriver? driver { get; set; }
        public BasePage BasePage => new BasePage();
    }
}
