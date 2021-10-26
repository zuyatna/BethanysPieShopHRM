using System;
using BethanysPieShopHRM.HR;

namespace BethanysPieShopHRM
{
    static class Program
    {
        static void Main()
        {
            Employee bethany = new Employee("Bethany", "Smith", "bethany@gmail.com", new DateTime(1979, 1, 16), 25);
            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.ReceiveWage();

            Console.WriteLine();

            Manager merry = new Manager("Merry", "Jane", "mery@gmail.com", new DateTime(1990, 5, 12), 30);
            merry.DisplayEmployeeDetails();
            merry.PerformWork();
            merry.ReceiveWage();
            merry.AttendManagementMeeting();
        }
    }
}