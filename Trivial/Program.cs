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
        public static void Topic1()
        {
            Console.Clear();

            int correct;
            char abcd;
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("1) 35 * 12 = x");
                    correct = 35 * 12;
                    Console.WriteLine("a) 1293");
                    Console.WriteLine($"b) {correct}");
                    Console.WriteLine("c) 595");
                    Console.WriteLine("d) 340");

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    if (IsCorrectTopic1())

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("2) 12 * 9 = x");
                    correct = 12 * 9;
                    Console.WriteLine($"a) {correct}");
                    Console.WriteLine("b) y");
                    Console.WriteLine($"c) {5 * 12}");
                    Console.WriteLine("d) 340");

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("3) 11 * 9 = x");
                    correct = 11 * 9;
                    Console.WriteLine($"a) {correct}");
                    Console.WriteLine("b) 300");
                    Console.WriteLine($"c) {5 * 12}");
                    Console.WriteLine("d) 340");

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("4) 12 * 10 = x");
                    correct = 12 * 9;
                    Console.WriteLine($"a) {correct}");
                    Console.WriteLine("b) ez");
                    Console.WriteLine($"c) {11 * 11}");
                    Console.WriteLine("d) 30 april 1945");

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("5) x * 9 = 90");
                    correct = 9 / 90;
                    Console.WriteLine($"a) {correct}");
                    Console.WriteLine("b) 5");
                    Console.WriteLine($"c) 90");
                    Console.WriteLine("d) 10.1");

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        

        //Adria

        //Somebody
    }
}
