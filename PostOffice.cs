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
        //public PostOffice()
        //{
        //    us.Add(new Cashier() { Name = "Cashier1", DateOfEmployment = new DateTime(2021, 10, 1) });
        //    us.Add(new Cashier() { Name = "Cashier2", DateOfEmployment = new DateTime(2010, 4, 10) });
        //    us.Add(new Operator() { Name = "Operator1", DateOfEmployment = new DateTime(2020, 1, 1) });
        //    us.Add(new Operator() { Name = "Operator2", DateOfEmployment = new DateTime(2015, 10, 10) });
        //    us.Add(new Operator() { Name = "Operator3", DateOfEmployment = new DateTime(2017, 7, 1) });
        //    us.Add(new Postman() { Name = "Postman1", DateOfEmployment = new DateTime(2000, 9, 1) });
        //    us.Add(new Postman() { Name = "Postman2", DateOfEmployment = new DateTime(2003, 1, 1) });
        //    us.Add(new Postman() { Name = "Postman3", DateOfEmployment = new DateTime(2009, 4, 1) });
        //}

        public void Poll()
        {
            foreach (Employee employee in Employees)
            {
                //Console.WriteLine($"А как вас зовут? {e.Say("А как вас зовут?")}; Что вы делаете? {e.WhatYouDo()}; Как давно вы тут работаете? {e.WorkTime()}");
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