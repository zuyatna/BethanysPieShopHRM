using System;

namespace BethanysPieShopHRM
{
    // ReSharper disable once ClassNeverInstantiated.Global
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 1234;
            int months = 12;
            
            int yearlyWage = CalculateYearlyWage(monthlyWage, months);

            Console.WriteLine($"Yearly wage (from main): {yearlyWage}");
            
            Console.ReadLine();
        }

        private static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12)
            {
                return monthlyWage * (numberOfMonthsWorked + 1);
            }
            
            return monthlyWage * numberOfMonthsWorked;
        }
        
        private static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        
        private static double CalculateYearlyWage(double monthlyWage, int numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}