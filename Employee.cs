using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._6
{
    public class Employee
    {
       
        public string Name { set; get; }
        public DateTime DateOfEmployment { set; get; }
        public string Say() => Name;
        //public string Say(string answer)
        //    return answer == "А как вас зовут?" ? Name : "";
        public virtual int WorkTime() => 0;
        public virtual string WhatYouDo() => null;
        public virtual string FormatOfTime() => string.Empty;
    }
}
