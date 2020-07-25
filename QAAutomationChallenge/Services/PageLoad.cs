using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAAutomationChallenge
{
    internal class PageLoad
    {
        public static void WaitForPageLoaded(IWebDriver webdriver, WebDriverWait webDriverWait)
        {
            try
            {
                Thread.Sleep(1000);
                webDriverWait.Until<bool>(w => {
                    var javaScriptExecutor = w as IJavaScriptExecutor;
                    return javaScriptExecutor.ExecuteScript("return document.readyState").ToString() == "complete";
                });
            }
            catch (Exception ex)
            {
                Assert.Fail($"Timeout waiting for page load request to complete. Exception={ex.ToString()}");
            }
        }
    }
}
