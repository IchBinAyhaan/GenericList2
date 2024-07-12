namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();

            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. Display all students");
                Console.WriteLine("4. Search for a student");
                Console.WriteLine("5. Count total students");
                Console.WriteLine("6. Count students above 18");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student surname: ");
                        string surname = Console.ReadLine();
                        Console.Write("Enter student age: ");
                        int age;
                        if (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Invalid age. Please enter a number.");
                            continue;
                        }
                        Console.Write("Enter student PIN: ");
                        string pin = Console.ReadLine();
                        course.AddStudent(name, surname, age, pin);
                        break;
                    case 2:
                        Console.Write("Enter student PIN to remove: ");
                        string pinToRemove = Console.ReadLine();
                        course.RemoveStudent(pinToRemove);
                        break;
                    case 3:
                        course.DisplayAllStudents();
                        break;
                    case 4:
                        Console.Write("Enter student PIN to search: ");
                        string pinToSearch = Console.ReadLine();
                        course.SearchStudent(pinToSearch);
                        break;
                    case 5:
                        Console.WriteLine($"Total number of students: {course.CountTotalStudents()}");
                        break;
                    case 6:
                        Console.WriteLine($"Number of students above 18: {course.CountStudentsAbove18()}");
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        break;
                }
            } while (choice != 7);
        }
    }
}
