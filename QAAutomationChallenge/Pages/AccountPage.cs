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
    }
}
