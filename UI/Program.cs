using Services.Creational.Factories.FactoryMethod;
using Services.Models;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {

                //Simple Factory implementation testing

                //Console.WriteLine("");
                //Console.WriteLine("Enter employee type ID");

                //var empTypeId = Int16.Parse(Console.ReadLine());

                //EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
                //IEmployeeManager employeeManager = empFactory.GetEmployeeManager(empTypeId);

                //var employeePay = employeeManager.GetPay();
                //var employeeBonus = employeeManager.GetBonus();

                //Console.WriteLine($"Employee Pay = {employeePay} --- Employee Bonus = {employeeBonus}");


                //Factory Method implementation testing
                
                Console.WriteLine("");
                Console.WriteLine("Enter employee type ID");

                var empTypeId = Int16.Parse(Console.ReadLine());

                Employee employee = new Employee() { Id = empTypeId };

                BaseEmployeeFactory employeeFactory = new EmployeeManagerFactory().CreateFactory(employee);
                employeeFactory.ApplySalary();


                Console.WriteLine($"Employee Pay = {employee.HourlyPay} --- Employee Bonus = {employee.Bonus}/n");
                Console.WriteLine($"Employee House Allowance = {employee.HouseAllowance} --- Employee Medical Allowance = {employee.MedicalAllowance}");

            }
        }
    }
}
