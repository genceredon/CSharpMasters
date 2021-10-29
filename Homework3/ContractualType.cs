using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class ContractualType : Employee
    {
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlyPayout()
        {
            return this.TotalHours * this.HourlyPay;
        }
    }
}
