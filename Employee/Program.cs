using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractEmployee contractEmployee1 = new ContractEmployee();
            FullTimeEmployee fullTimeEmployee1 = new FullTimeEmployee();

            contractEmployee1.ID = 1;
            contractEmployee1.FirstName = "Jordan";
            contractEmployee1.LastName = "Liddell";
            contractEmployee1.HourlyPay = 8;
            contractEmployee1.TotalHours = 20;

            fullTimeEmployee1.ID = 2;
            fullTimeEmployee1.FirstName = "Jordy";
            fullTimeEmployee1.LastName = "Lids";
            fullTimeEmployee1.AnnualSalary = 80000;

            Console.WriteLine();
            Console.WriteLine("{0}'s pay this month is {1:c}", contractEmployee1.GetFullName(), contractEmployee1.GetMonthlySalary());
            Console.WriteLine();
            Console.WriteLine("{0}'s monthly salary is {1:c}", fullTimeEmployee1.GetFullName(), fullTimeEmployee1.GetMonthlySalary());
            Console.WriteLine();

        }
    }
}
