using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograms.cs.ChromeActions.Commands
{
    public static class HPCommands
    {
        public static CommonChromeCommand CommonCommand(IWebDriver driver)
        {
            return new(driver);
        }

        public static TextBoxCommands TextBoxCommand(IWebDriver driver)
        {
            return new(driver);
        }

        public static SeleniumPracticeHubCommands PractiseHubCommands(IWebDriver driver)
        {
            return new(driver);
        }
    }
}