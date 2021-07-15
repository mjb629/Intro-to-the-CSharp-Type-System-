using BethanysPieShopHRMPart2.HR;
using System;

namespace BethanysPieShopHRMPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be",
                new DateTime(1979, 1, 16), EmployeeType.Manager, 25);

            Employee george = new Employee("George", "SMith", "george@snowball.be",
                new DateTime(1984, 3, 28), EmployeeType.Research, 30);

            Employee testEmployee = bethany;
            testEmployee.firstName = "Gill";

            testEmployee.DisplayEmployeeDetails();
            bethany.DisplayEmployeeDetails();

            bethany.firstName = "John";
            bethany.hourlyRate = 10;

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();

            george.DisplayEmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();

            BethanysPieShopHRMPart2.Accounting.Customer customer = new Accounting.Customer();

            Console.ReadLine();
        }
    }
}
