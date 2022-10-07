using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class EntityExtensions
    {
        public static T Copy<T>(this T obj) where T :EntityEntry
        {
            return obj;

        }

    }
}
