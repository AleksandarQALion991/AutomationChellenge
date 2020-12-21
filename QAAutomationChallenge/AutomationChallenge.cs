using System;
using System.IO;
using System.Reflection;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAAutomationChallenge.Extensions;

namespace QAAutomationChallenge
{
    [TestClass]
    public class AutomationChallenge
    {
        [AssemblyInitialize]
        public static void Configure(TestContext testContext)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            var fi = new FileInfo("log4net.config");
            log4net.Config.XmlConfigurator.Configure(logRepository, fi);
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            var compName = Environment.GetEnvironmentVariable("COMPUTERNAME");
            var user = Environment.GetEnvironmentVariable("USER");
        }

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
