using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Country ");
            string name = Console.ReadLine();
            Console.WriteLine(" Ticket Price : " );
            float price = int.Parse( Console.ReadLine() );
            float discount;

            if (name == "irland")
            {
                discount = price * (0.1f);

            }
            else 
            {
              discount = price * (0.05f) ;
            }
            float final = price - discount;
            Console.WriteLine(final);



        }
    }
}
