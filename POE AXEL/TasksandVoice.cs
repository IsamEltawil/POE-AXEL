using System;

namespace POE_AXEL
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}! Let's talk about cybersecurity.");

            Console.WriteLine("\nChoose a topic:");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing");
            Console.WriteLine("3. Safe Browsing");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You selected option {choice}.");
        }
    }
}
