using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!
            HouseCat simon = new HouseCat("Simon", 12.0);
            Console.WriteLine($"Simon is tired: {simon.Tired}");
            Console.WriteLine($"Simon is hungry: {simon.Hungry}");
            simon.Eat();
            simon.Sleep();
            Console.WriteLine($"Simon is tired: {simon.Tired}");
            Console.WriteLine($"Simon is hungry: {simon.Hungry}");
            Console.WriteLine(simon.Noise());
            Console.WriteLine(simon.Purr());
        }
    }
}
