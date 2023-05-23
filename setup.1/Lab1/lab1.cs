using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class lab1
    {
        static void Main(int[] args)
        {
            string name;

            Console.Write("What is your name?");

            name = int.Parse(Console.ReadLine());

            Console.Write("Hello " + name + "\n");

            Console.Write("Thank you for letting me learning C#. Press any key to exit program!");
            Console.Read();
        }
    }
}
