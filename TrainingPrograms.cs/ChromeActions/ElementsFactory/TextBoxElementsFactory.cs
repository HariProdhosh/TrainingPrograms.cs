using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TrainingPrograms.cs.ChromeActions.ControlsExtension;
using TrainingPrograms.cs.ChromeActions.Text;

namespace TrainingPrograms.cs.ChromeActions.ElementsFactory
{
    public static class TextBoxElementsFactory
    {
        public static void ClickOnElementsCard(IWebDriver driver)
        {
            var element = driver.waitForElements(driver, By.ClassName(ClassName.CardBody))!.FirstOrDefault(x =>
            x.Text.CaseInSensitiveContains(DomText.Elements))!;
            element.ScrollIntoViewAndClick(driver);
        }

        public static void ClickOnTextBoxCard(IWebDriver driver)
        {
            driver.waitForElements(driver, By.ClassName(ClassName.BtnLight))!.FirstOrDefault(x =>
            x.Text.Contains(DomText.TextBox, StringComparison.OrdinalIgnoreCase))!.Click();
        }

        public static IWebElement FullNameTextBox(IWebDriver driver)
        {
            return driver.waitForElementEnableAndDisplayed(driver, By.Id(TagName.UserNameWrapper))!.FindElement(By.TagName(TagName.Input));
        }
    }
}