using System;
using System.Linq;

namespace Lab1
{
    public class LINQExample
    {
        public static void PerformLINQOperations(int[] numbers)
        {
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            var sum = numbers.Sum();

            var maxNumber = numbers.Max();

            var average = numbers.Average();

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nSum of all numbers: " + sum);
            Console.WriteLine("Maximum number: " + maxNumber);
            Console.WriteLine("Average of all numbers: " + average);
        }
    }
}
