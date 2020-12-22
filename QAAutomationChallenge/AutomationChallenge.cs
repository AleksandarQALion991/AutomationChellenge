using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAAutomationChallenge.Extensions;
using System;

namespace QAAutomationChallenge
{
    [TestClass]
    public class AutomationChallenge
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            var driverPath = @"../../" + "Configuration/Windows/";
            ActionsPerforming.InitializeDriverChrome(driverPath);
        }

        [TestMethod]
        public void TestChromeWindows()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            TestHelper.Instance.TestExecution();
        }

        [TestCleanup]
        public void DisplayingTestResultText()
        {
            Driver.driver.Close();
            Driver.driver.Quit();
        }
    }
}
