using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosiaMechanics
{
    public class Resource
    {
        public Resource(int maxValue, int regen)
        {
            this.Value = maxValue;
            this.MaxValue = maxValue;
            this.Regen = regen;
        }

        public Resource(Resource old, int maxValue, int regen)
        {
            this.Value = Math.Min(old.Value, maxValue);
            this.MaxValue = maxValue;
            this.Regen = regen;
        }

        public int Value { get; private set; }

        public int Regen { get; private set; }

        public int MaxValue { get; private set; }

        public float Proportion => Value / MaxValue;

        public void Regenerate()
        {
            Value = Math.Min(Value + Regen, MaxValue);
        }

        public void Regenerate(int value)
        { 
            Value = Math.Min(Value + value, MaxValue);
        }

        public bool Degenerate(int value)
        {
            bool canRemove = Value >= value;
            if (canRemove)
                Value -= value;
            return canRemove;
        }
    }
}
