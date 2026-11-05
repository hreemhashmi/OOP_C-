using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hello word
            // Console.WriteLine(" hello world ");

            //task2

            // Console.WriteLine(" value is ");
            //int value = int.Parse(Console.ReadLine());
            //int sum = value;
            // Console.WriteLine(" the sum is " + value);

            // task3
            //string variable = " i am string ";
            // Console.WriteLine(" the value is ");
            // Console.WriteLine(variable);
            //task4

            // char variable = 'a';
            // Console.WriteLine("the character is :");
            // Console.WriteLine(variable);
            // task5
            //float variable = 1.3f;
            //Console.WriteLine(variable);
            //task6
            // double variable = 1.23f;
            // Console.WriteLine(variable);
            //task7
            // Console.WriteLine(" enter the length ");
            // int lentgh = int.Parse(Console.ReadLine());
            // Console.WriteLine(" enter the width ");
            // int width = int.Parse(Console.ReadLine());
            // int area = lentgh * width;
            //  Console.WriteLine(" area " + area);
            // task8
            // Console.WriteLine(" enter value ");
            // float value = float.Parse(Console.ReadLine());
            //  Console.WriteLine(" the value is " + value);
            // task9
            //Console.WriteLine(" enter the number ");
            // int num = int.Parse(Console.ReadLine());
            // if(num >50)
            // {
            //   Console.WriteLine(" passed ");
            // }
            // else
            // {
            //   Console.WriteLine(" failed ");

            // }
            // task10
            // for(int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(" welcome jacks ");
            //  }
            //task11
            // int num;
            // int sum = 0;
            // Console.WriteLine(" enter num :");
            //  num  =int.Parse(Console.ReadLine());
            // while( num != -1)
            // {
            //   sum = sum + num;
            //  Console.WriteLine(" enter num :");
            // num = int.Parse(Console.ReadLine());

            //  }
            // Console.WriteLine(" the total sum is " + sum);
            // task 12
            //  Console.WriteLine(" Temprature 1: ");
            // int temp1 = int.Parse(Console.ReadLine());
            //  Console.WriteLine(" Temprature 2: ");
            //  int temp2 = int.Parse(Console.ReadLine());
            // int difference = temp1 - temp2;
            // if (difference > 10)
            // {
            //  Console.WriteLine("Difference is too big ");
            //  Console.WriteLine(" Programm ends ");



            //  }
            //task13
            //  int num;
            //  int sum = 0;
            // do
            //  {
            //    Console.Write("enter number : ");
            //  num = int.Parse(Console.ReadLine());
            //  sum = sum + num;
            // }
            // while (num != -1);
            // sum = sum + 1;
            // Console.WriteLine(" the total sum is " + sum);
            //TASK14
            // int[] number = new int[3];
            // for(int i = 0;i <3; i++)
            //  {
            //  Console.WriteLine(" enter number" , i);
            //  number[i] = int.Parse(Console.ReadLine());
            //  }
            //  int largest = 0;
            //  for (int i = 0; i < 3; i++)
            //  {

            // if (number[i] > largest)
            //  {
            //     largest = number[i];

            //  }
            //   }
            //  Console.WriteLine(" the laargest is " + largest);
            // task 15
            //int age = int.Parse(Console.ReadLine());
            //double price = double.Parse(Console.ReadLine());
            //int toyunit = int.Parse(Console.ReadLine());
            //double savedmoney = 0;
            //nt toycount = 0;
            //ouble money =10;
            //or (int year = 1; year <= age; year++)
            //
            //   if (year % 2 == 0)
            // {
            //    savedmoney = savedmoney + money;
            //    money = money + 10;
            //}
            //else
            //
            //   toycount++;
            //}
            // }
            // double toymoney = toycount * toyunit;
            //int brothermoney = age / 2;
            // double totalmoney = savedmoney + toymoney - brothermoney;
            // if (totalmoney >= price)
            // {
            //    double remain = totalmoney - price;
            //    Console.WriteLine(" yes! " + remain);
            //}
            //else
            // {
            //     double insufficient = price - totalmoney;
            //     Console.WriteLine(" no! " + insufficient);
            //task16

            //int num1;
            //int num2;
            //Console.WriteLine(" enter1 num ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(" enter2 num ");
            //num2 = int.Parse(Console.ReadLine());
            //int result = add(num1, num2);
            //   Console.WriteLine(" the sum is " + result);
            //}

            //static int add(int n1, int n2)
            // {
            //     return n1 + n2;
            // }
            //task17
            //ng path = "c\\oop  \\ week1\\file.txt"; 
            //f(File.Exists(path))
            //{
            // StreamReader filevariable = new StreamReader(path);
            //    string record;
            //     while((record = filevariable.ReadLine()) != null)
            //    {
            //         Console.WriteLine(record);
            //
            //     }
            //    filevariable.Close();

            //  }
            //    else
            //    {
            //        Console.WriteLine(" no exist ");
            //    }
            //task18
            //    string path1= "c\\oop  \\ week1\\file.txt";
            //    StreamWriter filevariable1= new StreamWriter(path, true);
            //     filevariable1.WriteLine("hello");     
            //    filevariable1.Flush();   
            //    filevariable1.Close();  
            // task important
            // reader
            StreamWriter sw = new StreamWriter("student.txt");
            Console.WriteLine(" enter no of student : ");
            int stu = int.Parse(Console.ReadLine());

            for (int i = 0; i < stu; i++)
            {
                Console.WriteLine(" enter name ");
                string name = Console.ReadLine();
                Console.WriteLine(" entr age ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine(" enter city ");
                string city = Console.ReadLine();
                sw.WriteLine(name);
                sw.WriteLine(age);
                sw.WriteLine(city);
            }
            sw.Close();
            StreamReader se = new StreamReader("student.txt");
            string line;
            while((line = se.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            se.Close();
                
                
                

          

                


        }

    }
}
 

