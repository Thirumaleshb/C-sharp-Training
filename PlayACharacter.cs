using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingwithNull
{
     class PlayACharacter
    {
        public string name { get; set; }
        //public Nullable<int> DaySinceLogin { get; set; }
       // public Nullable<DateTime> DOB { get; set; }

        public int? DaySinceLogin { get; set; }
        public DateTime? DOB { get; set; }

        public PlayACharacter()
        {
            DOB = null;
            DaySinceLogin = null;
        }
    }

    
}
