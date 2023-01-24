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
                    case ConsoleKey.D3:
                        Topic4();
                        break;
                    case ConsoleKey.D3:
                        Topic5();
                        break;
                    case ConsoleKey.D3:
                        Topic6();
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
        //HISTORY 
        public static string Topic4() 
        {
            Console.Clear();

            char abcd, correct;
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("1- WHEN IS THE FIRST WORLD WAR STARTED?");
                    Console.WriteLine("a) 1900");
                    Console.WriteLine("b) 2023");
                    Console.WriteLine("c) 1910");
                    Console.WriteLine("d) 1890");
                    correct = 'c';

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    if (IsCorrectTopic(abcd, correct)) Console.WriteLine("CORRECT!! GOOD JOB");
                    else Console.WriteLine("WRONG!! NICE TRY");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (!valid)
            {
                try
                {
                    Console.WriteLine("2- WHO IS THE FIRST PRESIDENT OF THE UNITED STATES?");
                    Console.WriteLine("a) PERRO SANCHEZ");
                    Console.WriteLine("b) WASHINGTON");
                    Console.WriteLine("c) OBAMA");
                    Console.WriteLine("d) TRUMP");
                    correct = 'b';

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    if (IsCorrectTopic(abcd, correct)) Console.WriteLine("CORRECT!! GOOD JOB");
                    else Console.WriteLine("WRONG!! NICE TRY");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3- WHERE IS NAPOLEON BONAPARTE FROM?");
                    Console.WriteLine("a) SPAIN");
                    Console.WriteLine("b) UNITED KINDOM");
                    Console.WriteLine("c) ITALY");
                    Console.WriteLine("d) FRANCE");
                    correct = 'd';

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    if (IsCorrectTopic(abcd, correct)) Console.WriteLine("CORRECT!! GOOD JOB");
                    else Console.WriteLine("WRONG!! NICE TRY");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (!valid)
            {
                try
                {
                    Console.WriteLine("4- WHERE IS JULIUS CESAR FROM?");
                    Console.WriteLine("a) ROME");
                    Console.WriteLine("b) PARIS");
                    Console.WriteLine("c) MADRID");
                    Console.WriteLine("d) NOVA YORK");
                    correct = 'a';

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    if (IsCorrectTopic(abcd, correct)) Console.WriteLine("CORRECT!! GOOD JOB");
                    else Console.WriteLine("WRONG!! NICE TRY");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (!valid)
            {
                try
                {
                    Console.WriteLine("5- WHEN WAS THE BERLIN WALL REMOVED?");
                    Console.WriteLine("a) 2000");
                    Console.WriteLine("b) 1989");
                    Console.WriteLine("c) 1900");
                    Console.WriteLine("d) 1970");
                    correct = 'b';

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    if (IsCorrectTopic(abcd, correct)) Console.WriteLine("CORRECT!! GOOD JOB");
                    else Console.WriteLine("WRONG!! NICE TRY");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        //SERIES AND MOVIES
        public static string Topic5() 
        {
            
        }
        //FOOD
        public static string Topic6() 
        {

        }
        public static bool IsCorrectTopic(char abcd, char correct)
        {
            return abcd == correct;
        }

        //Adria

        //Somebody
    }
}
