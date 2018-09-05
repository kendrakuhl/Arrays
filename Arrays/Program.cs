using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create and initialize in a single line an array with the following values: 1, 1, 2, 3, 5, 8. 
             * Then loop through the array and print out each value. */
            var numbers = new int[] { 1, 1, 2, 3, 5, 8 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
            Console.Clear();

            /* Count how many odd numbers are in a list. */
            var oddNumberArray = new int[] { 1, 1, 2, 3, 5, 8 };
            var numberOfOddNumbers = 0; // This is my counter

            foreach (var number in oddNumberArray)
            {
                // If the modulus (aka remainder) is more than zero, add one to our counter
                if ((number % 2) > 0)
                {
                    Console.WriteLine(number);
                    numberOfOddNumbers++;
                }
            }

            Console.WriteLine($"Count of odd numbers: {numberOfOddNumbers}");

            Console.ReadLine();
            Console.Clear();

            /*Sum up all the negative numbers in a list. */
            var negativeNumberArray = new int[] { 1, -1, 2, 3, -5, 8 };
            var sumOfNegativeNumbers = 0; // This is my sum variable

            foreach (var number in negativeNumberArray)
            {
                // If the number is negative, then add to the sum variable
                if (number < 0)
                {
                    Console.WriteLine(number);
                    sumOfNegativeNumbers += number; 
                }
            }

            Console.WriteLine($"Sum of negative numbers: {sumOfNegativeNumbers}");

            Console.ReadLine();
            Console.Clear();

        }
    }
}
