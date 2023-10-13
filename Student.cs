using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    internal class Student
    {
        Student[] students;
        public string Name { get; set; }
        public string Surname { get; set; }
        private double _avgpoint;
        public double AvgPoint { 
            get 
            {
                return _avgpoint;
                    }
            set 
            { 
                if (value > 0 && value <= 100)
                { 
                    _avgpoint = value; 
                }  
                else
                {
                    Console.WriteLine("average point should be between 0 and 100");
                }
            } 
        }
        public void AddStudent()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("AvgPoint:");
            double avgpoint = double.Parse(Console.ReadLine());

            Student student1 = new Student()
            {
                Name = name,
                Surname = surname,
                AvgPoint = avgpoint
            };
            students = new Student[]
            {
                student1
            };
        }
           public void ShowAllStudents ()
            {

                foreach (var student in students)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Surname);
                    Console.WriteLine(student.AvgPoint);

                }
            }
}
 

    }

