using System;
using System.Media;

namespace POE_AXEL
{
    class Program
    {
        static void Main()
        {
            SoundPlayer axel = new SoundPlayer("AXEL.wav");
            axel.Play();

            Console.WriteLine("\nPress any key to continue or 'E' to exit.");
            string response = Console.ReadLine().ToLower();
            if (response == "e")
                return;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");
        }
    }
}
