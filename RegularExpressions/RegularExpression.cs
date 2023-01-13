using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class RegularExpression
    {   
        public static void TestMethod(string[] arr,string pattern)
        {
            foreach (string str in arr)
            {
                if (Regex.IsMatch(str, pattern))
                {
                    Console.WriteLine("\n{0} is Valid", str);
                }
                else
                {
                    Console.WriteLine("\n{0} is Invalid", str);
                }
            }
        }
        //UC1 Validate First Name
        public static void ValidateFirstName()
        {
            string pattern = "^[a-zA-Z]{3,}$";
            string[] arr = { "shivani", "123abc","Shivani" };
            TestMethod(arr , pattern);
        }
        //UC2 Validate Last Name
        public static void ValidateLastName()
        {
            string pattern = "^[a-zA-Z]{3,}$";
            string[] arr = { "patel", "123abc", "Patel" };
            TestMethod(arr, pattern);
        }
        //UC3 Validate Email
        public static void ValidateEmail()
        {
            string pattern = "^[a-zA-Z0-9]+([.,-][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
            string[] arr = { "abc.xyz@bl.co.in", "abc@gmail.com", "abc.@bl.in" ,"@bl.co.in"};
            TestMethod(arr, pattern);
        }
    }
}
