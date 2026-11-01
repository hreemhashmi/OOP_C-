using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Employee
{
    internal class EmployeeModel
    {
            private string name;
            private int id;
            private double salary;
            private string timing;

            public EmployeeModel()
            {
            }

            public EmployeeModel(string name, int id, double salary, string timing)
            {
                this.name = name;
                this.id = id;
                this.salary = salary;
                this.timing = timing;
            }

            public string GetName() { return this.name; }
            public void SetName(string name) { this.name = name; }

            public int GetId() { return this.id; }
            public void SetId(int id) { this.id = id; }

            public double GetSalary() { return this.salary; }
            public void SetSalary(double salary) { this.salary = salary; }

            public string GetTiming() { return this.timing; }
            public void SetTiming(string timing) { this.timing = timing; }

            public override string ToString()
            {
                return $"{name},{id},{salary},{timing}";
            }
        }
    }

