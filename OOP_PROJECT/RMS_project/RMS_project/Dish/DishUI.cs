using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Dish
{
    internal class DishUI
    {

        private DishService service = new DishService();

        public void AddDish()
        {
            Console.Write(" Enter Dish Name : ");
            string name = Console.ReadLine();
            Console.Write(" Enter Price : ");
            float price = float.Parse(Console.ReadLine());

            DishModel dish = new DishModel(name, price);
            service.AddDish(dish);

            Console.WriteLine(" Dish Added Successfully ");
            Pause();
        }

        public void ViewDishes()
        {
            List<DishModel> dishes = service.GetAllDishes();

            Console.WriteLine(" Dish Name \t Price ");
            for (int i = 0; i < dishes.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + dishes[i].GetName() + " \t " + dishes[i].GetPrice());
            }
            Pause();
        }

        public void SearchDish()
        {
            Console.Write(" Enter Search Dish Name : ");
            string name = Console.ReadLine();

            DishModel dish = service.SearchDish(name);
            if (dish != null)
            {
                Console.WriteLine(" Dish Found ");
                Console.WriteLine(" Dish name : " + dish.GetName() + " Price : " + dish.GetPrice());
            }
            else
            {
                Console.WriteLine(" not found ");
            }
            Pause();
        }

        public void UpdateDish()
        {
            Console.Write(" Enter Dish Name You Want To Update : ");
            string oldName = Console.ReadLine();
            Console.Write(" Enter New Dish Name : ");
            string newName = Console.ReadLine();
            Console.Write(" Enter New Price : ");
            float newPrice = float.Parse(Console.ReadLine());

            if (service.UpdateDish(oldName, newName, newPrice) == true)
            {
                Console.WriteLine(" Record Successfully Updated ");
            }
            else
            {
                Console.WriteLine(" Dish Not Found ");
            }
            Pause();
        }

        public void DeleteDish()
        {
            Console.Write(" Enter Dish Name You Want To Delete : ");
            string name = Console.ReadLine();

            if (service.DeleteDish(name) == true)
            {
                Console.WriteLine(" Dish Deleted Successfully ");
            }
            else
            {
                Console.WriteLine(" Dish Not Found ");
            }
            Pause();
        }

        public void SortDishes(bool lowToHigh)
        {
            service.SortDishes(lowToHigh);
            if (lowToHigh == true)
            {
                Console.WriteLine(" ------- Sorted Dishes From Low To High ------- ");
            }
            else
            {
                Console.WriteLine(" ------- Sorted Dishes From High To Low ------- ");
            }
            ViewDishes();
        }

        private void Pause()
        {
            Console.WriteLine(" Press Enter to continue.....");
            Console.ReadLine();
        }
    }
}

