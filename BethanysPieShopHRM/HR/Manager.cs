using System;

namespace BethanysPieShopHRM.HR
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, DateTime birthDay, double? hoursRate) : base(firstName, lastName, email, birthDay, hoursRate)
        {
            // implement here
        }

        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;

            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been email!");
        }
    }
}