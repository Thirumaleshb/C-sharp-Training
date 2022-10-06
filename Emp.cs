using CoffeeShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class Emp
    {
        public static void Main (String[] args)
        {
            employee emp = new employee();
            emp.Id = 1;
            emp.Name = "Thiru";
            EmployeeRepository<employee> empr = new EmployeeRepository<employee>();
            EmployeeRepository<organisation> empr1 = new EmployeeRepository<organisation>();
            EmployyeeRepositorySub empr2 = new EmployyeeRepositorySub();
            empr.add(emp);
            empr.add( new employee{Id=2, Name="Bhavana"});
            empr.save();

            var vari=empr.GetById(2);
            Console.WriteLine("The Employee Who Got Removed is " + vari.Name);


            var org = new organisation();
            empr1.add(new organisation {Id=11, FirstName="Thirumalsh" });
            empr1.add(new organisation { Id =22, FirstName = "Bhavana Jain" });
            empr1.save();
            empr2.remove(emp);
        }
    }
}
