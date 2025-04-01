using System;
using System.Media;
using System.Threading;

namespace POE_AXEL
{
    class TasksandVoice
    {
        static SoundPlayer axel = new SoundPlayer("AXEL.wav");
        static string name;
        static bool inConversation;
        static int option;
        static string response, personal, question, exit3;

        static string[] Password =
        {
            "\n1.How can I create a strong password?",
            "2.How often should I change my password?",
            "3.Is it safe to use the same password for multiple accounts?",
            "4.What’s the best way to store my passwords securely?",
            "5.Are password managers safe to use?"
        };

        static string[] Phishing =
        {
            "1.What is phishing, and how does it work?",
            "2.How do I recognize a phishing email?",
            "3.What should I do if I clicked on a phishing link?",
            "4.How can I tell if a website is fake?"
        };

        static string[] SafeBrowsing =
        {
            "1.How do I know if a website is safe?",
            "2.What is HTTPS, and why is it important?",
            "3.Can I get hacked just by visiting a website?",
            "4.How do I block malicious websites?"
        };

        static string[] PasswordAnswers =
        {
            "Use at least 12 characters with a mix of uppercase, lowercase, numbers, and symbols.",
            "Change your password every few months, especially if it’s been leaked.",
            "No, using the same password for multiple accounts makes you vulnerable to breaches.",
            "Use a reputable password manager or write them down in a secure location.",
            "Yes, reputable password managers encrypt and store passwords safely."
        };

        static string[] PhishingAnswers =
        {
            "Phishing is a scam where attackers trick you into revealing sensitive info (like passwords) via fake emails, messages, or websites.",
            "Look for misspellings, urgent language, unfamiliar senders, or links that don’t match the real website.",
            "Disconnect from the internet, run a malware scan, and change your passwords immediately.",
            "Check for HTTPS, look for spelling errors, and never enter your password if the URL seems suspicious."
        };

        static string[] SafeBrowsingAnswers =
        {
            "Check for HTTPS, look for trust seals, and avoid entering details on unfamiliar sites.",
            "HTTPS encrypts data, making it safer from hackers compared to HTTP.",
            "Yes, if it has malware or exploit kits.",
            "Use browser security settings, antivirus software, or browser extensions like uBlock Origin."
        };

        static string rl()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input;
            while (true)
            {
                input = Console.ReadLine()?.Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) break;
                Console.Write("Input cannot be empty. Please try again: ");
            }
            Console.ResetColor();
            return input;
        }

        static void TypeText(string text, int speed = 30)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        static string GetSafeArrayValue(string[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                TypeText("Invalid choice. Please pick a valid number.");
                return null;
            }
            return array[index];
        }

        public static void user()
        {

            char t = (char)45;
            char j = (char)124;

            Logo.logo();

            axel.Play();
            TypeText("\n\nPress any key to continue with the cybersecurity chatbot or 'E' to exit", 20);
            response = rl();

            if (response == "e")
            {
                Environment.Exit(0);
            }

            TypeText("\nWhat's your name: ");
            name = rl();

            TypeText($"\nWelcome {name}! Let's get started.");

            while (true)
            {
                TypeText("\n\nWhat are you interested in 1.Password safety, 2. Phishing and 3. Safe browsing");
                option = Convert.ToInt32(rl());

                if (option == 1)
                {
                    


                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //2 horizontal frame lines
                    for (int n = 0; n < 100; n++)
                    {
                        Console.Write(t);
                        if (n == 49)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\n");
                        }

                    }

                    //skip lines between loops




                    Console.Write("\n");

                    //vertical border for frame
                    for (int y = 0; y < 2; y++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(j + "                                                " + j);

                        if (y == 1)
                        {

                            Console.Write(j + "   Passwords             " + j);
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;


                    Console.WriteLine();

                    //2 horizontal frame lines
                    for (int l = 0; l <= 100; l++)
                    {
                        Console.Write(t);
                        if (l == 49)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(t);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                   


                    Console.ResetColor();
                    TypeText("\n\n\nHere are the Options for the Password safety questions: \n");

                    for (int i = 0; i < Password.Length; i++)
                    {
                        TypeText(Password[i]);
                    }
                    TypeText("\n\nPick a number and I'll answer You\t");
                    option = Convert.ToInt32(rl()) - 1;
                    string answer = GetSafeArrayValue(PasswordAnswers, option);
                    if (answer != null) TypeText(answer);
                }

                if (option == 2)
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    //2 horizontal frame lines
                    for (int n = 0; n < 100; n++)
                    {
                        Console.Write(t);
                        if (n == 49)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\n");
                        }

                    }

                    //skip lines between loops




                    Console.Write("\n");

                    //vertical border for frame
                    for (int y = 0; y < 2; y++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(j + "                                                " + j);

                        if (y == 1)
                        {

                            Console.Write(j + "   Phishing       " + j);
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;


                    Console.WriteLine();

                    //2 horizontal frame lines
                    for (int l = 0; l <= 100; l++)
                    {
                        Console.Write(t);
                        if (l == 49)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(t);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;



                    Console.ResetColor();
                    TypeText("\n\n\nHere are the Options for the Phishing questions: \n");
                    for (int i = 0; i < Phishing.Length; i++)
                    {
                        TypeText(Phishing[i]);
                    }
                    TypeText("\n\nPick a number and I'll answer You\t");
                    option = Convert.ToInt32(rl()) - 1;
                    string answer = GetSafeArrayValue(PhishingAnswers, option);
                    if (answer != null) TypeText(answer);
                }

                if (option == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //2 horizontal frame lines
                    for (int n = 0; n < 100; n++)
                    {
                        Console.Write(t);
                        if (n == 49)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\n");
                        }

                    }

                    //skip lines between loops




                    Console.Write("\n");

                    //vertical border for frame
                    for (int y = 0; y < 2; y++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(j + "                                                " + j);

                        if (y == 1)
                        {

                            Console.Write(j + "   Safe Browing      " + j);
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;


                    Console.WriteLine();

                    //2 horizontal frame lines
                    for (int l = 0; l <= 100; l++)
                    {
                        Console.Write(t);
                        if (l == 49)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(t);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;



                    Console.ResetColor();
                    TypeText("\n\n\nHere are the Options for the Safe Browsing questions: \n");
                    for (int i = 0; i < SafeBrowsing.Length; i++)
                    {
                        TypeText(SafeBrowsing[i]);
                    }
                    TypeText("\n\nPick a number and I'll answer You\t");


                    option = Convert.ToInt32(rl()) - 1;
                    //makes sure the answer fits in the array so if the user entered a number that isnt part of the array it allows the user to try again
                    string answer = GetSafeArrayValue(SafeBrowsingAnswers, option);
                    if (answer != null) TypeText(answer);
                }
            }
        }
    }
}