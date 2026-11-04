using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS_project.Dish;
using RMS_project.Order;
using RMS_project.Employee;
namespace RMS_project.Admin

{
    internal class AdminUI
    {
        private AdminService service = new AdminService();
        private DishUI dishUI = new DishUI();
        private OrderUI orderUI = new OrderUI();
        private EmployeeUI employeeUI = new EmployeeUI();

        public void Login()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine("Login Attempt " + (i + 1));
                Console.Write("Enter User Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Pasword: ");
                string password = Console.ReadLine();
                if (service.Login(name, password) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Login Succesful! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    AdminMenu();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Username or Password ");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to Countinue...");
                    Console.ReadKey();
                }
            }
        }
        public void AdminMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ========= Admin Menu ========= ");
                Console.WriteLine("1.  Add Dishes ");
                Console.WriteLine("2.  View All Dishes ");
                Console.WriteLine("3.  Search Dish ");
                Console.WriteLine("4.  Update Dish ");
                Console.WriteLine("5.  Delete Dish ");
                Console.WriteLine("6.  Sort Dishes (Low to High) ");
                Console.WriteLine("7.  Sort Dishes (High to Low) ");
                Console.WriteLine("8.  View Total Revenue ");
                Console.WriteLine("9.  View Order History ");
                Console.WriteLine("10. Staff Management ");
                // lab evaluation
                Console.WriteLine("11. Show all ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("12. Exit ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Choose Option ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    // add dishes
                    dishUI.AddDish();

                }
                else if (option == "2")
                {
                    // view all dishes
                    dishUI.ViewDishes();


                }
                else if (option == "3")
                {
                    //search dish 
                    dishUI.SearchDish();
                }
                else if (option == "4")
                {
                    dishUI.UpdateDish();
                }
                else if (option == "5")
                {
                    dishUI.DeleteDish();
                }
                else if (option == "6")
                {
                    dishUI.SortDishes(true);
                }
                else if (option == "7")
                {
                    dishUI.SortDishes(false);

                }
                else if (option == "8")
                {
                    orderUI.ShowRevenue();
                }
                else if (option == "9")
                {
                    orderUI.OrderHistory();
                }
                else if (option == "10")
                {
                    employeeUI.EmployeeMenu();

                }
                
                // lab evaluation
                else if (option == "11")
                {
                    dishUI.showAll();
                }
                else if (option == "12")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid Choice ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
            }
        }
      
    }
}
