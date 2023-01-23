using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                ShowOptions();
                tecla = Console.ReadKey();
                Console.Clear();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        Topic1();
                        break;
                    case ConsoleKey.D2:
                        Topic2();
                        break;
                    case ConsoleKey.D3:
                        Topic3();
                        break;
                    case ConsoleKey.D0:
                        MsgNextScreen("PRESS ANY KEY 2 EXIT");
                        break;
                }
            }
            while (tecla.Key != ConsoleKey.D0);
        }
        /// <summary>
        /// Function to readKey and return to main or exit
        /// </summary>
        /// <param name="msg"></param>
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
        /// <summary>
        /// This action shows a menu
        /// </summary>
        public static void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - MATHS TOPIC");
            Console.WriteLine("2 - GEOGRAPHY");
            Console.WriteLine("3 - ART");
            Console.WriteLine("0 - PRESS ANY KEY 2 EXIT");
        }

        //Marti

        //Adria
        public static void Topic2()
        {
            char answer;
            bool correct = false;

            while(!correct)
            {
                try
                {
                    Console.WriteLine("QUESTION 1");
                    Console.WriteLine("WHAT IS THE CAPITAL OF AUSTRIA: ");
                    Console.WriteLine("a) PALAFRUGELL \t");
                    Console.WriteLine("b) BARCELONA \t");
                    Console.WriteLine("c) VIENA \t");
                    Console.WriteLine("d) LISBOA \t");
                    
                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'c' || answer == 'C') Console.WriteLine("CORRECT");
                    else Console.WriteLine("WRONG!");
                    correct = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            correct = false;
            while (!correct)
            {
                try
                {
                    Console.WriteLine("QUESTION 2");
                    Console.WriteLine("IN WHICH CONTINENT CAN YOU FIND THE NILO RIVER: ");
                    Console.WriteLine("a) AFRICA \t");
                    Console.WriteLine("b) AUSTRALIA \t");
                    Console.WriteLine("c) EUROPE \t");
                    Console.WriteLine("d) SOUTH AMERICA \t");

                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'a' || answer == 'A') Console.WriteLine("CORRECT");
                    else Console.WriteLine("WRONG!");
                    correct = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            correct = false;
            while (!correct)
            {
                try
                {
                    Console.WriteLine("QUESTION 3");
                    Console.WriteLine("WHERE DOES THE PRESIDENT OF THE USA LIVE? ");
                    Console.WriteLine("a) BROOKLYN \t");
                    Console.WriteLine("b) WASHINGTON \t");
                    Console.WriteLine("c) PALERMO \t");
                    Console.WriteLine("d) LAPONIA \t");

                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'b' || answer == 'B') Console.WriteLine("CORRECT");
                    else Console.WriteLine("WRONG!");
                    correct = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            correct = false;
            while (!correct)
            {
                try
                {
                    Console.WriteLine("QUESTION 4");
                    Console.WriteLine("BARCELONA IS THE CAPITAL OF: ");
                    Console.WriteLine("a) CATALONIA \t");
                    Console.WriteLine("b) ARGENTINA \t");
                    Console.WriteLine("c) AUSTRALIA \t");
                    Console.WriteLine("d) NEW ZEALAND \t");

                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'a' || answer == 'A') Console.WriteLine("CORRECT");
                    else Console.WriteLine("WRONG!");
                    correct = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            correct = false;
        }
        //Somebody
    }
}
