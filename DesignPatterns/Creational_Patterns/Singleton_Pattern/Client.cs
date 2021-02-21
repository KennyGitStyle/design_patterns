namespace DesignPatterns.Singleton_Pattern
{
    public class Client
    {
        public static void Main(){
            Bentley bentley = Bentley.GetInstance();
            Bentley.Drive();
        }
    }
}