using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Order
{
    internal class OrderModel
    { 

            private string dishName;
            private int quantity;
            private double total;
            private string status;

            public OrderModel()
            {
            }

            public OrderModel(string dishName, int quantity, double total, string status)
            {
                this.dishName = dishName;
                this.quantity = quantity;
                this.total = total;
                this.status = status;
            }

            public string GetDishName()
            {
                return this.dishName;
            }

            public void SetDishName(string dishName)
            {
                this.dishName = dishName;
            }

            public int GetQuantity()
            {
                return this.quantity;
            }

            public void SetQuantity(int quantity)
            {
                this.quantity = quantity;
            }

            public double GetTotal()
            {
                return this.total;
            }

            public void SetTotal(double total)
            {
                this.total = total;
            }

            public string GetStatus()
            {
                return this.status;
            }

            public void SetStatus(string status)
            {
                this.status = status;
            }

            public override string ToString()
            {
                return $"{dishName},{quantity},{total},{status}";
            }
        }
    }

