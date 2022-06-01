using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyPersonalityToday()
            {
                Random random = new Random();

                int person = random.Next(2);

                if (person == 0) return "No Name";

                if (person == 1) return "Tyler";

                return "";
            }

            string personality = MyPersonalityToday();

            string condition = "";

            string quote = "";

            if (personality == "No Name")
            {
                condition = "Jack's Broken Heart";

                quote = "Where is my mind?";
            }

            if (personality == "Tyler")
            {
                condition = "Tyler Durden";

                quote = "It's only after we've lost everything that we're free to do anything...";
            }

            Console.WriteLine($"I'm a {condition} and I keep saying: \"{quote}\"");

            Console.ReadKey();
        }
    }
}
