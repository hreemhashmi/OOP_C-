using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter the number of polygen sides ");
            
           int n = int.Parse(Console.ReadLine());
            int total = (n - 2) * 180;
              
            Console.WriteLine("the sum is " + total);



        }
    }
}
