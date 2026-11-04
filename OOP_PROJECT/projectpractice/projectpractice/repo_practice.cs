using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projectpractice
{
    internal class repo_practice
    {
        pivate readonly string file = "dish.txt";
        public repo_practice()
        {

        }
        public void saveinfile(DishModel dish)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(dish.ToString());
            }
        }
        public List<DishModel> getfromfiles()

        {
            List<DishModel> dishmodels = new lis<DishModels>();
            if (!File.Exists(file))
            {
                return dishmodels;
            }
            using (StreamReader stream = new StreamReader(file))
            {
                string line = "";
                while ((line = stream.ReadLine()) != null)
                {
                    string[] patrs = line.Split(',');
                    string name = patrs[0];
                    string price = patrs[1];
                    Dishmodel dishmodels = new DishModel(name, price);
                    Dishmodels.add(dishmodels);
                }
            }
            return dishmodels;
        }
        public void saveinallfiles(List<DishModel> dishes);
        {
        using (StreamWriter stream = new StreamWriter(File,false))
            {
        for(int i = 0 ; i < dishes.count ; i++)
            {
            stream.WriteLine(dishes[i].tostring());
        }

    }
}
