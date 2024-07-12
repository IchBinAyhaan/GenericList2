using System;

namespace Course
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PIN { get; set; }

        public Student(string name, string surname, int age, string pin)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PIN = pin;
        }
    }
}
