using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Dish
{
    internal class DishModel
    {
        private string name;
        private double price;
        public DishModel()
        {

        }
        public DishModel(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public string GetName()
        {
         return this.name;
        }
        public void SetName(string name)
        {
            this.name =name;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public override string ToString()
        {
            return $"{name},{price}";
        }


    }
}
