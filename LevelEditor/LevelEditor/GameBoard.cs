using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    public class GameBoard
    {
        private readonly int gameBoardWidth;
        private readonly int gameBoardHeight;

        //public int GameBoardWidth { get; private set; }
        //public int GameBoardHeight { get; private set; }

        public GameBoard(int gameBoardWidth, int gameBoardHeight)
        {
            this.gameBoardWidth = gameBoardWidth;
            this.gameBoardHeight = gameBoardHeight;
        }

        public void DrawBorders()
        {
            ConsoleInstruments.DrawRectangle(0, 0, gameBoardWidth, gameBoardHeight);

            

        }

        public void Edit()
        {
            Console.SetCursorPosition(0, 0);
            ConsoleKeyInfo key;
            Console.ResetColor();
            Console.CursorVisible = true;

            do
            {
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft > 0)
                        {
                            Console.CursorLeft--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 0)
                        {
                            Console.CursorTop--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft + 1 < gameBoardWidth)
                        {
                            Console.CursorLeft++;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop + 1 < gameBoardHeight)
                        {
                            Console.CursorTop++;
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write('@');
                        Console.CursorLeft--;
                        break;
                    case ConsoleKey.Delete:
                        Console.Write(' ');
                        Console.CursorLeft--;
                        break;
                    case ConsoleKey.Backspace:
                        Console.Write(' ');
                        Console.CursorLeft--;
                        if (Console.CursorLeft > 0)
                        {
                            Console.CursorLeft--;
                        }
                        break;
                    default:
                        break;
                }
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
