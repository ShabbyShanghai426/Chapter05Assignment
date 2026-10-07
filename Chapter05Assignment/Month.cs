using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter05Assignment
{
    internal class Month
    {
        private int monthNumberValue;

        public int MonthNumber
        {
            get => monthNumberValue;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Month Number must be between 1 and 12");

                }
                monthNumberValue = value;
            }
        }
        public Month(int monthNumber)
        {
            MonthNumber = monthNumber;
        }

        public string GetMonthName()
        {
            return monthNumberValue switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => throw new InvalidOperationException("Invalid month, please choose 1-12")
            };
        }

        public int GetDaysInMonth()
        {
            return monthNumberValue switch
            {
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };
        }

        public override string ToString()
        {
            return $"\n{GetMonthName()} has {GetDaysInMonth()} days.";
        }
    }
}
