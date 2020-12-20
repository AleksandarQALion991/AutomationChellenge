using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAAutomationChallenge.Pages
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "icon-trash")]
        public IWebElement TrashIconOne { get; set; }

        [FindsBy(How = How.ClassName, Using = "standard-checkout")]
        public IWebElement CheckoutButton { get; set; }

        //Address step
        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement CheckoutButtonAddress { get; set; }

        //Shipping step
        [FindsBy(How = How.Id, Using = "cgv")]
        public IWebElement TermsOfService { get; set; }

        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement CheckoutButtonShippping { get; set; }

        //Payment step 1 - type selection
        [FindsBy(How = How.ClassName, Using = "bankwire")]
        public IWebElement Bankwire { get; set; }

        //Payment step 2 - confirmation
        [FindsBy(How = How.XPath, Using = "//*[@id='cart_navigation']/button")]
        public IWebElement ConfirmOrderButton { get; set; }

        //Confirmation step 
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/span/strong")]
        public IWebElement Price { get; set; }
    }
}
