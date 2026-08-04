using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class2
    {
        static void Main(String[] args){
            Console.Write("enter no");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.Write("Positive no.");
            }
            else if(num<0)
            {
                Console.Write("negative no.");
            }
            else
            {
                Console.Write("zero");
            }
        }
            
    }
}
