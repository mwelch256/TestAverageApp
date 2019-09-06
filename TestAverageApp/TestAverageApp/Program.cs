using System;

namespace TestAverageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What are your first test score");
            var responseFromUser1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What are your second test score");
            var responseFromUser2 = int.Parse(Console.ReadLine());

            Console.WriteLine("What are your third test score");
            var responseFromUser3 = int.Parse(Console.ReadLine());

            int average = (responseFromUser1 + responseFromUser2 + responseFromUser3) / 3;
            Console.WriteLine($"your average is {average}");
        }
    }
}
