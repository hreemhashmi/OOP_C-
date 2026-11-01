using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Employee
{
    internal class EmployeeService
    {
        private EmployeeRepo repo = new EmployeeRepo();

        public bool AddEmployee(EmployeeModel employee)
        {
            List<EmployeeModel> employees = repo.GetEmployeesFromFile();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].GetId() == employee.GetId())
                {
                    return false;
                }
            }
            repo.SaveInFile(employee);
            return true;
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return repo.GetEmployeesFromFile();
        }

        public bool UpdateEmployee(int id, string newName, double newSalary, string newTiming)
        {
            List<EmployeeModel> employees = repo.GetEmployeesFromFile();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].GetId() == id)
                {
                    employees[i].SetName(newName);
                    employees[i].SetSalary(newSalary);
                    employees[i].SetTiming(newTiming);
                    repo.SaveAllInFile(employees);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteEmployee(int id)
        {
            List<EmployeeModel> employees = repo.GetEmployeesFromFile();
            List<EmployeeModel> remaining = new List<EmployeeModel>();
            bool found = false;

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].GetId() == id)
                {
                    found = true;
                }
                else
                {
                    remaining.Add(employees[i]);
                }
            }
            if (found == true)
            {
                repo.SaveAllInFile(remaining);
            }
            return found;
        }
    }
}

