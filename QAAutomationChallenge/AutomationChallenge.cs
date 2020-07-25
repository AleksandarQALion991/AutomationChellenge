using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAAutomationChallenge.Extensions;

namespace QAAutomationChallenge
{
    [TestClass]
    public class AutomationChallenge
    {
        [TestMethod]
        public void AllPositiveOutcomeTasks()
        {
            ActionsPerforming.InitializeDriverChrome();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            TestHelper.Instance.TestExecution();
        }

        [TestMethod]
        public void NegativeTask()
        {
            ActionsPerforming.InitializeDriverChrome();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            TestHelper.Instance.TestExecutionScreenshoot();
        }

        [TestCleanup]
        public void DisplayingTestResultText()
        {
            Driver.driver.Quit();
        }
    }
}
