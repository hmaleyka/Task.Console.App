using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    internal class Group
    {
        Group[] groups;
        private string _no;
        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if(CheckNoValue(value))
                {
                    _no = value;
                }
            }
        }
        private int _studentvalue;
        public int StudentLimit { get {
                return _studentvalue;
            } set 
            {
            if(value>=5 && value <=18)
                {
                    _studentvalue = value;
                }
            } 
        }
        public bool CheckNoValue(string no)
        {
            if (char.IsUpper(no[0]) && char.IsUpper(no[1]) && no.Length == 5)
            {
                for (int i =2; i < no.Length; i++)
                {
                    if (!char.IsDigit(no[i]))
                    {
                        return false;
                    }
                }
            return true;
            }
            return false;
        }
       Student[] students;
             public void CreateGroup()
        {
              Console.WriteLine("No:");
              string no = Console.ReadLine();

            Console.WriteLine("Student Limit:");
              int limit = int.Parse(Console.ReadLine());
              Group group = new Group()
              {
                No = no,
                StudentLimit=limit
              };
              groups = new Group[]
              {
                group
              };

        }

        public void AddStudent(Student student)
        {
            Console.WriteLine("enter the data for adding new student");
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }


        public Student[] FilterByName(string research)
        {
 
            
            Student[] filterStudent = new Student[0];
            for (int i = 0; i < filterStudent.Length; i++)
            {
                if ($"{students[i].Name} {students[i].Surname}".ToLower().Contains(research))
                {
                    Array.Resize (ref filterStudent, filterStudent.Length + 1);
                    filterStudent[filterStudent.Length - 1] = students[i];
                }
            }
                return filterStudent;
        } 
    }

    
}
