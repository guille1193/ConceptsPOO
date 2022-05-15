using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class Date
    {
        private int _Year;
        private int _Month;
        private int _Day;

        public Date(int year, int month, int day)
        {
            _Year = year;
            _Month = CheckMonth(month);
            _Day = CheckDay(year, month, day);
        }

        private int CheckDay(int year, int month, int day)
        {
            if(day == 2 && day == 29 && IsleapYear(year))
            {
                return day;
            }
            int[] daysPermonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(day >=1 && day <= daysPermonth[month])
            {
                return day;
            }
            throw new DayException("Invalid Day");
        }

        private bool IsleapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 !=0;
        }      

        private int CheckMonth(int month)
        {
            if(month>=0 && month<=12)
            {
                return month;

            }
            throw new MonthException("Invalid Month");
        }

        public override string ToString()
        {
            return $"{_Year}/{_Month:00}/{_Day:00}";
        }

    }
}
