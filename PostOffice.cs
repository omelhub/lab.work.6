using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._6
{
    class PostOffice
    {
        public List<Employee> Employees{ set; get; } = new List<Employee>();
        public void Poll()
        {
            foreach (Employee employee in Employees)
            {
                Console.Write("А вас как зовут? ");
                Console.Write($"           {employee.Say()}\n");
                Console.Write("А что вы делаете? ");
                Console.Write($"          {employee.WhatYouDo()}\n");
                Console.Write("И давно вы тут работаете? ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"  {employee.WorkTime()} {employee.FormatOfTime()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
// x =12 
// ~x