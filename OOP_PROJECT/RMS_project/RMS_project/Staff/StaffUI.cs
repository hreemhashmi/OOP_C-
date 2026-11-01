using RMS_project.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Staff
{
    internal class StaffUI
    {
       
        private OrderUI orderUI = new OrderUI();

        public void StaffMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("============ Staff Menu ============ ");
                Console.WriteLine("1. View All Orders ");
                Console.WriteLine("2. Process Order ");
                Console.WriteLine("3. Mark Order As Completed ");
                Console.WriteLine("4. View Pending Orders ");
                Console.WriteLine("5. View Revenue Summary ");
                Console.WriteLine("6. Exit ");
                Console.Write(" Choose : ");
                string option = Console.ReadLine();

                if (option == "1") { orderUI.OrderHistory(); }
                else if (option == "2") { orderUI.ChangeStatus("processing"); }
                else if (option == "3") { orderUI.ChangeStatus("completed"); }
                else if (option == "4") { orderUI.ViewPendingOrders(); }
                else if (option == "5") { orderUI.ShowRevenue(); }
                else if (option == "6") { break; }
                else
                {
                    Console.WriteLine(" invalid option ");
                    Console.ReadLine();
                }
            }
        }
    }
}

