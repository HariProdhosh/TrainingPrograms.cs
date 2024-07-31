using OpenQA.Selenium;
using TrainingPrograms.cs.ChromeActions.Commands;
using TrainingPrograms.cs.ChromeActions.Text;

namespace TrainingPrograms.cs.ChromeActions.Tests.Edit_Tests
{
    public class WorkWithEditFieldsTestOne
    {
        private IWebDriver? _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = HPCommands.CommonCommand(_driver!).LaunchChromeAndGoToUrl(SiteURL.SeleniumPracticeHub);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            HPCommands.CommonCommand(_driver!).Quit();
            _driver!.Dispose();
        }

        [Test]
        public void ToEnterEmailAddress()
        {
            HPCommands.PractiseHubCommands(_driver!).ClickOnDesireButtonInTheHomePage(DomText.Edit).ClickAndEnterEmailInEmailArea(UserInputs.HariProdhoshEmail);
        }
    }
}