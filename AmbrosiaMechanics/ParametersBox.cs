using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosiaMechanics
{
    public class ParametersBox
    {
        public enum DamageType
        {
            Physic,
            Magic,
            Fire,
            Ice,
            Poison
        }

        public enum MainFactor
        {
            Strength,
            Vitality,
            Agility,
            Will,
            Int,
            Luck
        }

        public enum SecondaryFactor
        {
            HPMax,
            HPRegen,
            MPMax,
            MPRegen
        }

        public EnumContainer<MainFactor, int> MainFactors { get; set; }

        public EnumContainer<SecondaryFactor, int> SecondaryFactors { get; set; }

        public EnumContainer<DamageType, int> ArmorFactors { get; set; }


    }
}
