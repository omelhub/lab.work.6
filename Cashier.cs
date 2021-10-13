using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._6
{
    class Cashier : Employee
    {
        public override string WhatYouDo() => "Пополняю транспортные карты.";

        public override int WorkTime()
        {
            int days = 0;
            for (int i = 0; i < ((DateTime.Now.Year - DateOfEmployment.Year)); i++)
            {
                int d = 365;
                if (DateTime.IsLeapYear(DateOfEmployment.Year + i))
                {
                    d += 1;
                }

                days += d;
            }

            return (days + DateTime.Now.DayOfYear - DateOfEmployment.DayOfYear);
        }

        public override string FormatOfTime()
        {
            if (WorkTime() % 10 < 5 & WorkTime() % 10 > 1 & (WorkTime() % 100 > 20 | WorkTime() % 100 < 10))
                return "дня";
            else if (WorkTime() % 10 == 1 & WorkTime() % 100 != 11)
                return "день";
            else return "дней";
        }
    }
}