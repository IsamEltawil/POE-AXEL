using System;

namespace POE_AXEL
{
    class Program
    {
        static void Main()
        {
            string[] passwordQuestions = { "How can I create a strong password?", "How often should I change my password?" };
            string[] phishingQuestions = { "What is phishing?", "How do I recognize a phishing email?" };

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}! Let's talk about cybersecurity.");

            Console.WriteLine("\nChoose a topic:");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Choose a question:");
                for (int i = 0; i < passwordQuestions.Length; i++)
                    Console.WriteLine($"{i + 1}. {passwordQuestions[i]}");

                int qChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine($"Answer: [Placeholder]");
            }
        }
    }
}
