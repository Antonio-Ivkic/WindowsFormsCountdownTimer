using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCountdownTimer
{
    class Storing
    {
        //postavljanje Timera
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; } 

        //izlaz
        public string path { get; set; }
        public string format { get; set; }
    }
}
