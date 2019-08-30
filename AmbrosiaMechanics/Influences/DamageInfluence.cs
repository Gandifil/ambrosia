using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosiaMechanics.Influences
{
    class DamageInfluence: IInfluence
    {
        public int MyProperty { get; set; }
        
        public void Operation(Body body)
        {
            body.HP.Degenerate(100);
        }
    }
}
