using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QAAutomationChallenge.Pages;

namespace QAAutomationChallenge.TestActions
{
    internal class CheckoutFlow
    {
        public static void CompleteCheckout(IWebDriver driver, WebDriverWait webDriverWait, ShoppingCart shoppingCart)
        {
            ActionsPerforming.ClickElement(driver, webDriverWait, shoppingCart.CheckoutButton, true);

            ActionsPerforming.ClickElement(driver, webDriverWait, shoppingCart.CheckoutButtonAddress, true);

            ActionsPerforming.ClickElement(driver, webDriverWait, shoppingCart.TermsOfService);

            ActionsPerforming.ClickElement(driver, webDriverWait, shoppingCart.CheckoutButtonShippping, true);

            ActionsPerforming.ClickElement(driver, webDriverWait, shoppingCart.Bankwire, true);

            ActionsPerforming.ClickElement(driver, webDriverWait, shoppingCart.ConfirmOrderButton, true);
        }

        public static void DeleteProduct(IWebDriver driver, WebDriverWait webDriverWait, HomePage homePage, ShoppingCart shoppingCart)
        {
            ActionsPerforming.ClickElement(driver, webDriverWait, shoppingCart.TrashIconOne, true);
        }
    }
}
