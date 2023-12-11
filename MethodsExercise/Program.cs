using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please introduce your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please tell me your least favorite color");
            string color = Console.ReadLine();
            Console.WriteLine("Tell me the name of your mascot");
            string mascot = Console.ReadLine();
            Console.WriteLine("Where are you from?");
            string country = Console.ReadLine();
            Console.WriteLine("Tell me your least favorite person");
            string villain = Console.ReadLine();

            ShortStory(name, color, mascot, country, villain);

        }
        public static void ShortStory(string name, string color, string mascot, string country, string villain)
        {
            Console.WriteLine($"Hello {name}, this is the story of the next birthday you will have, you\n" +
                $"can decide whether you can believe it, on the day {mascot} your trusty companion\n" + 
                $"will transform in to your worst enemy, {villain}, with a plan on changing the color\n" + 
                $"of the sky to {color} in {country} to at last conquer the world, be prepared to stop it!");
        }
    }
}
