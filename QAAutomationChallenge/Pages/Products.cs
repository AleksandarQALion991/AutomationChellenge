using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAAutomationChallenge.Pages
{
    public class Products
    {
        public Products()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li[1]/div/div[1]/div/a[1]")]
        public IWebElement ModelDemo5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li[2]/div/div[1]/div/a[2]")]
        public IWebElement ModelDemo6 { get; set; }

        [FindsBy(How = How.Name, Using = "ajax_add_to_cart_button")]
        public IWebElement AddButton { get; set; }

    }
}
