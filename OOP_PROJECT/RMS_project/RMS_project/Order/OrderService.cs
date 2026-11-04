using RMS_project.Dish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Order
{
    internal class OrderService
    {
        private OrderRepo repo = new OrderRepo();
        private DishService dishService = new DishService();

        public bool PlaceOrder(string dishName, int quantity)
        {
            DishModel dish = dishService.SearchDish(dishName);
            if (dish == null || quantity <= 0)
            {
                return false;
            }
            double total = dish.GetPrice() * quantity;
            OrderModel order = new OrderModel(dishName, quantity, total, "pending");
            repo.SaveInFile(order);
            return true;
        }

        public List<OrderModel> GetAllOrders()
        {
            return repo.GetOrdersFromFile();
        }

        public List<OrderModel> GetCurrentOrders()
        {
            List<OrderModel> all = repo.GetOrdersFromFile();
            List<OrderModel> current = new List<OrderModel>();
            for (int i = 0; i < all.Count; i++)
            {
                string status = all[i].GetStatus();
                if (status == "pending" || status == "confirmed")
                {
                    current.Add(all[i]);
                }
            }
            return current;
        }

        public bool RemoveOrder(string dishName)
        {
            List<OrderModel> orders = repo.GetOrdersFromFile();
            List<OrderModel> remaining = new List<OrderModel>();
            bool found = false;

            for (int i = 0; i < orders.Count; i++)
            {
                if (found == false && orders[i].GetDishName() == dishName && orders[i].GetStatus() == "pending")
                {
                    found = true;
                }
                else
                {
                    remaining.Add(orders[i]);
                }
            }
            if (found == true)
            {
                repo.SaveAllInFile(remaining);
            }
            return found;
        }

        public bool UpdateQuantity(string dishName, int newQuantity)
        {
            DishModel dish = dishService.SearchDish(dishName);
            if (dish == null || newQuantity <= 0)
            {
                return false;
            }
            List<OrderModel> orders = repo.GetOrdersFromFile();
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].GetDishName() == dishName && orders[i].GetStatus() == "pending")
                {
                    orders[i].SetQuantity(newQuantity);
                    orders[i].SetTotal(dish.GetPrice() * newQuantity);
                    repo.SaveAllInFile(orders);
                    return true;
                }
            }
            return false;
        }

        public bool ChangeAllPending(string newStatus)
        {
            List<OrderModel> orders = repo.GetOrdersFromFile();
            bool found = false;
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].GetStatus() == "pending")
                {
                    orders[i].SetStatus(newStatus);
                    found = true;
                }
            }
            if (found == true)
            {
                repo.SaveAllInFile(orders);
            }
            return found;
        }

        public double CalculateBill()
        {
            List<OrderModel> current = GetCurrentOrders();
            double bill = 0;
            for (int i = 0; i < current.Count; i++)
            {
                bill = bill + current[i].GetTotal();
            }
            return bill;
        }

        public double GetDiscountPercent(double bill)
        {
            if (bill >= 5000)
            {
                return 10;
            }
            else if (bill >= 1000)
            {
                return 5;
            }
            return 0;
        }

        public double GetCouponPercent(string code)
        {
            if (code == "hm207")
            {
                return 7;
            }
            return 0;
        }
        public bool UpdateStatus(string dishName, string newStatus)
        {
            List<OrderModel> orders = repo.GetOrdersFromFile();
            for (int i = 0; i < orders.Count; i++)
            {
                string status = orders[i].GetStatus();
                if (orders[i].GetDishName() == dishName && status != "canceled" && status != "completed")
                {
                    orders[i].SetStatus(newStatus);
                    repo.SaveAllInFile(orders);
                    return true;
                }
            }
            return false;
        }

        public List<OrderModel> GetOrdersByStatus(string status)
        {
            List<OrderModel> all = repo.GetOrdersFromFile();
            List<OrderModel> result = new List<OrderModel>();
            for (int i = 0; i < all.Count; i++)
            {
                if (all[i].GetStatus() == status)
                {
                    result.Add(all[i]);
                }
            }
            return result;
        }

        public double GetTotalRevenue()
        {
            List<OrderModel> orders = repo.GetOrdersFromFile();
            double revenue = 0;
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].GetStatus() != "canceled")
                {
                    revenue = revenue + orders[i].GetTotal();
                }
            }
            return revenue;
        }
       

    }

}

