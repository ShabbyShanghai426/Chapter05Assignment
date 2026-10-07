using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter05Assignment
{
    public abstract class Employee
    {
        private double federalTaxRate = 0.18;
        private double retirementRate = 0.10;
        private double socialSecurityRate = 0.06;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        public Employee(string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        //will be overridden
        public abstract double CalculateGrossPay();

        public double CalculateFederalTax() => CalculateGrossPay() * federalTaxRate;
        public double CalculateRetirement() => CalculateGrossPay() * retirementRate;
        public double CalculateSocialSecurity() => CalculateGrossPay() * socialSecurityRate;

        public double CalculateTotalDeductions() =>
            CalculateFederalTax() + CalculateRetirement() + CalculateSocialSecurity();

        public double CalculateNetPay() => CalculateGrossPay() - CalculateTotalDeductions();

        public void DisplayPayStub()
        {
            double gross = CalculateGrossPay();
            double fedTax = CalculateFederalTax();
            double retirement = CalculateRetirement();
            double socialSecurityTax = CalculateSocialSecurity();
            double net = CalculateNetPay();

            Console.WriteLine($"\nID: {Id}" +
                $"\nName: {FirstName} {LastName}" +
                $"\nGross Pay: {gross:F2}" +
                $"\nFederal Tax: {fedTax:F2}" +
                $"\nRetire: {retirement:F2}" +
                $"\nSocial Security: {socialSecurityTax:F2}" +
                $"\nTake-Home Pay: {net:F2}");
        }
    }
    public class SalariedEmployee : Employee
    {
        public double Salary { get; set; }

        public SalariedEmployee(string firstName, string lastName, string id, double salary)
            : base(firstName, lastName, id)
        {
            Salary = salary;
        }
        public override double CalculateGrossPay() => Salary;
    }

    public class HourlyEmployee : Employee
    {
        private double RegularHoursLimit = 40.0;
        private double OvertimeMultiplier = 1.5;

        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public HourlyEmployee(string firstName, string lastName, string id, double hourlyRate, double hoursWorked)
            : base(firstName, lastName, id)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
        public override double CalculateGrossPay()
        {
            if (HoursWorked <= RegularHoursLimit)
            {
                return HoursWorked * HourlyRate;
            }

            double regularPay = RegularHoursLimit * HourlyRate;
            double overtimeHours = HoursWorked * RegularHoursLimit;
            double overtimePay = overtimeHours * (HourlyRate * OvertimeMultiplier);

            return regularPay + overtimeHours;
        }
    }
}
