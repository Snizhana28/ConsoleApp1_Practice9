using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Practice9.Domain
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string University { get; set; }

        public Student() { }
        public Student(string name, string surname, int age, string university)
        {
            Name = name;
            Surname = surname;
            Age = age;
            University = university;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}, University: {University}";
        }
    }
}
