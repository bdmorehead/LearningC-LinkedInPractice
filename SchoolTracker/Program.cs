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
            Console.Write("How many students are in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            
            var studentNames = new string[studentCount] ;
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Please input the students name: ");
                studentNames[i] = Console.ReadLine();

                Console.Write("Please input the students grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }

        }
    }
}
