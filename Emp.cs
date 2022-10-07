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
             var empr = new SqlRepository<employee>(new Storage());
            ListRepository<organisation> empr1 = new ListRepository<organisation>();
            EmployyeeRepositorySub empr2 = new EmployyeeRepositorySub();
            empr.add(emp);
            empr.add(new employee{Id=2, Name="Bhavana"});
            empr.save();

            //var empp = new Object();
            //Console.WriteLine(empp.Copy());

            Addemployee(empr);
            Addorganisations(empr1);

            var vari=empr.GetById(2);
            Console.WriteLine("The Employee Who Got Removed is " + vari.Name);


            var org = new organisation();
            empr1.add(new organisation {Id=11, FirstName="Thirumalsh" });
            empr1.add(new organisation { Id =22, FirstName = "Bhavana Jain" });
            empr1.save();
            empr2.remove(emp);
        }

        private static void Addemployee(IRepository<employee> emp)
        {
            var empl = new[]
            {
                new employee{Id=2,Name="Thiru"},
                new employee{Id=3,Name="Manoj"}
            };
        emp.AddBatch(empl);
            Console.WriteLine(emp.Copy());
        }

        private static void Addorganisations(IRepository<organisation> org)
        {
            var orgl = new[]
            {
                new organisation{Id=4,FirstName="Thiru"},
                new organisation{Id=5,FirstName="Manoj"}
            };
            org.AddBatch( orgl);
        }

        
    }
}
