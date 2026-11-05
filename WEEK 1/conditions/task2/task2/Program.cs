using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Temprature 1: ");
            int temp1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Temprature 2: ");
            int temp2 = int.Parse(Console.ReadLine());
            int difference = temp1 - temp2;
            if(difference > 10)
            {
                Console.WriteLine("Difference is too big ");
                Console.WriteLine(" Programm ends ");

            }
            else
            {
                Console.WriteLine(" programm ends ");
            }
        }
    }
}
