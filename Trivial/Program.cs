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

            int answer, correct;
            char abcd;
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("1) 35 * 12 = x");
                    correct = 420;
                    Console.WriteLine("a) 1293");
                    Console.WriteLine($"b) {correct}");
                    Console.WriteLine("c) 595");
                    Console.WriteLine("d) 340");

                    if (abcd != 'a' && abcd != 'b' && abcd != 'c' && abcd != 'd') throw new Exception("ENTER ONE THE OPTIONS");

                    valid = true;
                }
                try (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        

        //Adria

        //Somebody
    }
}
