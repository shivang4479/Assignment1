using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            Console.WriteLine("enter first no.");
            int num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no.");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write($"Sum={num1 + num2}");
            Console.Write($"Diff={num1 - num2}");
            Console.Write($"Pro={num1 * num2}");
            Console.Write($"Qout={num1 / num2}");
            Console.Write($"Rem={num1 % num2}");

        }
    }
}
