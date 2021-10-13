using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._6
{
    class Operator : Employee
    {
        public override string WhatYouDo() => "Ищу посылку.";
        public override int WorkTime() => ((DateTime.Now.Year - DateOfEmployment.Year)*12 + DateTime.Now.Month - DateOfEmployment.Month);
        public override string FormatOfTime()
        {
            if (WorkTime() % 10 < 5 & WorkTime() % 10 > 1 & (WorkTime() % 100 > 20 | WorkTime() % 100 < 10))
                return "месяца";
            else if (WorkTime() % 10 == 1 & WorkTime() % 100 != 11)
                return "месяц";
            else return "месяцев";
        }
    }
}
