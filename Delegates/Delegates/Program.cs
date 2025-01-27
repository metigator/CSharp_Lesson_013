using BeforeDelegates;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee { Id = 1, Name = "Issam A", TotalSales = 65000m, Gender = "M"} ,
                new Employee { Id = 2, Name = "Reem S", TotalSales = 50000m, Gender = "F"} ,
                new Employee { Id = 3, Name = "Suzan B", TotalSales = 65000m, Gender = "F"} ,
                new Employee { Id = 4, Name = "Sara A", TotalSales = 40000m, Gender = "F"} ,
                new Employee { Id = 5, Name = "Salah S", TotalSales = 42000m, Gender = "M"} ,
                new Employee { Id = 6, Name = "Rateb A", TotalSales = 30000m, Gender = "M"} ,
                new Employee { Id = 7, Name = "Abeer C", TotalSales = 16000m, Gender = "F"} ,
                new Employee { Id = 8, Name = "Marwan M", TotalSales = 15000m, Gender = "M"} ,

            };
            // Before using Delegate
            Console.WriteLine("================ Before Using Delegate ================");

            Report report = new Report();
            report.ProcessEmployee60000PlusSales(emps);
            report.ProcessEmployeesWithSalesBetween30000And59999(emps);
            report.ProcessEmployeesWithSalesLess30000(emps);

            Console.ReadKey();
        }
    }
}