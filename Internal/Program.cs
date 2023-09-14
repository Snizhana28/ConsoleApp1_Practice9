using ConsoleApp1_Practice9.Domain;
namespace ConsoleApp1_Practice9.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Boris", "Boiko", 19, "MIT"),
                new Student("Alex", "Brok", 20, "Oxford"),
                new Student("Mark", "Koval", 21, "MIT"),
                new Student("Daria", "Kostiuk", 22, "Oxford"),
                new Student("Sviat", "Bro", 23, "MIT"),
                new Student("Maria", "Mriy", 24, "Oxford") 
            };

            foreach (var student in students) 
            {
                Console.WriteLine(student);
            }

            var studentsWithNameBoris = students.Where(s => s.Name == "Boris");
            var studentsWithSurnameBro = students.Where(s => s.Surname.StartsWith("Bro"));
            var studentsOlderThan19 = students.Where(s => s.Age > 19);
            var studentsOlderThan20AndYoungerThan23 = students.Where(s => s.Age > 20 && s.Age < 23);
            var studentsFromMIT = students.Where(s => s.University == "MIT");
            var studentsFromOxfordOlderThan18 = students.Where(s => s.University == "Oxford" && s.Age > 18).OrderByDescending(s => s.Age);

            Console.WriteLine("\nStudents with name Boris:");
            Console.WriteLine(string.Join("\n", studentsWithNameBoris));

            Console.WriteLine("\nStudents with surname Bro:");
            Console.WriteLine(string.Join("\n", studentsWithSurnameBro));

            Console.WriteLine("\nStudents older than 19:");
            Console.WriteLine(string.Join("\n", studentsOlderThan19));

            Console.WriteLine("\nStudents older than 20 and younger than 23:");
            Console.WriteLine(string.Join("\n", studentsOlderThan20AndYoungerThan23));

            Console.WriteLine("\nStudents from MIT:");
            Console.WriteLine(string.Join("\n", studentsFromMIT));

            Console.WriteLine("\nStudents from Oxford older than 18:");
            Console.WriteLine(string.Join("\n", studentsFromOxfordOlderThan18));
        }
    }
}