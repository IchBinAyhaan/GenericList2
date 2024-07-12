
namespace Course
{
    internal class Course
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(string name, string surname, int age, string pin)
        {
       
            if (!students.Exists(s => s.PIN == pin))
            {
                Student newStudent = new Student(name, surname, age, pin);
                students.Add(newStudent);
                Console.WriteLine("Student added successfully.");
            }
            else
            {
                Console.WriteLine("A student with the same PIN already exists. Student not added.");
            }
        }

        public void RemoveStudent(string pin)
        {
           
            Student studentToRemove = students.Find(s => s.PIN == pin);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student with the provided PIN not found.");
            }
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
            }
        }

        public void SearchStudent(string pin)
        {
            Student foundStudent = students.Find(s => s.PIN == pin);
            if (foundStudent != null)
            {
                Console.WriteLine($"Student found: {foundStudent.Name} {foundStudent.Surname}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public int CountTotalStudents()
        {
            return students.Count;
        }

        public int CountStudentsAbove18()
        {
            return students.Count(s => s.Age > 18);
        }
    }
}
    

