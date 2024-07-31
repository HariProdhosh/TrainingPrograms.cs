using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TrainingPrograms.cs.ChromeActions.ControlsExtension
{
    public static class ControlExtension
    {
        private const int defaultTimeOutInSeconds = 30;

        public static IWebElement waitForElement(this ISearchContext context, IWebDriver driver, By by, int timeOut = defaultTimeOutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(x => context.FindElement(by));
        }

        public static IReadOnlyCollection<IWebElement> waitForElements(this ISearchContext context, IWebDriver driver, By by, int timeOut = defaultTimeOutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(x => context.FindElements(by));
        }

        public static IWebElement? waitForElementEnableAndDisplayed(this ISearchContext context, IWebDriver driver, By by, int timeOut = defaultTimeOutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            var element = wait.Until(x => context.FindElement(by));
            for (int i = 0; i < timeOut; i++)
            {
                try
                {
                    if (element.Displayed && element.Enabled)
                    {
                        return element;
                    }
                }
                catch
                {
                }
                Thread.Sleep(1000);
            }
            return null;
        }

        public static bool CaseInSensitiveEquals(this string givenString, string toCompare)
        {
            return givenString.Equals(toCompare, StringComparison.OrdinalIgnoreCase);
        }

        public static bool CaseInSensitiveContains(this string givenString, string toCompare)
        {
            return givenString.Contains(toCompare, StringComparison.OrdinalIgnoreCase);
        }

        public static void ScrollIntoView(this IWebElement element, IWebDriver driver)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
            Thread.Sleep(500);
        }

        public static void ScrollIntoViewAndClick(this IWebElement element, IWebDriver driver)
        {
            element.ScrollIntoView(driver);
            element.Click();
        }
    }
}