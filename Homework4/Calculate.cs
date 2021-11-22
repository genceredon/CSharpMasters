using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public  class Calculate<T> where T : Employee
    {
        public decimal Salary(T employee)
        {
            return employee.DailyRate * employee.DaysWorked;
        }

        public decimal Commission(T employee, decimal totalSales)
        {
            return totalSales * (employee.CommissionRate / 100);
        }
    }
}
