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
            valid = false;
            Console.Clear();
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
            valid = false;
            Console.Clear();
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
            valid = false;
            Console.Clear();
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
            valid = false;
            Console.Clear();
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
            Console.Clear();

            char abcd, correct;
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("1- FROM WHICH MOVIES IS DARTH VADER FROM?");
                    Console.WriteLine("a) STAR WARS");
                    Console.WriteLine("b) STAR TREK");
                    Console.WriteLine("c) TOY STORY");
                    Console.WriteLine("d) JURASIC PARK");
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
            valid = false;
            Console.Clear();
            while (!valid)
            {
                try
                {
                    Console.WriteLine("2- FROM WHICH MOVIE IS SPOK FROM?");
                    Console.WriteLine("a) STAR WARS");
                    Console.WriteLine("b) ALIEN");
                    Console.WriteLine("c) STAR TREK");
                    Console.WriteLine("d) PREDATOR");
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
            valid = false;
            Console.Clear();
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3- FROM WHICH SERIE IS HOMER SIMPSON FROM?");
                    Console.WriteLine("a) FAMILY GUY");
                    Console.WriteLine("b) FUTURAMA");
                    Console.WriteLine("c) THE SIMPSONS");
                    Console.WriteLine("d) THE OFFICE");
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
            valid = false;
            Console.Clear();
            while (!valid)
            {
                try
                {
                    Console.WriteLine("4- FROM WHICH MOVIES IS PETER GRIFFIN FROM?");
                    Console.WriteLine("a) THE SIMPSONS");
                    Console.WriteLine("b) FAMILY GUY");
                    Console.WriteLine("c) FRIENDS");
                    Console.WriteLine("d) BRAKING BAD");
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
            valid = false;
            Console.Clear();
            while (!valid)
            {
                try
                {
                    Console.WriteLine("5- IN WICH OF THE NEXT SERIES DRAGONS APPEAR?");
                    Console.WriteLine("a) EL CID");
                    Console.WriteLine("b) GARFIELD");
                    Console.WriteLine("c) THE OFFICE");
                    Console.WriteLine("d) GAMO OF THRONES");
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
        }
        //FOOD
        public static string Topic6() 
        {

            Console.Clear();

            char abcd, correct;
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("1- WITCH OF THE NEXT DISHES IS FORM ITALY?");
                    Console.WriteLine("a) PIZZA");
                    Console.WriteLine("b) TORTILLA DE PATATAS");
                    Console.WriteLine("c) FISH AND CHIPS");
                    Console.WriteLine("d) RAMEN");
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
            valid = false;
            Console.Clear();
            while (!valid)
            {
                try
                {
                    Console.WriteLine("2- WHICH IS NOT AN INGREDIENT FOR A CARBONARA");
                    Console.WriteLine("a) PASTA");
                    Console.WriteLine("b) BACON");
                    Console.WriteLine("c) CHEESE");
                    Console.WriteLine("d) GUANCHALE");
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
            valid = false;
            Console.Clear();
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3- WHICH IS NOT AN INGREDIENT FOR A PIZZA");
                    Console.WriteLine("a) TOMATO");
                    Console.WriteLine("b) CHEESE");
                    Console.WriteLine("c) THERE IS NO BAD INGREDIENTS");
                    Console.WriteLine("d) -->PINEAPLLE<--");
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
            valid = false;
            Console.Clear();
            while (!valid)
            {
                try
                {
                    Console.WriteLine("4- WITCH IS NOT A FRUIT");
                    Console.WriteLine("a) POTATOE");
                    Console.WriteLine("b) MANDARIN");
                    Console.WriteLine("c) MANGO");
                    Console.WriteLine("d) APPLE");
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
            valid = false;
            Console.Clear();
            while (!valid)
            {
                try
                {
                    Console.WriteLine("5- WHY IS YOUR GRANDMA THE BEST CHEF?");
                    Console.WriteLine("a) YES");
                    Console.WriteLine("b) BECAUSE SHE'S THE BEST");
                    Console.WriteLine("c) DELICIOUS");
                    Console.WriteLine("d) BECAUSE OF ME");

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    Console.WriteLine("ALL ARE CORRECT");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static bool IsCorrectTopic(char abcd, char correct)
        {
            return abcd == correct;
        }

        //Adria

        //Somebody
    }
}
