using System;
using System.Globalization;
using System.Text;

public class Class1
{
	public Class1()
	{
        {
            static void Main(string[] args)
            {
                /*
                 * Working With Methods
                 */
                int monthlyWage = 1234;
                int months = 12;
                int bonus = 1000;

                //int yearlyWage = CalculateYearlyWage(monthlyWage, months, bonus);

                //Console.WriteLine($"Yearly wage (from main): {yearlyWage}");

                double monthlyWageDouble = 1500.0;
                double monthsDouble = 12;
                double bonousDouble = 1000;
                double yearlyWageWithBonusDouble = CalculateYearlyWage(monthlyWage, monthsDouble, bonousDouble);


                Console.ReadLine();
            }

            public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
            {
                //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
                if (numberOfMonthsWorked == 12)//let's add a bonus month
                    return monthlyWage * (numberOfMonthsWorked + 1);

                return monthlyWage * numberOfMonthsWorked;
            }

            public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
            {
                Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
                return monthlyWage * numberOfMonthsWorked + bonus;
            }

            public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
            {
                Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
                return monthlyWage * numberOfMonthsWorked + bonus;
            }
        }
    }
}