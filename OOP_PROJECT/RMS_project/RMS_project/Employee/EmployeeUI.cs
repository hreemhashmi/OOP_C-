using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_project.Employee
{
    internal class EmployeeUI
    {

        private EmployeeService service = new EmployeeService();

        public void EmployeeMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ===== Staff Management ===== ");
                Console.WriteLine(" 1. Add Employee ");
                Console.WriteLine(" 2. View Employee ");
                Console.WriteLine(" 3. Update Employee Record ");
                Console.WriteLine(" 4. Delete Employee Record ");
                Console.WriteLine(" 5. View Employees Salary ");
                Console.WriteLine(" 6. Back To Admin Menu ");
                Console.Write(" Choose : ");
                string option = Console.ReadLine();

                if (option == "1") { AddEmployee(); }
                else if (option == "2") { ViewEmployees(); }
                else if (option == "3") { UpdateEmployee(); }
                else if (option == "4") { DeleteEmployee(); }
                else if (option == "5") { ViewSalaries(); }
                else if (option == "6") { break; }
                else
                {
                    Console.WriteLine(" invalid option ");
                    Console.ReadLine();
                }
            }
        }

        private void AddEmployee()
        {
            Console.Write(" Enter Employee Name : ");
            string name = Console.ReadLine();
            Console.Write(" Enter Employee Id : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write(" Enter Employee Salary : ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write(" Enter Employee Work Timing : ");
            string timing = Console.ReadLine();

            EmployeeModel employee = new EmployeeModel(name, id, salary, timing);
            if (service.AddEmployee(employee) == true)
            {
                Console.WriteLine(" Employee Record Added Successfully ");
            }
            else
            {
                Console.WriteLine(" This Id already exists ");
            }
            Pause();
        }

        private void ViewEmployees()
        {
            List<EmployeeModel> employees = service.GetAllEmployees();

            Console.WriteLine("========= Employee Record ======== ");
            Console.WriteLine(" EMPLOYEE\tID\tSalary\tTiming ");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetName() + "\t" + employees[i].GetId()
                    + "\t" + employees[i].GetSalary() + "\t" + employees[i].GetTiming());
            }
            Pause();
        }

        private void UpdateEmployee()
        {
            Console.Write(" Enter Employee ID to Update : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write(" Enter New Name : ");
            string name = Console.ReadLine();
            Console.Write(" Enter New Salary : ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write(" Enter New Work Timing : ");
            string timing = Console.ReadLine();

            if (service.UpdateEmployee(id, name, salary, timing) == true)
            {
                Console.WriteLine(" Record Updated ");
            }
            else
            {
                Console.WriteLine(" Employee Not Found ");
            }
            Pause();
        }

        private void DeleteEmployee()
        {
            Console.Write(" Enter Employee ID To Delete : ");
            int id = int.Parse(Console.ReadLine());

            if (service.DeleteEmployee(id) == true)
            {
                Console.WriteLine(" Employee Record Deleted ");
            }
            else
            {
                Console.WriteLine(" Employee Not Found ");
            }
            Pause();
        }

        private void ViewSalaries()
        {
            List<EmployeeModel> employees = service.GetAllEmployees();

            Console.WriteLine(" ==== Employee Salary ==== ");
            Console.WriteLine(" Name\t\tSalary ");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetName() + " \t " + employees[i].GetSalary());
            }
            Pause();
        }

        private void Pause()
        {
            Console.WriteLine(" Press Enter to continue.....");
            Console.ReadLine();
        }
    }
}

