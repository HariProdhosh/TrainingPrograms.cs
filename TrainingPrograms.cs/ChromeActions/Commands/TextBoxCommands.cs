using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrainingPrograms.cs.ChromeActions.ElementsFactory;

namespace TrainingPrograms.cs.ChromeActions.Commands
{
    public class TextBoxCommands
    {
        private readonly IWebDriver? _driver;

        public TextBoxCommands(IWebDriver driver)
        {
            _driver = driver;
        }

        public TextBoxCommands ClickOnElemntsCardsInLandingPage()
        {
            TextBoxElementsFactory.ClickOnElementsCard(_driver!);
            TextBoxElementsFactory.ClickOnTextBoxCard(_driver!);
            return this;
        }

        public TextBoxCommands SendValueToFullNameTextBox(string input)
        {
            TextBoxElementsFactory.FullNameTextBox(_driver!).SendKeys(input);
            return this;
        }
    }
}