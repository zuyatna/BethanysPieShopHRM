using System;

namespace BethanysPieShopHRM.HR
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hoursRate;
        public static double taxRate = 0.15;

        private DateTime birthDay;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int NumberOfHoursWorked
        {
            get => numberOfHoursWorked;
            set => numberOfHoursWorked = value;
        }

        public double Wage
        {
            get => wage;
            set => wage = value;
        }

        public double? HourlyRate
        {
            get => hoursRate;
            set => hoursRate = value;
        }

        public DateTime BirthDay
        {
            get => birthDay;
            set => birthDay = value;
        }
        
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hoursRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hoursRate ?? 10;
        }

        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            if (HourlyRate != null)
            {
                double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
                double taxAmount = wageBeforeTax * taxRate;

                Wage = wageBeforeTax * taxAmount;

                Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}");
                NumberOfHoursWorked = 0;
            }
            else
            {
                Wage = 0;
            }
            
            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: {FirstName}\nLastName: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\nTax Rate: {taxRate}");
        }
    }
}