using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("How old are you?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var monthOfBirth = TryAnswer();

            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"Your birth month is {monthOfBirth}");
            

            if (monthOfBirth == "march")
            {
                Console.WriteLine("You are an Aries!");
            }
            if (monthOfBirth == "june")
            {
                Console.WriteLine("You are Taurus!");
            }
            if (monthOfBirth == "august")
            {
                Console.WriteLine("You are Sagitarious!");
            }

        }
        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again");
                return Console.ReadLine();
            }
            return answer;

        }
    }
    }
}
