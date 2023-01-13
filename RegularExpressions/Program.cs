using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program");
            RegularExpression.ValidateFirstName();
            Console.WriteLine("---------------------------");
            RegularExpression.ValidateLastName();
            Console.WriteLine("---------------------------");
            Console.ReadLine();
        }
    }
}
