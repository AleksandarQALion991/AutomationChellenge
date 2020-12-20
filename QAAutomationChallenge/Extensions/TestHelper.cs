using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QAAutomationChallenge.Pages;
using QAAutomationChallenge.TestActions;
using System;

namespace QAAutomationChallenge.Extensions
{
    public sealed class TestHelper
    {
        public string _textMessage = String.Empty;

        private static readonly TestHelper _instance = new TestHelper();

        private UnitTestOutcome _testOutcome;

        public static TestHelper Instance
        {
            get
            {
                return _instance;
            }
        }

        public void TestExecution()
        {
            var textMessageFailed = string.Empty;
            var generatedEmail = Config.Credentials.Valid.Email;

            HomePage homePage = new HomePage();
            SignInPage signInPage = new SignInPage();
            SignInFormPage signInFormPage = new SignInFormPage();
            AccountPage accountPage = new AccountPage();
            WebDriverWait webDriverWait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

            try
            {
                //Testing 'Sign Up' page
                SignIn.CreateAnAccount(Driver.driver, webDriverWait, homePage, signInPage, generatedEmail);

                SignIn.FillSignUpFormSubmit(Driver.driver, webDriverWait, signInFormPage, accountPage);

                SignIn.LogIn(Driver.driver, webDriverWait, accountPage, homePage, signInPage, generatedEmail);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, homePage.SearhInput, Config.TestData.SearchItems.SearchTerm);

                _testOutcome = UnitTestOutcome.Passed;
            }
            catch (Exception ex)
            {
                textMessageFailed = "\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
                textMessageFailed += "\nTest case failed!";
                textMessageFailed += "\nError: " + ex.Message;
                textMessageFailed += "\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
                textMessageFailed += "\nException: " + ex.ToString();

                ActionsPerforming.TakingScreenshotOnFailure(Driver.driver);

                _testOutcome = UnitTestOutcome.Failed;

                Assert.Fail(textMessageFailed);
            }
        }
    }
}