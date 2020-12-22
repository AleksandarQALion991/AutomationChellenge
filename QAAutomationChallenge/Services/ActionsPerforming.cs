using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using WaitHelpers = SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Text;
using System.Threading;

namespace QAAutomationChallenge
{
    public class ActionsPerforming
    {
        private static string textMessageFailed = String.Empty;

        public static void InitializeDriverChrome()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            Driver.driver = new ChromeDriver(@"../../" + "Configuration/Windows/", options);
        }

        public static void SelectVisibleTextFromDropbox(IWebDriver webDriver, WebDriverWait webDriverWait, IWebElement webElement, string selectVisibleText)
        {

            try
            {
                var javaScriptExecutor = webDriver as IJavaScriptExecutor;

                javaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", webElement);

                var dropdown = new SelectElement(webElement);
                dropdown.SelectByValue(selectVisibleText);
            }
            catch (Exception ex)
            {
                textMessageFailed = "\nSelecting value \"" + selectVisibleText + "\" from dropbox could not be performed on web element " + webElement + "!";
                textMessageFailed += "\nException: " + ex.ToString();
                Assert.Fail(textMessageFailed);
            }

        }


        public static void ClickElement(IWebDriver webDriver, WebDriverWait webDriverWait, IWebElement webElement, bool withTimeout = false)
        {

            try
            {
                var javaScriptExecutor = webDriver as IJavaScriptExecutor;

                javaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", webElement);

                if (withTimeout)
                {
                    Thread.Sleep(2000);
                }

                javaScriptExecutor.ExecuteScript("arguments[0].click();", webElement);
                //webElement.Click();
            }
            catch (Exception ex)
            {
                textMessageFailed = "\nClicking on web element " + webElement + "could not be perfomed!";
                textMessageFailed += "\nException: " + ex.ToString();
                Assert.Fail(textMessageFailed);
            }

        }

        public static void InputOfStringWithSpecialCharacters(IWebDriver webDriver, WebDriverWait webDriverWait, IWebElement webElement, string inputString)
        {
            var action = new Actions(webDriver);

            try
            {
                var javaScriptExecutor = webDriver as IJavaScriptExecutor;

                javaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", webElement);

                webDriverWait.Until(WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));

                webElement.Clear();

                action.SendKeys(webElement, inputString).Build().Perform();
            }
            catch (Exception ex)
            {
                textMessageFailed = "\nInput of string value \"" + inputString + "\" could not be performed on web element " + webElement + "!";
                textMessageFailed += "\nException: " + ex.ToString();
                Assert.Fail(textMessageFailed);
            }
        }

        public static void TakingScreenshotOnFailure(IWebDriver webDriver)
        {
            var timeStamp = DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss");
            string screenshotsFolder = Directory.GetCurrentDirectory() + @"\FailedTestScreenshots";

            try
            {

                Screenshot failedTestScreenshot = ((ITakesScreenshot)webDriver).GetScreenshot();

                if (!Directory.Exists(screenshotsFolder))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\FailedTestScreenshots");
                }

                failedTestScreenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\FailedTestScreenshots\failedtestscreenshot_" + timeStamp + ".png", ScreenshotImageFormat.Png);
            }
            catch (Exception ex)
            {
                textMessageFailed += "\nException: " + ex.ToString();
            }
        }
    }
}
