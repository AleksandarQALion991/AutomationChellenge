using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAAutomationChallenge.Pages
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.Id, Using = "search_query_top")]
        public IWebElement SearhInput { get; set; }

        [FindsBy(How = How.Name, Using = "submit_search")]
        public IWebElement SearhInputSubmit { get; set; }

        [FindsBy(How = How.ClassName, Using = "shopping_cart")]
        public IWebElement ShoppingCart { get; set; }

        [FindsBy(How = How.ClassName, Using = "loginTEST")]
        public IWebElement SignInButtonTEST { get; set; }

    }
}
