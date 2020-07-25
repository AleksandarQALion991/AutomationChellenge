using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAutomationChallenge.Services
{
    internal class RandomString
    {
        public static string GenerateRandomName(int length)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                char c = chars[random.Next(chars.Length)];
                sb.Append(c);
            }
            string randomString = sb.ToString();
            return randomString;
        }
    }
}
