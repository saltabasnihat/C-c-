using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                int max = int.MinValue;
                int min = int.MaxValue;
                int totalOdd = 0;
                int totalEven = 0;
                int sumOdd = 0;
                int sumEven = 0;
                int countOdd = 0;
                int countEven = 0;

                Console.WriteLine("Enter integers (press Enter without input to stop):");

                while (true)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                        break;

                    if (int.TryParse(input, out int number))
                    {
                        if (number > max)
                            max = number;

                        if (number < min)
                            min = number;

                        if (number % 2 == 0)
                        {
                            totalEven++;
                            sumEven += number;
                        }
                        else
                        {
                            totalOdd++;
                            sumOdd += number;
                        }
                    }
                }

                if (totalOdd == 0 && totalEven == 0)
                {
                    Console.WriteLine("You did not enter any integer");
                }
                else
                {
                    Console.WriteLine($"Maximum value: {max}");
                    Console.WriteLine($"Minimum value: {min}");
                    Console.WriteLine($"Total number of odd integers: {totalOdd}");
                    if (totalOdd > 0)
                    {
                        Console.WriteLine($"Sum of odd integers: {sumOdd}");
                        Console.WriteLine($"Average value of odd integers: {(double)sumOdd / totalOdd}");
                    }
                    Console.WriteLine($"Total number of even integers: {totalEven}");
                    if (totalEven > 0)
                    {
                        Console.WriteLine($"Sum of even integers: {sumEven}");
                        Console.WriteLine($"Average value of even integers: {(double)sumEven / totalEven}");
                    }
                }

                Console.Write("Play again (Y)? ");
                string playAgainInput = Console.ReadLine();
                playAgain = (playAgainInput.ToLower() == "y");


            }
        }
    }
}
