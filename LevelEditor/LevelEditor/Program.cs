using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    class Program
    {
        private const int windowWidth = 100;
        private const int windowHeight = 40;
        private const int gameBoardWidth = 50;
        private const int gameBoardHeight = 30;
        public static Dictionary<ConsoleKey, char> Keys = new Dictionary<ConsoleKey, char>() ;

        private void FullKeys()
        {
            Keys.Add(ConsoleKey.NumPad1, '\u250c');
            Keys.Add(ConsoleKey.NumPad2, '\u2510');
            Keys.Add(ConsoleKey.NumPad3, '\u2514');
            Keys.Add(ConsoleKey.NumPad4, '\u2518');
            Keys.Add(ConsoleKey.NumPad5, '\u2500');
            Keys.Add(ConsoleKey.NumPad6, '\u2502');
        }

        static void Main(string[] args)
        {
            Window window = new Window(windowWidth, windowHeight);
            GameBoard gameBoard = new GameBoard(gameBoardWidth, gameBoardHeight);
            Console.SetWindowSize(windowWidth, windowHeight);
            Console.SetBufferSize(windowWidth, windowHeight);
            gameBoard.DrawBorders();
            //Tools tools = new Tools(10, gameBoardHeight, 1, 0);
            Tools tools = new Tools(30, gameBoardHeight, gameBoardWidth + 10, 0);
            tools.DrawBorders();
            gameBoard.Edit();
            //ConsoleInstruments.DrawRectangle(0,0,10, 10);
            Console.ReadKey();

        }
    }
}
