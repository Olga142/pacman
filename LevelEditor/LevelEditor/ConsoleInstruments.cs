using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    public static class ConsoleInstruments
    {
        public static void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            if (!(x1 >= 0 && x2 >= 0 && x1 < Console.WindowWidth && x2 < Console.WindowWidth
                  && y1 >= 0 && y2 >= 0 && y1 < Console.WindowHeight && y2 < Console.WindowHeight))
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.SetCursorPosition(x1, y1);
            Console.Write('\u250c');
            Console.SetCursorPosition(x2 - 1, y1);
            Console.Write('\u2510');
            Console.SetCursorPosition(x1, y2 - 1);
            Console.Write('\u2514');
            Console.SetCursorPosition(x2- 1, y2 - 1);
            Console.Write('\u2518');

            for (int x = x1 + 1; x < x2 - 1; x++)
            {
                Console.SetCursorPosition(x, y1);
                Console.Write('\u2500');
                Console.SetCursorPosition(x, y2 - 1);
                Console.Write('\u2500');
            }

            for (int y = y1 + 1; y < y2 - 1; y++)
            {
                Console.SetCursorPosition(x1, y);
                Console.Write('\u2502');
                Console.SetCursorPosition(x2 - 1, y);
                Console.Write('\u2502');
            }
        }
    }
}
