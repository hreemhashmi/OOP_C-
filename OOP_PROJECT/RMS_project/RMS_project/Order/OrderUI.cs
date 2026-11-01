using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Order
{
    internal class OrderUI
    {
        private OrderService service = new OrderService();

        public void PlaceOrder()
        {
            Console.Write(" How many items do you want to order : ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write(" Place Order (dish name) : ");
                string name = Console.ReadLine();
                Console.Write(" Dish Quantity : ");
                int quantity = int.Parse(Console.ReadLine());

                if (service.PlaceOrder(name, quantity) == false)
                {
                    Console.WriteLine(" Item not found or invalid quantity ");
                }
            }
            Console.WriteLine(" Thanks for your order ");
            Pause();
        }

        public void ViewCurrentOrders()
        {
            Console.WriteLine(" ==== Current Orders ==== ");
            PrintOrders(service.GetCurrentOrders());
            Pause();
        }

        public void OrderHistory()
        {
            Console.WriteLine(" ========== Order History ========== ");
            PrintOrders(service.GetAllOrders());
            Pause();
        }

        public void RemoveOrder()
        {
            Console.Write(" Enter item name you want to remove : ");
            string name = Console.ReadLine();

            if (service.RemoveOrder(name) == true)
            {
                Console.WriteLine(" Order item removed ");
            }
            else
            {
                Console.WriteLine(" Item not found ");
            }
            Pause();
        }

        public void UpdateQuantity()
        {
            Console.Write(" Enter item name you want to update : ");
            string name = Console.ReadLine();
            Console.Write(" Enter new quantity : ");
            int quantity = int.Parse(Console.ReadLine());

            if (service.UpdateQuantity(name, quantity) == true)
            {
                Console.WriteLine(" Quantity Successfully Updated ");
            }
            else
            {
                Console.WriteLine(" Item not found or invalid quantity ");
            }
            Pause();
        }

        public void ShowBill()
        {
            double bill = service.CalculateBill();
            Console.WriteLine(" ---------- Bill ---------- ");
            PrintOrders(service.GetCurrentOrders());
            Console.WriteLine(" Your Bill IS: RS. " + bill);
            Pause();
        }

        public void ShowDiscount()
        {
            double bill = service.CalculateBill();
            double percent = service.GetDiscountPercent(bill);

            Console.Write(" Enter coupon code (press Enter to skip) : ");
            string code = Console.ReadLine();
            double couponPercent = service.GetCouponPercent(code);
            if (couponPercent > percent)
            {
                percent = couponPercent;
            }

            double discount = bill * percent / 100;
            Console.WriteLine(" Total Bill : " + bill);
            Console.WriteLine(" Discount (" + percent + "%) : " + discount);
            Console.WriteLine(" Final Bill : " + (bill - discount));
            Pause();
        }

        public void ConfirmOrder()
        {
            if (service.ChangeAllPending("confirmed") == true)
            {
                Console.WriteLine(" Your order is confirmed ");
            }
            else
            {
                Console.WriteLine(" No pending order found ");
            }
            Pause();
        }

        public void CancelOrder()
        {
            if (service.ChangeAllPending("canceled") == true)
            {
                Console.WriteLine(" Your order is canceled ");
            }
            else
            {
                Console.WriteLine(" No pending order found ");
            }
            Pause();
        }

        private void PrintOrders(List<OrderModel> orders)
        {
            Console.WriteLine("Dish\tQuantity\tTotal\tStatus");
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + orders[i].GetDishName() + "\t" + orders[i].GetQuantity()
                    + "\t" + orders[i].GetTotal() + "\t" + orders[i].GetStatus());
            }
            if (orders.Count == 0)
            {
                Console.WriteLine(" No orders found ");
            }
        }

        private void Pause()
        {
            Console.WriteLine(" Press Enter to continue.....");
            Console.ReadLine();
        }
        public void ViewPendingOrders()
        {
            Console.WriteLine(" ---------- Pending Orders ---------- ");
            PrintOrders(service.GetOrdersByStatus("pending"));
            Pause();
        }

        public void ChangeStatus(string newStatus)
        {
            Console.Write(" Enter order (dish) name : ");
            string name = Console.ReadLine();

            if (service.UpdateStatus(name, newStatus) == true)
            {
                Console.WriteLine(" Order status is now " + newStatus);
            }
            else
            {
                Console.WriteLine(" Order not found or already completed/canceled ");
            }
            Pause();
        }

        public void ShowRevenue()
        {
            Console.WriteLine(" ======== TOTAL REVENUE ======= ");
            Console.WriteLine(" Total Revenue : Rs. " + service.GetTotalRevenue());
            Console.WriteLine(" Total Orders  : " + service.GetAllOrders().Count);
            Pause();
        }
    }
}

