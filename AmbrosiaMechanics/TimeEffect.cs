using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosiaMechanics
{
    class TimeEffect
    {
        //public Effect Effect { get; set; }

        public int RoundRange { get; private set; }

        public TimeEffect()
        {

        }
        
        public void Step()
        {
            RoundRange--;
        }
    }
}
