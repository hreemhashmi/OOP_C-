using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurent_Management_system.Admin;

namespace Restaurent_Management_system
{
    internal class Restaurent
    {
        public void Start()
        {
            AdminUI a1 = new AdminUI();
           while(true)
            {
                string Option = MainMenu();
                if (Option == "1")
                {
                    a1.Login();
                // admin menu
                }
                else if (Option == "2")
                {
                    // customer menu
                }
                else if (Option == "3")
                {
                    // staff menu
                }
                else if (Option == "4")
                {
                    break;
                }
            }
            

        }
        public string MainMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("---Restaurent Management system---");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" ===========MAIN MNUE============ ");
            Console.WriteLine(" 1.Admin ");
            Console.WriteLine(" 2.Customer ");
            Console.WriteLine(" 3.Staff ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 4.Exit ");
            Console.ForegroundColor= ConsoleColor.White;
            string option = Console.ReadLine();
            return option;

        }
    }
}
