using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:\n 1.Add Employee\n 2.Delete Employee\n 3.Search Employee\n 4.List Of Employees");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Employee id:");
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Employee Name:");
                    string j = Console.ReadLine();
                    Console.WriteLine("Enter the Employee Salary:");
                    double k = Convert.ToDouble(Console.ReadLine());

                    EmployeeDAL cemp = new EmployeeDAL();
                    Employee e = new Employee();
                    cemp.AddEmployee(new Employee() {Employeeid=i,Employeename=j,salary=k });
               
            
                    break;
                case 2:
                    EmployeeDAL demp = new EmployeeDAL();
                    break;
                case 3:
                    EmployeeDAL semp = new EmployeeDAL();
                    break;
                case 4:
                    EmployeeDAL lemp = new EmployeeDAL();
                    break;
            }
        }
    }
}
