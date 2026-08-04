using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter roll no");
            int roll=int.Parse (Console.ReadLine());

            Console.WriteLine("enter marks");
            double mark = double.Parse(Console.ReadLine());

            Console.Write($"your name: {name}");
            Console.Write($"your roll no.:{roll}");
            Console.Write($"your marks: {mark}");
        }
    }
}
