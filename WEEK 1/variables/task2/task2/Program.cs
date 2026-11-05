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
            Console.WriteLine("Enter the Num 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 3: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 4: ");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Num 5: ");
            int n5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 6: ");
            int n6 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Num 7: ");
            int n7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num 8: ");
            int n8 = int.Parse(Console.ReadLine());
            int total1 = n1 + n2 + n3 + n4;
            int total2 = n5 * n6;
            int total3 = n7 - n8;
            int final = total1 + total2 + total3;
            Console.WriteLine(" the Final Sum is " + final);




        }
    }
}
