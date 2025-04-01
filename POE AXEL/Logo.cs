using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POE_AXEL
{
   
    class Logo
    {
        public static string response;
        public static void logo()
        {
            char a = (char)47;//  /
            char b = (char)92;//  \
            char c = (char)95; //  _

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("     "+a+""+b);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("    "+a+"  "+b);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   "+a+" "+a+""+b+" "+b);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  "+a+" "+a+""+c+c+""+b+" "+b);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" "+a+"  "+c+c+c+c+"  "+b+"   " );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" "+c+c+""+a+"    "+b+""+c+c+"   ");
           

            

            char t = (char)45;
            char j = (char)124;


            int i;
            Console.ForegroundColor = ConsoleColor.Blue;
            //2 horizontal frame lines
            for (i = 0; i < 100; i++)
            {
                Console.Write(t);
                if(i == 49)
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

                    Console.Write(j + "   ADVANCED X-SECURITY & ENCRYPTION LOGIC       " + j);
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
            Console.WriteLine("\nWelcome");


            Console.ResetColor();

        }
    }
}
