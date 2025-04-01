using System;

namespace POE_AXEL
{
    class Program
    {
        static void Main()
        {
            string[] passwordQuestions = { "How can I create a strong password?", "How often should I change my password?" };
            string[] passwordAnswers = { "Use at least 12 characters with a mix of letters, numbers, and symbols.", "Change your password every few months." };

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}! Let's talk about cybersecurity.");

            Console.WriteLine("\nChoose a topic:");
            Console.WriteLine("1. Password Safety");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Choose a question:");
                for (int i = 0; i < passwordQuestions.Length; i++)
                    Console.WriteLine($"{i + 1}. {passwordQuestions[i]}");

                int qChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine($"Answer: {passwordAnswers[qChoice]}");
            }
        }
    }
}
