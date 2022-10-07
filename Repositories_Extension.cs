using CoffeeShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public static class Repositories_Extension
    {
        public static void AddBatch<T>(this IRepository<T> repo, T[] empl) where T : BaseClass
        {
            foreach (var items in empl)
            {
                Console.WriteLine(items.Id);

            }
        }
    }
}
