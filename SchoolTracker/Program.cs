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

            
            var studentNames = new int[studentCount] ;
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)

            Console.Write("Please input the students name:");
            var studentName = Console.ReadLine();
            foreach (var studentName in studentNames)
            {

            }

            Console.Write("Please input the students grade:");
            var studentGrade = int.Parse(Console.ReadLine());
            
            foreach (studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }

        }
 

        public 
    }
}
