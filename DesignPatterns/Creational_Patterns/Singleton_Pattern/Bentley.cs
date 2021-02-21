using System;

namespace DesignPatterns.Singleton_Pattern
{
    public class Bentley
    {
        private static Bentley onlyInstance;

        public Bentley(){}

        public static void Drive() => Console.WriteLine("Bentley is driving...");

        public static Bentley GetInstance(){
            if (onlyInstance == null)
                onlyInstance = new Bentley();

            return onlyInstance;
        }
    }
}