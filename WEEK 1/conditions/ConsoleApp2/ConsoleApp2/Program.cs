using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Speed ");
            int speed = int.Parse(Console.ReadLine());
            if(speed > 100)
            {
                Console.WriteLine(" OVER SPEED ");
            }
            else
            {
                Console.WriteLine(" Normal speed ");
            }

        }
    }
}
