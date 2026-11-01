using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Dish
{
    internal class DishRepo
    {
        private readonly string file = "dish.txt";
        public DishRepo() {
            if (!File.Exists(file))
            {
                SaveInFile(new DishModel("biryani", 270));
                SaveInFile(new DishModel("burger", 200));
                SaveInFile(new DishModel("juice", 120));
                SaveInFile(new DishModel("pizza", 550));
            }

        }
        public void SaveInFile(DishModel dish)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(dish.ToString());
            }
        }
        public List<DishModel> GetDishesFromFiles()
        {
            List<DishModel> dishModels = new List<DishModel>();
            if (!File.Exists(file))
            {
                return dishModels;
            }
            using (StreamReader stream = new StreamReader(file))
            {
                string line = "";
                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string dishname = parts[0];
                    double price = double.Parse(parts[1]);
                    DishModel dishModel = new DishModel(dishname,price);
                    dishModels.Add(dishModel);
                }
            }
            return dishModels;
        }
        public void SaveAllInFile(List<DishModel> dishes)
        {
            using (StreamWriter stream = new StreamWriter(file, false))
            {
                for (int i = 0; i < dishes.Count; i++)
                {
                    stream.WriteLine(dishes[i].ToString());
                }

            }
        }
    }
}
