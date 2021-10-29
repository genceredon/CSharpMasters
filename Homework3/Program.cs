using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Press (P/p) if Permanent and (C/c) if Contractual");
            Console.Write("Employee Type: ");
            string empType = Console.ReadLine();

            switch (empType)
            {
                case "P":
                case "p":
                    Console.WriteLine("Permanent Employee Detail");
                    var permEmp = new PermanentType();
                    EmployeeDetail(permEmp);                
                    break;
                case "C":
                case "c":
                    Console.WriteLine("Contractual Employee Detail");
                    var contEmp = new ContractualType();
                    EmployeeDetail(contEmp);         
                    break;
                default:
                    Console.WriteLine("Invalid Employee Type");
                    break;
            }
        }

        #region Private Methods

        private static void EmployeeDetail(PermanentType empDetail)
        {
            Console.Write("Employee Firstname: ");
            empDetail.FirstName = Console.ReadLine();

            Console.Write("Employee Lastname: ");
            empDetail.LastName = Console.ReadLine();

            Console.Write("Employee Middlename: ");
            empDetail.MiddleName = Console.ReadLine();

            Console.Write("Annual Salary: ");
            empDetail.AnnualSalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------- ");
            Console.WriteLine("Monthly Payout: ");
            Console.Write(empDetail.GetMonthlyPayout());
        }

        private static void EmployeeDetail(ContractualType empDetail)
        {
            Console.Write("Employee Firstname: ");
            empDetail.FirstName = Console.ReadLine();

            Console.Write("Employee Lastname: ");
            empDetail.LastName = Console.ReadLine();

            Console.Write("Employee Middlename: ");
            empDetail.MiddleName = Console.ReadLine();

            Console.Write("Hourly Pay: ");
            empDetail.HourlyPay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Total Hours: ");
            empDetail.TotalHours = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("---------------------------------------------------- ");
            Console.WriteLine("Monthly Payout: ");
            Console.Write(empDetail.GetMonthlyPayout());

        }

        #endregion
    }
}
