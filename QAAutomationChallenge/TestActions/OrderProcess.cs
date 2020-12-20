using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using QAAutomationChallenge.Pages;

namespace QAAutomationChallenge.TestActions

{
    internal class OrderProcess
    {
        public static void AddBySearchInput(IWebDriver driver, WebDriverWait webDriverWait, HomePage homePage, Products product, ProductDetailsPage detailsPage)
        {
            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, homePage.SearhInput,
                Config.TestData.SearchItems.SearchTerm);

            ActionsPerforming.ClickElement(driver, webDriverWait, homePage.SearhInputSubmit, true);

            ActionsPerforming.ClickElement(driver, webDriverWait, product.ModelDemo5, true);

            ActionsPerforming.ClickElement(driver, webDriverWait, detailsPage.SubmitButton);

            ActionsPerforming.ClickElement(driver, webDriverWait, detailsPage.ClosePopUpButton, true);

            ActionsPerforming.InputOfStringWithSpecialCharacters(driver, webDriverWait, homePage.SearhInput, 
                Config.TestData.SearchItems.SearchTerm);

            ActionsPerforming.ClickElement(driver, webDriverWait, homePage.SearhInputSubmit, true);

            ActionsPerforming.ClickElement(driver, webDriverWait, product.ModelDemo6, true);

            ActionsPerforming.ClickElement(driver, webDriverWait, detailsPage.SubmitButton);

            ActionsPerforming.ClickElement(driver, webDriverWait, detailsPage.CheckoutButtonDetails, true);
        }
    }
}
