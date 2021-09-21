using System;
using System.Media;

namespace Zahl_erraten_leanojohn
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Willkommen, geben Sie eine Zahl zwischen 1 und 100 ein");
            Random rd = new Random();
            int rand_num = rd.Next(1, 100);
            int versuche = 0;
            int usereingabe = 0;
            while (usereingabe != rand_num)
            {
                if (usereingabe >= 77 && usereingabe <= 77)
                {
                    {
                        string txt = "Sie haben die Glückszahl gefunden, WOW" +
                            "(^--^)";

                        while (true)
                        {
                            WriteBlinkingText(txt, 500, true);
                            WriteBlinkingText(txt, 500, false);
                        }
                    }
                }
                string input = Console.ReadLine();
                versuche++;

                if (!int.TryParse(input, out usereingabe))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("HALLO? Geben Sie bitte eine Zahl ein!!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    if (usereingabe >= 101)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Das ist keine gültige Eingabe, geben Sie eine Zahl zwischen 1 und 100 ein");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (usereingabe <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Das ist keine gültige Eingabe, geben Sie eine Zahl zwischen 1 und 100 ein");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (rand_num == usereingabe)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Glückwunsch Sie haben die Zahl herausgefunden.");
                        Console.WriteLine("Sie haben " + versuche + " Versuche gebraucht.");
                        Environment.Exit(1);
                    }
                    if (usereingabe < rand_num && usereingabe >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zu klein, versuchen Sie es nochmals");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (usereingabe > rand_num && usereingabe <= 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zu gross, versuchen Sie es nochmals");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }
        }
        private static void WriteBlinkingText(string text, int delay, bool visible)
        {
            if (visible)
                Console.Write(text);
            else
                for (int i = 0; i < text.Length; i++)
                    Console.Write(" ");
            Console.CursorLeft -= text.Length;
            System.Threading.Thread.Sleep(delay);
        }
    }
}
