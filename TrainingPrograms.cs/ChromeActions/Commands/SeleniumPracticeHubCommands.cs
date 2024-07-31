using OpenQA.Selenium;
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