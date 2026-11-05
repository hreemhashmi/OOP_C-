using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2tasks
{
    internal class task2
    {//task2
        public class student
        {
            public string name;
            public float ecatm;
            public float fscm;
            public float matricm;
            public float aggri;

        }
        public student(student oldrecord)
        {
            name = oldrecord.name;



        }
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "hr";
            s1.ecatm = 380;
            s1.fscm = 700;
            s1.matricm = 1050;

        }

    
    }
}
