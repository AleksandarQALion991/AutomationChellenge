using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAAutomationChallenge.Pages
{
    public class SignInFormPage
    {

        public SignInFormPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "id_gender1")]
        public IWebElement TitleMr { get; set; }

        [FindsBy(How = How.Id, Using = "id_gender2")]
        public IWebElement TitleMrs { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement CustomerFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement CustomerLastName { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "days")]
        public IWebElement Days { get; set; }

        [FindsBy(How = How.Id, Using = "months")]
        public IWebElement Months { get; set; }

        [FindsBy(How = How.Id, Using = "years")]
        public IWebElement Years { get; set; }

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        public IWebElement Company { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.Id, Using = "id_country")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement PhoneMobile { get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement AliasAddress { get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement SubmitAccount { get; set; }
        
    }
}
