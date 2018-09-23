using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using a list you do not need to specify the amoun in the list
            var studentNames = new List<string>();
            var studentGrades = new List<int>();
            var adding = true;

            while (adding)
            {
                Console.Write("Please input the students name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write("Please input the students grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }

        }
    class Student
        {
            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            public int Phone;

        }
    }
}