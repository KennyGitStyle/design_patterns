namespace DesignPatterns.ProtoType_Pattern
{
    public class Client
    {
        public static void Main(){

            ICarPrototype carPrototype = new Nissan();

            ICarPrototype nissanNismo = carPrototype.Clone();

            nissanNismo.SetEngine(EngineSize.OnePointFive);

            ICarPrototype NissanNavaro = carPrototype.Clone();

            NissanNavaro.SetEngine(EngineSize.TwoPointFive);
        }
    }
}