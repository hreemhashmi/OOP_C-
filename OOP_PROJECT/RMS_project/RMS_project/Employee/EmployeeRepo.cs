using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Employee
{
    internal class EmployeeRepo
    {
        private readonly string file = "employee.txt";

        public EmployeeRepo() { }

        public void SaveInFile(EmployeeModel employee)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(employee.ToString());
            }
        }

        public List<EmployeeModel> GetEmployeesFromFile()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            if (!File.Exists(file))
            {
                return employees;
            }

            using (StreamReader stream = new StreamReader(file))
            {
                string line = "";
                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    int id = int.Parse(parts[1]);
                    double salary = double.Parse(parts[2]);
                    string timing = parts[3];

                    EmployeeModel employee = new EmployeeModel(name, id, salary, timing);
                    employees.Add(employee);
                }
            }
            return employees;
        }

        public void SaveAllInFile(List<EmployeeModel> employees)
        {
            using (StreamWriter stream = new StreamWriter(file, false))
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    stream.WriteLine(employees[i].ToString());
                }
            }
        }
    }
}

