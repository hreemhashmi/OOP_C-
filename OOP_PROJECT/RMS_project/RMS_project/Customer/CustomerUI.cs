using RMS_project.Dish;
using RMS_project.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Customer
{
    internal class CustomerUI
    {
        private DishUI dishUI = new DishUI();
        private OrderUI orderUI = new OrderUI();

        public void CustomerMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("============ WELCOME TO HM HOME KITCHEN ============ ");
                Console.WriteLine("1.  View Menu ");
                Console.WriteLine("2.  Search Dish ");
                Console.WriteLine("3.  Order Food ");
                Console.WriteLine("4.  View Current Order ");
                Console.WriteLine("5.  Remove Item From Order ");
                Console.WriteLine("6.  Update Quantity ");
                Console.WriteLine("7.  Calculate Bill ");
                Console.WriteLine("8.  Discount ");
                Console.WriteLine("9.  Confirm Order ");
                Console.WriteLine("10. Cancel Order ");
                Console.WriteLine("11. View Order History ");
                Console.WriteLine("12. Exit ");
                Console.Write(" Choose : ");
                string option = Console.ReadLine();

                if (option == "1")
                { dishUI.ViewDishes();
                }
                else if (option == "2")
                { dishUI.SearchDish();
                }
                else if (option == "3") 
                { orderUI.PlaceOrder();
                }
                else if (option == "4")
                { orderUI.ViewCurrentOrders(); 
                }
                else if (option == "5") 
                { orderUI.RemoveOrder();
                }
                else if (option == "6") 
                { orderUI.UpdateQuantity(); 
                }
                else if (option == "7") 
                { orderUI.ShowBill();
                }
                else if (option == "8")
                { orderUI.ShowDiscount();
                }
                else if (option == "9") 
                { orderUI.ConfirmOrder();
                }
                else if (option == "10")
                { orderUI.CancelOrder(); 
                }
                else if (option == "11")
                { orderUI.OrderHistory();
                }
                else if (option == "12") 
                { break;
                }
                else
                {
                    Console.WriteLine(" invalid option ");
                    Console.ReadLine();
                }
            }
        }
    }

}

