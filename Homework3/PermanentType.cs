using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class PermanentType : Employee
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlyPayout()
        {
            return this.AnnualSalary / 12;
        }
    }
}
