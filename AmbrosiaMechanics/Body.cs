using AmbrosiaMechanics.Influences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosiaMechanics
{
    public class Body
    {
        public Resource HP { get; set; }

        public Resource MP { get; set; }

        public ParametersBox BaseParameters { get; set; }

        public ParametersBox CurrentParameters { get; set; }

        public Body(ParametersBox baseParameters)
        {
            BaseParameters = baseParameters;

            CurrentParameters = baseParameters;

            HP = new Resource(CurrentParameters.SecondaryFactors[ParametersBox.SecondaryFactor.HPMax],
                CurrentParameters.SecondaryFactors[ParametersBox.SecondaryFactor.HPRegen]);

            MP = new Resource(CurrentParameters.SecondaryFactors[ParametersBox.SecondaryFactor.MPMax],
                CurrentParameters.SecondaryFactors[ParametersBox.SecondaryFactor.MPRegen]);
        }

        public bool IsAlive => HP.Value > 0;

        public IInfluence GetStrike()
        {
            return new DamageInfluence();
        }
    }
}
