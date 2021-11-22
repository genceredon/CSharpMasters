using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Input 10 Employee Names: ");
            
            List<Employee> empList = new List<Employee>();
            Calculate<Employee> calculate = new Calculate<Employee>();

            for (int i = 1; i <= 10; i++)
            {
                Employee emp = new Employee();

                Console.WriteLine($"Employee [{i}]   ");
                
                Console.Write("Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Daily Rate: ");
                emp.DailyRate = decimal.Parse(Console.ReadLine());

                Console.Write("Days Worked: ");
                emp.DaysWorked = decimal.Parse(Console.ReadLine());

                Console.Write("Commission Rate: ");
                emp.CommissionRate = decimal.Parse(Console.ReadLine());

                Console.Write("Sales: ");
                emp.Sales = decimal.Parse(Console.ReadLine());
                
                emp.Sales = calculate.Salary(emp);
                Console.WriteLine($"Calculated Salary: {emp.Sales} ");

                emp.Commission = calculate.Commission(emp, emp.Sales);
                Console.WriteLine($"Calculated Commission: {emp.Commission} ");

                empList.Add(emp);
                Console.WriteLine("---------------------------------------------------- ");
            }

            Console.Clear();
            Console.WriteLine("Employees from highest earnings to lowest.");
            Console.WriteLine(SortEmployees(empList));
         }

        private static string SortEmployees(List<Employee> empList)
        {
            var sortedList = string.Empty;
            var list = empList.OrderByDescending(x => x.Salary + x.Commission);
            Console.WriteLine("---------------------------------------------------- ");
            foreach (var item in list)
            {
                sortedList += $"Employee Name: {item.Name}  --  Monthly Compensation: {item.Salary + item.Commission} \n";
            }

            return sortedList;
        }
    }
}
