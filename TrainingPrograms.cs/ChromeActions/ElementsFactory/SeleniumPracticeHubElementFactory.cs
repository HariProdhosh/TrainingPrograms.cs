using OpenQA.Selenium;
using TrainingPrograms.cs.ChromeActions.Text;
using static TrainingPrograms.cs.ChromeActions.ControlsExtension.ControlExtension;

namespace TrainingPrograms.cs.ChromeActions.ElementsFactory
{
    public static class SeleniumPracticeHubElementFactory
    {
        public static IWebElement FindTheDesireButtonInHomePage(IWebDriver driver, string buttonName)
        {
            return driver.waitForElements(driver, By.ClassName(ClassName.WpCategoriesTitle))!.FirstOrDefault(x =>
            x.Text.Trim().CaseInSensitiveContains(buttonName))!;
        }

        public static IWebElement EnterYourEmailTextArea(IWebDriver driver)
        {
            return driver.waitForElements(driver, By.ClassName(ClassName.Row)).FirstOrDefault(x =>
            x.Text.CaseInSensitiveContains(DomText.EnterYourEmailAddress))!.waitForElementEnableAndDisplayed(driver, By.TagName(TagName.Input))!;
        }
    }
}