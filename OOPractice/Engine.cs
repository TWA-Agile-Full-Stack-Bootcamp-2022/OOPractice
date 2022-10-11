namespace OOPractice
{
    public class Engine
    {
        private EngineType type;
        public Engine(EngineType type)
        {
            this.type = type;
        }

        public EngineType GetEngineType()
        {
            return this.type;
        }
    }
}