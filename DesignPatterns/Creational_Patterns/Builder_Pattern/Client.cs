using DesignPatterns.Builder_Pattern;

namespace DesignPatterns.Creational_Patterns.Builder_Pattern
{
    public class Client
    {
        public static void Main(){
            NissanBuilder nissanBuilder = new();
            var director = new Director(nissanBuilder);
            director.Implement(false);

            CarBrand nissan = nissanBuilder.GetResult();
        }
    }
}