using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class RegularExpression
    {   //UC1 Validate First Name
        public static void ValidateFirstName()
        {
            string pattern = "^[a-zA-Z]{3,}$";
            string[] arr = { "shivani", "123abc","Shivani" };
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
    }
}
