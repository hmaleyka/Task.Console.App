namespace ConsoleAppTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Student student = new Student();
            
            Group group = new Group();
            Group[] groups = new Group[] { 
            
            }; 
            
            while (check)
            { 
            Console.WriteLine("1.Create a group");
            Console.WriteLine("2.Show all students");
            Console.WriteLine("3.Add student");
            Console.WriteLine("4.Filter students by name");
            Console.WriteLine("5. Quit");

            int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        group.CreateGroup();
                        
                        break;
                    case 2:
                        student.ShowAllStudents();
                        break;
                    case 3:
                        Console.WriteLine("add the new student");
                        student.AddStudent();
                        break;
                    case 4:
                        Console.WriteLine("Enter the words to find student:");
                        string input = Console.ReadLine();
                        group.FilterByName(input);
                        break;
                     case 5:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct number");
                        break;



                }
            }

        }
    }
}