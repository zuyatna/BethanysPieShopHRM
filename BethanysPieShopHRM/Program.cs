using System;
using BethanysPieShopHRM.HR;

namespace BethanysPieShopHRM
{
    // ReSharper disable once ClassNeverInstantiated.Global
    class Program
    {
        static void Main()
        {
            Employee bethany = new Employee("Bethany", "Smith", "bethany@gmail.com", new DateTime(1979, 1, 16), 25);
            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.ReceiveWage();

            Console.WriteLine();

            Manager mery = new Manager("Mery", "Jane", "mery@gmail.com", new DateTime(1990, 5, 12), 30);
            mery.DisplayEmployeeDetails();
            mery.PerformWork();
            mery.ReceiveWage();
            mery.AttendManagementMeeting();
        }
    }
}