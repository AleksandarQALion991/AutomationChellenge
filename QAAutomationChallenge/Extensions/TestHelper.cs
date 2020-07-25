using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using QAAutomationChallenge.Pages;
using QAAutomationChallenge.Services;
using System;
using System.Threading;

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
            string textMessageFailed = String.Empty;

            HomePage homePage = new HomePage();
            SignInPage signInPage = new SignInPage();
            SignInFormPage signInFormPage = new SignInFormPage();
            AccountPage accountPage = new AccountPage();

            WebDriverWait webDriverWait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

            try
            {

                homePage.SignInButton.Click();

                Thread.Sleep(2000);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInPage.EmailAddressSignInInput, Config.Credentials.Valid.Email);

                signInPage.SignInSubmitButton.Click();

                Thread.Sleep(5000);

                signInFormPage.TitleMr.Click();

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.CustomerFirstName, Config.Credentials.Valid.FirstName);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.CustomerLastName, Config.Credentials.Valid.LastName);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.Password, Config.Credentials.Valid.Password);

                ActionsPerforming.SelectVisibleTextFromDropbox(Driver.driver, webDriverWait, signInFormPage.Days, Config.Credentials.Valid.DayOfBirth);

                ActionsPerforming.SelectVisibleTextFromDropbox(Driver.driver, webDriverWait, signInFormPage.Months, Config.Credentials.Valid.Month);

                ActionsPerforming.SelectVisibleTextFromDropbox(Driver.driver, webDriverWait, signInFormPage.Years, Config.Credentials.Valid.Year);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.FirstName, Config.Credentials.Valid.FirstName);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.LastName, Config.Credentials.Valid.LastName);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.Company, Config.Credentials.Valid.Company);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.Address, Config.Credentials.Valid.Address);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.City, Config.Credentials.Valid.City);

                ActionsPerforming.SelectVisibleTextFromDropbox(Driver.driver, webDriverWait, signInFormPage.State, Config.Credentials.Valid.State);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.PostalCode, Config.Credentials.Valid.PostalCode);

                ActionsPerforming.InputOfStringWithSpecialCharacters(Driver.driver, webDriverWait, signInFormPage.PhoneMobile, Config.Credentials.Valid.PhoneMobile);

                signInFormPage.SubmitAccount.Click();

                Thread.Sleep(3000);

                if (accountPage.SignOutButton.Displayed)
                {
                    _textMessage = "\nSignOut button is displayed!";
                }

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

        public void TestExecutionScreenshoot()
        {
            string textMessageFailed = String.Empty;

            HomePage homePage = new HomePage();

            try
            {
                homePage.SignInButtonTEST.Click();
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