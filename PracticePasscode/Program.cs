using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePasscode
{
    class Program
    {
        static void Main(string[] args)
        {
            var userPasscode = "";

            while (userPasscode != "secret")
            Console.WriteLine("Please enter your password");
            userPasscode = Console.ReadLine();

            if (userPasscode != "secret")
            {
                Console.WriteLine("Wrong");
            }

            Console.WriteLine("You are authenticated.");
            
            
        }

    }
}
