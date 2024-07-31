using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;

namespace TrainingPrograms.cs.ChromeActions.Commands
{
    public class CommonChromeCommand
    {
        private IWebDriver? _driver;

        public CommonChromeCommand(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver LaunchChromeAndGoToUrl(string siteUrl, [Optional] bool headLessMode)
        {
            var options = new ChromeOptions();
            if (headLessMode)
            {
                options.AddArgument("headless");
            }
            _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(siteUrl);
            return _driver;
        }

        public void Quit()
        {
            _driver!.Quit();
        }
    }
}