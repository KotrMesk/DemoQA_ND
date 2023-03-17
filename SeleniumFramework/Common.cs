using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFramework
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }
        
        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static string GetElementCssAttributeValue(string locator, string cssPropertyName)
        {
            return GetElement(locator).GetCssValue(cssPropertyName);
        }

        internal static void ScrollToElement(string locator)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(Driver.GetDriver());
            actions.ScrollToElement(element);
            actions.Perform();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ScrollByAmount(int x, int y)
        {
            Actions actions = new Actions(Driver.GetDriver());
            actions.ScrollByAmount(x, y);
            actions.Perform();
        }

        internal static void ScrollUntilElementIsClickableAndClickElement(string locator)
        {
            int maxRetries = 5;
            int currentTry = 0;
            while (currentTry < maxRetries)
            {
                try
                {
                    GetElement(locator).Click();
                    break;
                }
                catch (Exception ex)
                {
                    if (ex is ElementClickInterceptedException)
                    {
                        ScrollByAmount(0, 50);
                    }
                    else
                    {
                        throw ex;
                    }
                    currentTry++;
                }
            }
            if (currentTry == maxRetries)
            {
                throw new Exception($"Stopping after trying to scroll for {maxRetries} times. Element with locator '{locator}' was not clickable.");
            }
        }

        internal static void WaitForElementCssPropertyToBe(string locator, string cssProperty, string expectedColor)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetCssValue(cssProperty) == expectedColor);
        }
    }
}
