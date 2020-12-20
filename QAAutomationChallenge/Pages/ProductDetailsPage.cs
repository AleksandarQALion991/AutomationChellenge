using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAAutomationChallenge.Pages
{
    public class ProductDetailsPage
    {
        public ProductDetailsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "Submit")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "cross")]
        public IWebElement ClosePopUpButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='layer_cart']/div[1]/div[2]/div[4]/a")]
        public IWebElement CheckoutButtonDetails { get; set; }

    }
}
