using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class3
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            if (marks >= 91)
            {
                Console.WriteLine("Grade: O");
            }
            else if (marks >= 81)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (marks >= 71)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 61)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (marks >= 51)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
