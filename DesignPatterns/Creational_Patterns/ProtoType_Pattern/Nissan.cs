using System;

namespace DesignPatterns.ProtoType_Pattern
{
    public class Nissan : ICarPrototype
    {

        public ICarPrototype Clone() => new Nissan();

        public void Drive() => Console.WriteLine("Nissan driving...");

        public void SetEngine(EngineSize engineSize) => 
            engineSize.Equals(EngineSize.OnePointFive);
    }
}