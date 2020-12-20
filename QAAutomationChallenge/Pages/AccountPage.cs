using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAAutomationChallenge.Pages
{
    public class AccountPage
    {
        public AccountPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "logout")]
        public IWebElement SignOutButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "account")]
        public IWebElement ViewMyAccountButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "myaccount-link-list")]
        public IWebElement MyAccountSection { get; set; }
    }
}
