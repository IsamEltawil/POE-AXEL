using System;

namespace POE_AXEL
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your name: ");
            Console.ResetColor();
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Welcome, {name}! Let's talk about cybersecurity.");
            Console.ResetColor();

            Console.WriteLine("\nChoose a topic:");
            Console.WriteLine("1. Password Safety");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice != 1)
                Console.WriteLine("Invalid choice. Try again.");

            Console.WriteLine("Choose a question:");
            Console.WriteLine("1. How can I create a strong password?");
        }
    }
}
