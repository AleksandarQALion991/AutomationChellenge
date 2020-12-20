
using OpenQA.Selenium.Support.UI;
using QAAutomationChallenge.Services;
using System;

namespace QAAutomationChallenge
{
    public class Config
    {
        public static string BaseURL = "http://automationpractice.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string FirstName = "Aleksandar";
                public static string LastName = "Saric";
                public static string Email = RandomString.GenerateRandomName(5) + "@gmail.com"; //Information needs to be changed after each test cycle
                public static string Password = "password123!";
                public static string Company = "AS doo";
                public static string Address = "Brace Jerkovic";
                public static string City = "Belgrade";
                public static string PostalCode = "11000";
                public static string PhoneMobile = "00381641234567";
                public static string AliasAddress = "Brace Jerkovic";
                public static string DayOfBirth = "17";
                public static string Month = "5";
                public static string Year = "1991";
                public static string State = "1"; //Alabama

            }
        }

        public static class TestData
        {
            public static class SearchItems
            {
                public static string SearchTerm = "Printed dresses";
            }
        }
    }
}
