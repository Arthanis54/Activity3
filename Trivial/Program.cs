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
        /// <summary>
        ///This action display a quiz about maths.
        /// </summary>
        public static void Topic1()
        {
            char answer;
            bool correct = false;

            while (!correct)
            {
                try
                {
                    Console.WriteLine("QUESTION 1");
                    Console.WriteLine("1 + 1 = ");
                    Console.WriteLine("a) 2 \t");
                    Console.WriteLine("b) r \t");
                    Console.WriteLine("c) 24 \t");
                    Console.WriteLine("d) i \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'A') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("How much a litre of water weights?: ");
                    Console.WriteLine("a) 1kg \t");
                    Console.WriteLine("b) 2oz \t");
                    Console.WriteLine("c) 24m \t");
                    Console.WriteLine("d) 64sec \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'A') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("Who discovered E=MC2 ");
                    Console.WriteLine("a) GEORGE BUSH \t");
                    Console.WriteLine("b) ALBERT EINSTEIN \t");
                    Console.WriteLine("c) GUILLERMO DEL TORO \t");
                    Console.WriteLine("d) MARIO BROS \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'B') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("2 x 6 = ");
                    Console.WriteLine("a) 12 \t");
                    Console.WriteLine("b) 56 \t");
                    Console.WriteLine("c) 76 \t");
                    Console.WriteLine("d) 2*PI*r \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'A') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("QUESTION 5");
                    Console.WriteLine("What does MCD means? ");
                    Console.WriteLine("a) Marvel Cinematic Duniverse \t");
                    Console.WriteLine("b) Maximum Common divisor \t");
                    Console.WriteLine("c) Marvelous Caronte Driver \t");
                    Console.WriteLine("d) MegaCinnamon Dance \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'B') Console.WriteLine("CORRECT");
                    else Console.WriteLine("WRONG!");
                    correct = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
        /// <summary>
        /// This action displays a quiz about geography.
        /// </summary>
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
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'C') Console.WriteLine("CORRECT");
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
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'A') Console.WriteLine("CORRECT");
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
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'B') Console.WriteLine("CORRECT");
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
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'A') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("QUESTION 5");
                    Console.WriteLine("IN WHICH COUNTRY CAN YOU FIND THE CONGO RIVER?");
                    Console.WriteLine("a) SOMALIA \t");
                    Console.WriteLine("b) CONGO \t");
                    Console.WriteLine("c) FRANCE \t");
                    Console.WriteLine("d) JAPAN \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'B') Console.WriteLine("CORRECT");
                    else Console.WriteLine("WRONG!");
                    correct = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
        /// <summary>
        /// This action displays a quiz about art.
        /// </summary>
        public static void Topic3()
        {
            char answer;
            bool correct = false;

            while (!correct)
            {
                try
                {
                    Console.WriteLine("QUESTION 1");
                    Console.WriteLine("Who painted the Guernica? ");
                    Console.WriteLine("a) SALVADOR DALÍ \t");
                    Console.WriteLine("b) ADRIÀ FERRER \t");
                    Console.WriteLine("c) PABLO PICASSO \t");
                    Console.WriteLine("d) DALL E AI \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'C') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("WHICH COMPANY CREATED MARIO BROS? ");
                    Console.WriteLine("a) NINTENDO \t");
                    Console.WriteLine("b) SONY \t");
                    Console.WriteLine("c) MICROSOFT \t");
                    Console.WriteLine("d) BADOO \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'A') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("WHO WROTE THE WITCHER BOOK SAGA ");
                    Console.WriteLine("a) JACINTO PALAU \t");
                    Console.WriteLine("b) ANDRZEJ SAPKOWSKI \t");
                    Console.WriteLine("c) J.R.R.TOLKIEN \t");
                    Console.WriteLine("d) J.K.ROWLING \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'B') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("WHO COMPOSED HIGHWAY TO HELL ");
                    Console.WriteLine("a) AC/DC \t");
                    Console.WriteLine("b) JOAN MANUEL SERRAT \t");
                    Console.WriteLine("c) OASIS \t");
                    Console.WriteLine("d) JOSE LUIS PERALES \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'A') Console.WriteLine("CORRECT");
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
                    Console.WriteLine("QUESTION 5");
                    Console.WriteLine("WHO IS THE BEST GUITARRIST?");
                    Console.WriteLine("a) JIMI HENDRIX \t");
                    Console.WriteLine("b) ERIC CLAPTON \t");
                    Console.WriteLine("c) B.B.KING \t");
                    Console.WriteLine("d) ALBERT KING \t");

                    answer = Convert.ToChar(Console.ReadLine());
                    answer = Char.ToUpper(answer);

                    if (answer < 'A' || answer > 'Z') throw new Exception("Wrong input, try again");
                    else if (answer == 'B') Console.WriteLine("CORRECT");
                    else Console.WriteLine("WRONG!");
                    correct = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
    }
}
