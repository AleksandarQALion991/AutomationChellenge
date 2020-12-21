using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using QAAutomationChallenge.Pages;
using QAAutomationChallenge.TestActions;
using System;

namespace QAAutomationChallenge.Extensions
{
    public sealed class TestHelper
    {
        private static readonly TestHelper _instance = new TestHelper();
        private static ILog _logger = LogManager.GetLogger(typeof(TestHelper));

        public string _textMessage = string.Empty;
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
            //Paremeters
            var textMessageFailed = string.Empty;
            var generatedEmail = Config.Credentials.Valid.Email;

            HomePage homePage = new HomePage();
            SignInPage signInPage = new SignInPage();
            SignInFormPage signInFormPage = new SignInFormPage();
            AccountPage accountPage = new AccountPage();
            WebDriverWait webDriverWait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));
            Products products = new Products();
            ProductDetailsPage detailsPage = new ProductDetailsPage();
            ShoppingCart shoppingCart = new ShoppingCart();

            try
            {
                //Testing 'Sign Up' option 
                SignIn.CreateAnAccount(Driver.driver, webDriverWait, homePage, signInPage, generatedEmail);

                SignIn.FillSignUpFormSubmit(Driver.driver, webDriverWait, signInFormPage, accountPage);

                //Testing 'Log In' option
                SignIn.LogIn(Driver.driver, webDriverWait, accountPage, homePage, signInPage, generatedEmail);

                //Adding products to cart using search input
                OrderProcess.AddBySearchInput(Driver.driver, webDriverWait, homePage, products, detailsPage);

                //Remove product from cart
                CheckoutFlow.DeleteProduct(Driver.driver, webDriverWait, homePage, shoppingCart);

                //Complete checkout flow
                CheckoutFlow.CompleteCheckout(Driver.driver, webDriverWait, shoppingCart);

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