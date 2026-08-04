using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;

                case 4:
                    Console.WriteLine("Result = " + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
