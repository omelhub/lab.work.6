using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._6
{
    class Program
    {
        static void Main(string[] args)
        {
            PostOffice office = new PostOffice();

            Cashier cash1 = new Cashier();
            cash1.Name = "Андрей";
            cash1.DateOfEmployment = new DateTime(2002, 11, 11);
            office.Employees.Add(cash1);

            Cashier cash2 = new Cashier();
            cash2.Name = "Виктор";
            cash2.DateOfEmployment = new DateTime(2002, 11, 20);
            office.Employees.Add(cash2);

            Operator oper1 = new Operator();
            oper1.Name = "Дмитрий";
            oper1.DateOfEmployment = new DateTime(2003, 4, 11);
            office.Employees.Add(oper1);

            Operator oper2 = new Operator();
            oper2.Name = "Василий";
            oper2.DateOfEmployment = new DateTime(2003, 7, 12);
            office.Employees.Add(oper2);

            Operator oper3 = new Operator();
            oper3.Name = "Иннокентий";
            oper3.DateOfEmployment = new DateTime(2002, 7, 21);
            office.Employees.Add(oper3);

            Postman post1 = new Postman();
            post1.Name = "Вячеслав";
            post1.DateOfEmployment = new DateTime(2017, 01, 02);
            office.Employees.Add(post1);

            Postman post2 = new Postman();
            post2.Name = "Святослав";
            post2.DateOfEmployment = new DateTime(2010, 03, 04);
            office.Employees.Add(post2);

            Postman post3 = new Postman();
            post3.Name = "Лев";
            post3.DateOfEmployment = new DateTime(2020, 05, 06);
            office.Employees.Add(post3);

            office.Poll();
            Console.Beep();
            Console.ReadKey();
        }
    }
}
