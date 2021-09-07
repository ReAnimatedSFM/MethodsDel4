using System;
using System.Windows.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDel4
{
    class Program
    {

        static bool isPositive(int val)
        {
            bool result;
            if (val > 0)
            {
                result = true;
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }

        private static string ToString(char[] a)
        {
            string b = new string(a);
            return b;
        }

        private static string Generate()
        {
            Random rnd = new Random();
            int value1 = rnd.Next(3, 10);
            char randomChar;
            char[] charArray = new char['a'];
            for (int i = 0; i < value1; i++)
            {
                int intRandom = rnd.Next(0, 26);
                randomChar = (char)('a' + intRandom);
                charArray[i] = randomChar;
            }
            string str = new string(charArray); 
            return str;
        }

            private static int RandomNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            return num;
        }

            private static void Menu()
            {

            //Print
            Console.WriteLine("Velkommen til mit program! Hvis du ønsker at lege med tilfældigheder så tryk blot på 1 på tastaturet");
            Console.WriteLine("Hvis du ønsker at lege med tal så indtaster du bare 2 på tastaturet");
            Console.WriteLine("Tryk på ESCAPE for at afslutte programmet");
            Console.WriteLine("\n-----Hovedmenu-----\n1. Tilfældigeheder\n2. Tal\n\n-----ESCAPE-----\nLukker programmet");

            //Input
            ConsoleKey x = Console.ReadKey().Key;

            //Menustart
            if (x == ConsoleKey.D1 || x == ConsoleKey.NumPad1)
            {
                //Delete print
                Console.Clear();

                //Text Navigation / Print
                Console.WriteLine("-----Tilfældigheder-----\n1. Print et tilfældigt tal\n2. Print en tilfældig streng\n\n-----BackSpace-----\nTilbage til hovedmenu");

                //Input
                ConsoleKey y = Console.ReadKey().Key;

                //Navigation
                if (y == ConsoleKey.D1 || y == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    Console.WriteLine("Dit tilfældige tal er: " + RandomNumber());
                }
                else if (y == ConsoleKey.D2 || y == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    Console.WriteLine($"Din tilfældige streng er: {Generate()}");
                }
                else if (y == ConsoleKey.Backspace) //Back
                {
                    Application.Restart();
                    Environment.Exit(1);
                }
            }

            //Navigation
            else if (x == ConsoleKey.D2 || x == ConsoleKey.NumPad2)
            {
                //Delete print
                Console.Clear();

                //Print
                Console.WriteLine("-----Tal-----\n1. Er tallet positivt?\n2. Kvadrat og rod.\n\n-----BackSpace-----\nTilbage til hovedmenu");

                //Input
                ConsoleKey h = Console.ReadKey().Key;

                //Navigation
                if (h == ConsoleKey.D1 || h == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    Console.Write("Indtast et heltal: ");

                    int k = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(isPositive(k));
                }
                else if (h == ConsoleKey.D2 || h == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    Console.Write("Indtast et heltal: ");

                    int k = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine(Calculate(k));
                }
                else if (h == ConsoleKey.Backspace) //Back
                {
                    Application.Restart();
                    Environment.Exit(1);
                }

            //Exit Application
            }
            else if (x == ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
            
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Tryk på enter for at starte menuen :)");

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.Enter)
            {
                Console.Clear();
                Menu();
            }
            else if (userInput == ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
            else
            {
                Application.Restart();
                Environment.Exit(1);
            }

            Console.ReadKey();
        }



        private static (double, double) Calculate(int val1)
        {
            if (val1 > 0)
            {
                double squareRoot = Math.Sqrt(val1);
                double squared = val1 * val1;
                Console.WriteLine("Input was " + isPositive(val1));
                return (squared, squareRoot);
            }
            else
            {
                Console.Clear();
                double squareRoot = Math.Sqrt(val1);
                double squared = val1 * val1;
                Console.WriteLine("Input was " + isPositive(val1));
                return (squared, squareRoot);
            }
        }
    }
}
