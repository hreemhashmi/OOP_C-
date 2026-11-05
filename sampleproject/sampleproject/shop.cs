using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sampleproject.product;

namespace sampleproject
{
    internal class shop
    {
        //class for the driver code
        public void start()
        {
            productmodel p1 = new productmodel();
            Mainmnue();
        }
        public string Mainmnue()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("---Shop Management system---");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Product management ");
            Console.WriteLine("2. customer m");
            Console.WriteLine("3.order ");
            Console.WriteLine( "4. view irder history ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. exit " );
            Console.ForegroundColor = ConsoleColor.White;
            string option = Console.ReadLine();
            return option;
            

        }

    }
}
