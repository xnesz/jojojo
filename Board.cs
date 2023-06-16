using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pRoJecTLULZ
{
    public class Board
    {
        public int Width = 50;
        public int Height = 25;

        List<Dir> ToClear = new List<Dir>();

        public Board()
        {
            Console.CursorVisible = false;
        }

        public void SetBoard()
        {
            Console.Clear();   

            for (int i = 2; i < Width; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("═╗");
            }


            for (int i = 2; i < Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.Write("═╝");
            }


            for (int i = 2; i < Height; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("║");
            }
            for (int i = 2; i < Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write("║");
            }

           /* for (int i = 1; i < Width;)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("╔");
            }*/

        }

        public void AddToClear(Dir toAdd)
        {
            ToClear.Add(toAdd);
        }

        public void UpdateBoard()
        {
            foreach (Dir dir in ToClear)
            {
                Console.SetCursorPosition(dir.x, dir.y);
                Console.Write(" ");
            }
        }
        
      
    
    
    
    }
}
