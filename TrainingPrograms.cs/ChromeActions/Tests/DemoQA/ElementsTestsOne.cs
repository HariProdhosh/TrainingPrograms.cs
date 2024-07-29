using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograms.cs.ChromeActions.Commands;
using TrainingPrograms.cs.ChromeActions.Text;

namespace TrainingPrograms.cs.ChromeActions.Tests.ElementsTests
{
    public class ElementsTestsOne
    {
        private IWebDriver? _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = HPCommands.CommonCommand(_driver!).LaunchChromeAndGoToUrl(SiteURL.DemoQASite);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            HPCommands.CommonCommand(_driver!).Quit();
            _driver!.Dispose();
        }

        [Test]
        public void TextBoxTest()
        {
            HPCommands.TextBoxCommand(_driver!).ClickOnElemntsCardsInLandingPage().SendValueToFullNameTextBox(UserInputs.HariProdhosh);
        }
    }
}