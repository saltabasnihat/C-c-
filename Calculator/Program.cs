using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enter first number

            //repeat
            //enter operator(+,-,*,/)
            //enter next number
            //until '='

            //number 1(double)
            //number 2(double)
            //operator(string) 

            double number1 = 0;
            double number2 = 0;
            string operation = null;

            Console.Write("Enter the first number; ");
            number1 = double.Parse(Console.ReadLine());

            while (operation != "=")
            {
                Console.Write("Enter the operator: ");
                operation = Console.ReadLine();

                if (operation != "=")
                {
                    Console.Write("Enter the next number: ");
                    number2 = double.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case "+":
                            number1 += number2;
                            break;
                        case "-":
                            number1 -= number2;
                            break;
                        case "x":
                        case "*":
                            number1 *= number2;
                            break;
                        case "/":
                            number1 /= number2;
                            break;
                        default:
                            Console.WriteLine("Not a valid operator");
                            break;
                    }
                }
            }

            Console.WriteLine(number1);
            Console.Read();
        }
    }
}
