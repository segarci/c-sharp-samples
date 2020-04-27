using System;

namespace c_sharp_samples
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("[1] Basic program structure");
            Console.WriteLine("Please, select option...");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Demo001();
                    break;
            }
        }

        static void Demo001()
        {
            Console.WriteLine(KilometersToMeters(1));
            Console.WriteLine(KilometersToMeters(30));
        }

        static int KilometersToMeters(int kilometers)
        {
            int factor = 1000;

            return kilometers * factor;
        }
    }
}
