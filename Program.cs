namespace ConsoleApp1_Practice9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array =  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 50, 22, 13, 54, 50, 60, 70, 89, 16 };

            var allArray = from a in array
                           select a;

            var evenArray = from a in array
                            where a % 2 == 0
                            select a;

            var oddArray = from a in array
                           where a % 2 == 1
                           select a;

            var moreArray = from a in array
                            where a > 50
                            select a;

            var rangeArray = from a in array
                             where a > 10 && a < 50
                             select a;

            var sevenArray = from a in array
                             where a % 7 == 0
                             orderby a ascending
                             select a;
            
            var eightArray = from a in array
                             where a % 8 == 0
                             orderby a descending
                             select a;

            Console.WriteLine("The entire array is integer:");
            Console.WriteLine(string.Join(", ", allArray));

            Console.WriteLine("\nEven numbers");
            Console.WriteLine(string.Join(", ", evenArray));

            Console.WriteLine("\nOdd numbers:");
            Console.WriteLine(string.Join(", ", oddArray));

            Console.WriteLine($"\nThe value is greater than the specified value (50):");
            Console.WriteLine(string.Join(", ", moreArray));

            Console.WriteLine($"\nNumbers in the specified range (a > 10 && a < 50):");
            Console.WriteLine(string.Join(", ", rangeArray));

            Console.WriteLine("\nNumbers in multiples of seven (sorted in ascending order):");
            Console.WriteLine(string.Join(", ", sevenArray));

            Console.WriteLine("\nNumbers in multiples of eight (sorted in descending order):");
            Console.WriteLine(string.Join(", ", eightArray));

        }
    }
}