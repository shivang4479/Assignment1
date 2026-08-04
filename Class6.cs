using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class6
    {
        static void Main7(string[] args)
{
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial = " + fact);
        }
    }
}