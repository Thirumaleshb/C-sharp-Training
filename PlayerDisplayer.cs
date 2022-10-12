using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingwithNull
{
    static  class PlayerDisplayer
    {
        public static void Write(PlayACharacter player)
        {
            Console.WriteLine($"The Name is {player.name}");

        }
    }
}
