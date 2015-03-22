using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    class Tools
    {
        private readonly int width;
        private readonly int height;
        private readonly int x;
        private readonly int y;
        private const int shiftText = 3;
        private int rowNumberText = 1;
        private int columnNumberText;

        

        //enum Keys
        //{
        //    key1, key2, key3, key4;
        //}

        public Tools(int width, int height, int x, int y)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.columnNumberText = x + 1;

            
        }

        private void PrintString(string message)
        {
            Console.SetCursorPosition(columnNumberText, rowNumberText);
            Console.WriteLine(message);
            rowNumberText++;
        }

        private void FullInformation()
        {
            var curElementInKeys = Program.Keys.GetEnumerator();
            while (!curElementInKeys.MoveNext())
            {
                PrintString(String.Format("{0} - {1}", curElementInKeys.Current.Key.ToString(),
                    curElementInKeys.Current.Value.ToString()));
            }
        }


        public void DrawBorders()
        {
            ConsoleInstruments.DrawRectangle(x, y, x + width, y + height);
            //FullInformation();
        }
    }
}
