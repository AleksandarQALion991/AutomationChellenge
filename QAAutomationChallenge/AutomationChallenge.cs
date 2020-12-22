using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAAutomationChallenge.Extensions;

namespace QAAutomationChallenge
{
    [TestClass]
    public class AutomationChallenge
    {

        [TestMethod]
        public void TestChromeWindows()
        {
            ActionsPerforming.InitializeDriverChrome();
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
