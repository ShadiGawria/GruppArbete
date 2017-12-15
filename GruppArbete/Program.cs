using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbete
{
    public class Program
    {
        public static void Main()
        {
            //    ConsoleKeyInfo cki;
            //    // Prevent example from ending if CTL+C is pressed.
            //    Console.TreatControlCAsInput = true;

            //    Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            //    Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            //    do
            //    {
            //        cki = Console.ReadKey();
            //        Console.Write(" --- You pressed ");
            //        if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            //        if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            //        if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            //        Console.WriteLine(cki.Key.ToString());
            //    } while (cki.Key != ConsoleKey.Escape);
            Game game = new Game();
            GameItem item = new GameItem();

            game.Gameboard[1, 8] = item.character;
            int bound0 = game.Gameboard.GetUpperBound(0);
            int bound1 = game.Gameboard.GetUpperBound(1);

            for (int i = 0; i < bound0; i++)
            {
                for (int j = 0; j < bound1; j++)
                {
                    Console.Write($"{game.Gameboard[i, j]}");
                }
                Console.WriteLine();
            }

        }
    }
}
