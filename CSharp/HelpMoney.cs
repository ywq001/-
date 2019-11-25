using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class HelpMoney:Entity
    {
        public DateTime GetTime { get; set; }
        public int Usable { get; set; }
        public int Freeze { get; set; }
        public string Kind { get; set; }
        public string Change { get; set; } 
        public string Remaek { get; set; }
        public HelpMoney()
        {

        }

        public HelpMoney(int usable)
        {
            Usable = usable;
        }

        internal void changeMoney()
        {

        }

    }
}
