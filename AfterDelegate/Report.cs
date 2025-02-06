using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterDelegate
{
    public class Report
    {
        // delegate
        public delegate bool IllegibleSales(Employee e);

        public void ProcessEmployees(Employee[] employee, string Title, IllegibleSales illegibleSales)
        {
            Console.WriteLine(Title);
            Console.WriteLine("------------------------------");

            foreach (Employee e in employee)
            {
                if (illegibleSales(e))
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
            }

            Console.WriteLine();

        }
    }
}
