using OpenQA.Selenium;

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