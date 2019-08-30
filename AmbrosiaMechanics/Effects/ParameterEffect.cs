namespace AmbrosiaMechanics.Effects
{
    class ParameterEffect: IEffect
    {
        private int add;
        private int multi;

        public ParameterEffect()
        {

        }

        public int Proccess(int value)
        {
            return value * (multi / 100) + add;
        }

        public string Name()
        {
            throw new System.NotImplementedException();
        }

        public string Description()
        {
            throw new System.NotImplementedException();
        }
        
    }
}
