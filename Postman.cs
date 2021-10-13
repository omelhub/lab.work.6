using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._6
{
    class Postman : Employee
    {
        public override string WhatYouDo() => "Разношу почту, не мешайте!";
        public override int WorkTime() => (DateTime.Now.Year - DateOfEmployment.Year);
        public override string FormatOfTime()
        {
            if (WorkTime() % 10 < 5 & WorkTime() % 10 > 1 & (WorkTime() % 100 > 20 | WorkTime() % 100 < 10))
                return "года";
            else if (WorkTime() % 10 == 1 & WorkTime() % 100 != 11)
                return "год";
            else return "лет";
        }
    }
}
