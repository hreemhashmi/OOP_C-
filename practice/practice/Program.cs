using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class student
    {
        
        public string name;
        public int marks;
        public student(string n, int m)
        {
            name = n;
            marks = m;
        }
       
        public void display()
        {
            Console.WriteLine("name" +" "+ name);
            
            Console.WriteLine("Marks" + " " + marks);
        }
        public void updatemarks(int umarks)
        {
            marks += umarks;
        }
        public int gettotal()
        {
            return marks += 30;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name");
            string  n = Console.ReadLine();
            Console.WriteLine("marks");
            int m = int.Parse(Console.ReadLine());
            student s1 = new student(n ,m);
            student s2 = new student("abda" ,250);
            student s3 = new student("hreem",300);
            s2.name = "hmna";
            s1.display();
            s2.display();
            s3.display();


        

        }
    }
}
