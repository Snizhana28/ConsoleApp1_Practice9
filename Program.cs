namespace ConsoleApp1_Practice9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] cities = { "Odessa", "Neidek", "Amsterdam", "Necropolis", "Athens" };

            Console.WriteLine("All cities:");
            Console.WriteLine(string.Join(", ", cities));

            var citiesLenght = cities.Where(x => x.Length == 6);
            var citiesStartA = cities.Where(x => x.StartsWith("A"));
            var citiesEndM = cities.Where(x => x.EndsWith("m"));
            var citiesStartNEndK = cities.Where(x => x.StartsWith("N") && x.EndsWith("k"));
            var citiesStartNe = cities.Where(x => x.StartsWith("Ne")).OrderByDescending(x => x);


            Console.WriteLine("\nGet the cities with the length of the name equal to the given one:");
            Console.WriteLine(string.Join(", ", citiesLenght));

            Console.WriteLine("\nGet the cities whose names begin with the letter A:");
            Console.WriteLine(string.Join(", ", citiesStartA));

            Console.WriteLine($"\nGet cities with names ending with letter M:");
            Console.WriteLine(string.Join(", ", citiesEndM));

            Console.WriteLine($"\nGet the cities whose names begin with the letter N and end with the letter K:");
            Console.WriteLine(string.Join(", ", citiesStartNEndK));

            Console.WriteLine("\nGet the cities whose names start with Ne. Sort the result in descending order:");
            Console.WriteLine(string.Join(", ", citiesStartNe));
        }
    }
}