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

                newStudent.Name = Util.Console.Ask("Please input the students Name: ");

                newStudent.Grade = int.Parse(Util.Console.Ask("Please input the students Grade: "));

                newStudent.Birthday = Util.Console.Ask("Please input the students Birthday: ");

                newStudent.Address = Util.Console.Ask("Please input the students Address: ");

                newStudent.Phone = int.Parse(Util.Console.Ask("Please input the students Phone Number: "));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }

        }

        static void Import()
        {
            var importedStudent = new Student();
        }
        class Student
        {
            static public int Count = 0;

            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            private int phone;

            public Student()
            {

            }

            public Student(string name, int grade, string birthday, string address, int phone)
            {
                Name = name;
                Grade = grade;
                Birthday = birthday;
                Address = address;
                Phone = phone;
            }

            public int Phone
            {
                set { phone = value; }
            }
            public void SetPhone(int number)
            {
                phone = number;
            }

        }
    }
}