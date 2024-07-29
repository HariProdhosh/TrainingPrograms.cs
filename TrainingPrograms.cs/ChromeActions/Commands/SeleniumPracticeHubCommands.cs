using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograms.cs.ChromeActions.ControlsExtension;
using TrainingPrograms.cs.ChromeActions.ElementsFactory;

namespace TrainingPrograms.cs.ChromeActions.Commands
{
    public class SeleniumPracticeHubCommands
    {
        private IWebDriver? _driver;

        public SeleniumPracticeHubCommands(IWebDriver driver)
        {
            _driver = driver;
        }

        public SeleniumPracticeHubCommands ClickOnDesireButtonInTheHomePage(string buttonName)
        {
            SeleniumPracticeHubElementFactory.FindTheDesireButtonInHomePage(_driver!, buttonName).ScrollIntoViewAndClick(_driver!);
            return this;
        }

        public SeleniumPracticeHubCommands ClickAndEnterEmailInEmailArea(string emailToEnter)
        {
            SeleniumPracticeHubElementFactory.EnterYourEmailTextArea(_driver!).Click();
            SeleniumPracticeHubElementFactory.EnterYourEmailTextArea(_driver!).SendKeys(emailToEnter);
            return this;
        }
    }
}