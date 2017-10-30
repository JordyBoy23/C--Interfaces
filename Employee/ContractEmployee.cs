using System;

namespace Employee
{
    class ContractEmployee : BaseEmployeeClass
    {
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return this.TotalHours = TotalHours * HourlyPay;
        }
    }
}