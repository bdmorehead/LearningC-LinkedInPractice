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
            // Using a list, when you do not need to specify the amount in the list
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.Write("Please input the students Name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Please input the students Grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.Write("Please input the students Birthday: ");
                newStudent.Birthday = Console.ReadLine();

                Console.Write("Please input the students Address: ");
                newStudent.Address = Console.ReadLine();

                Console.Write("Please input the students Phone Number: ");
                newStudent.SetPhone(int.Parse(Console.ReadLine()));

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }

        }
    class Student
        {
            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            private int phone;

            public void SetPhone(int number)
            {
                Phone = number;
            }

        }
    }
}