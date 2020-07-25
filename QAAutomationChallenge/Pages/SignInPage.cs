using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAAutomationChallenge.Pages
{
    public class SignInPage
    {
        public SignInPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement EmailAddressSignInInput { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement SignInSubmitButton { get; set; }

        [FindsBy(How = How.Id, Using = "create_account_error")]
        public IWebElement CreateAccountError { get; set; }
      
    }
}
