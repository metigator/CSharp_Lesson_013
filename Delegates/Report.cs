using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeDelegates
{
    public class Report
    {
        public void ProcessEmployee60000PlusSales(Employee[] employee)
        {
            Console.WriteLine("Employees with $60,000+ Sales");
            Console.WriteLine("------------------------------");

            foreach (Employee e in employee)
            {
                if (e.TotalSales >= 60000m)
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
            }

            Console.WriteLine();

        }

        public void ProcessEmployeesWithSalesBetween30000And59999(Employee[] employee)
        {
            Console.WriteLine("Employees With Sales Between $30000 And $59999 ");
            Console.WriteLine("------------------------------");

            foreach (Employee e in employee)
            {
                if (e.TotalSales < 60000m && e.TotalSales >= 30000)
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
            }
            Console.WriteLine();

        }

        public void ProcessEmployeesWithSalesLess30000(Employee[] employee)
        {
            Console.WriteLine("Employees With Sales less $30000 A ");
            Console.WriteLine("------------------------------");

            foreach (Employee e in employee)
            {
                if (e.TotalSales < 30000)
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
            }
            Console.WriteLine();

        }



    }
}
