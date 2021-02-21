namespace DesignPatterns.ProtoType_Pattern
{
    public interface ICarPrototype
    {
        void Drive();

        ICarPrototype Clone();

        void SetEngine(EngineSize engineSize);
    }
}