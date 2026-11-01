using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Order
{
    internal class OrderRepo
    {

        private readonly string file = "orders.txt";

        public OrderRepo() { }

        public void SaveInFile(OrderModel order)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(order.ToString());
            }
        }

        public List<OrderModel> GetOrdersFromFile()
        {
            List<OrderModel> orderModels = new List<OrderModel>();

            if (!File.Exists(file))
            {
                return orderModels;
            }

            using (StreamReader stream = new StreamReader(file))
            {
                string line = "";
                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string dishName = parts[0];
                    int quantity = int.Parse(parts[1]);
                    double total = double.Parse(parts[2]);
                    string status = parts[3];

                    OrderModel orderModel = new OrderModel(dishName, quantity, total, status);
                    orderModels.Add(orderModel);
                }
            }
            return orderModels;
        }

        public void SaveAllInFile(List<OrderModel> orders)
        {
            using (StreamWriter stream = new StreamWriter(file, false))
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    stream.WriteLine(orders[i].ToString());
                }
            }
        }
    }
}

