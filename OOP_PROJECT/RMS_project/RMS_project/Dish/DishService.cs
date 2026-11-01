using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Dish
{
    internal class DishService
    {
      
        private DishRepo repo = new DishRepo();

        public void AddDish(DishModel dish)
        {
            repo.SaveInFile(dish);
        }

        public List<DishModel> GetAllDishes()
        {
            return repo.GetDishesFromFiles();
        }

        public DishModel SearchDish(string name)
        {
            List<DishModel> dishes = repo.GetDishesFromFiles();
            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].GetName() == name)
                {
                    return dishes[i];
                }
            }
            return null;
        }

        public bool UpdateDish(string oldName, string newName, float newPrice)
        {
            List<DishModel> dishes = repo.GetDishesFromFiles();
            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].GetName() == oldName)
                {
                    dishes[i].SetName(newName);
                    dishes[i].SetPrice(newPrice);
                    repo.SaveAllInFile(dishes);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteDish(string name)
        {
            List<DishModel> dishes = repo.GetDishesFromFiles();
            List<DishModel> remaining = new List<DishModel>();
            bool found = false;

            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].GetName() == name)
                {
                    found = true;
                }
                else
                {
                    remaining.Add(dishes[i]);
                }
            }

            if (found == true)
            {
                repo.SaveAllInFile(remaining);
            }
            return found;
        }

        public void SortDishes(bool lowToHigh)
        {
            List<DishModel> dishes = repo.GetDishesFromFiles();

            for (int i = 0; i < dishes.Count; i++)
            {
                for (int j = i + 1; j < dishes.Count; j++)
                {
                    bool swap = false;
                    if (lowToHigh == true && dishes[i].GetPrice() > dishes[j].GetPrice())
                    {
                        swap = true;
                    }
                    if (lowToHigh == false && dishes[i].GetPrice() < dishes[j].GetPrice())
                    {
                        swap = true;
                    }

                    if (swap == true)
                    {
                        DishModel temp = dishes[i];
                        dishes[i] = dishes[j];
                        dishes[j] = temp;
                    }
                }
            }
            repo.SaveAllInFile(dishes);
        }
    }
}

