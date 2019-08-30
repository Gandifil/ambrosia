using System;
using System.Collections.Generic;

namespace AmbrosiaMechanics
{
    public class EnumContainer<E, T> 
        where E : Enum
        where T : struct
    {
        private List<T> values = new List<T>();

        public EnumContainer()
        {
            int length = Enum.GetNames(typeof(E)).Length;
            values.Capacity = length;
            
            for (int i = 0; i < length; i++)
                values.Add(new T());
        }

        public EnumContainer(List<T> list)
        {
            int length = Enum.GetNames(typeof(E)).Length;
            if (length != list.Count)
                throw new ArgumentOutOfRangeException();
            values = list;
        }

        public T this[E index] {
            get => values[Convert.ToInt32(index)];
            set => values[Convert.ToInt32(index)] = value;
        }
    }
}
