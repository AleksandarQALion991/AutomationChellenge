using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QAAutomationChallenge.Pages;
using System.Threading;

namespace QAAutomationChallenge.TestActions
{
    internal class SignIn
    {
        public static void CreateAnAccount(IWebDriver driver, WebDriverWait webDriverWait, HomePage homePage, SignInPage signInPage, string email)
        {
            homePage.SignInButton.Click();

            Thread.Sleep(2000);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInPage.EmailAddressSignInInput, email);

            signInPage.SignInSubmitButton.Click();

            Thread.Sleep(5000);
        }

        public static void FillSignUpFormSubmit(IWebDriver driver, WebDriverWait webDriverWait, SignInFormPage signInFormPage, AccountPage accountPage)
        {

            signInFormPage.TitleMr.Click();

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.CustomerFirstName, 
                Config.Credentials.Valid.FirstName);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.CustomerLastName, 
                Config.Credentials.Valid.LastName);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.Password, 
                Config.Credentials.Valid.Password);

            ActionsPerforming.SelectVisibleTextFromDropbox(driver, webDriverWait, signInFormPage.Days, 
                Config.Credentials.Valid.DayOfBirth);

            ActionsPerforming.SelectVisibleTextFromDropbox(driver, webDriverWait, signInFormPage.Months, 
                Config.Credentials.Valid.Month);

            ActionsPerforming.SelectVisibleTextFromDropbox(driver, webDriverWait, signInFormPage.Years,
                Config.Credentials.Valid.Year);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.FirstName,
                Config.Credentials.Valid.FirstName);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.LastName, 
                Config.Credentials.Valid.LastName);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.Company,
                Config.Credentials.Valid.Company);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.Address,
                Config.Credentials.Valid.Address);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.City, 
                Config.Credentials.Valid.City);

            ActionsPerforming.SelectVisibleTextFromDropbox(driver, webDriverWait, signInFormPage.State, 
                Config.Credentials.Valid.State);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.PostalCode, 
                Config.Credentials.Valid.PostalCode);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInFormPage.PhoneMobile, 
                Config.Credentials.Valid.PhoneMobile);

            signInFormPage.SubmitAccount.Click();

            Thread.Sleep(3000);

            Assert.IsTrue(accountPage.ViewMyAccountButton.Displayed);
        }

        public static void LogIn(IWebDriver driver, WebDriverWait webDriverWait, AccountPage accountPage, HomePage homePage, SignInPage signInPage, string email)
        {
            accountPage.SignOutButton.Click();
            Thread.Sleep(2000);

            homePage.SignInButton.Click();
            Thread.Sleep(2000);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInPage.LogInEmail, email);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, signInPage.LogInPassword, Config.Credentials.Valid.Password);

            signInPage.LogInSubmit.Click();

            Thread.Sleep(2000);

            Assert.IsTrue(accountPage.ViewMyAccountButton.Displayed);
        }
    }
}
