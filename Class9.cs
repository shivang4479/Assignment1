using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine(" MENU ");
                Console.WriteLine("1. Check Even/Odd");
                Console.WriteLine("2. Find Largest of Three Numbers");
                Console.WriteLine("3. Calculate Factorial");
                Console.WriteLine("4. Exit");

                Console.Write("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Number: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 2 == 0)
                            Console.WriteLine("Even");
                        else
                            Console.WriteLine("Odd");
                        break;

                    case 2:
                        Console.Write("Enter First Number: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("Enter Second Number: ");
                        int b = int.Parse(Console.ReadLine());

                        Console.Write("Enter Third Number: ");
                        int c = int.Parse(Console.ReadLine());

                        if (a >= b && a >= c)
                            Console.WriteLine("Largest = " + a);
                        else if (b >= a && b >= c)
                            Console.WriteLine("Largest = " + b);
                        else
                            Console.WriteLine("Largest = " + c);

                        break;

                    case 3:
                        Console.Write("Enter Number: ");
                        int n = int.Parse(Console.ReadLine());

                        int fact = 1;

                        for (int i = 1; i <= n; i++)
                        {
                            fact = fact * i;
                        }

                        Console.WriteLine("Factorial = " + fact);
                        break;

                    case 4:
                        Console.WriteLine("Program Exited");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}
