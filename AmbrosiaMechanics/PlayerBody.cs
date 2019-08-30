using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AmbrosiaMechanics.ParametersBox;

namespace AmbrosiaMechanics
{
    public class PlayerBody: Body
    {
        private static readonly ParametersBox Argument = new ParametersBox()
            {
                MainFactors = new EnumContainer<MainFactor, int>()
                {
                    [MainFactor.Strength] = 10,
                    [MainFactor.Vitality] = 10,
                    [MainFactor.Agility] = 10,
                    [MainFactor.Int] = 10,
                    [MainFactor.Will] = 10,
                    [MainFactor.Luck] = 10,
                },
                SecondaryFactors = new EnumContainer<SecondaryFactor, int>()
                {
                    [SecondaryFactor.HPMax] = 100,
                    [SecondaryFactor.HPRegen] = 10,
                    [SecondaryFactor.MPMax] = 10,
                    [SecondaryFactor.MPRegen] = 10,
                },
                ArmorFactors = new EnumContainer<DamageType, int>()
                {
                    //[DamageType.Physic] = 10,
                    //[DamageType.Magic] = 10,
                    //[DamageType.Fire] = 10,
                },
            };

        public PlayerBody()
            :base(Argument)
        {

        }
    }
}
