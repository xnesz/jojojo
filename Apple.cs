using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pRoJecTLULZ
{
    public class Apple
    {
       public Dir apple = new Dir();

        Random random = new Random(); //
        Board board = new Board();

        public Apple()
        {
            apple.x = new Random().Next(2, board.Width);
            apple.y = new Random().Next(2, board.Height);

        }

        public void drawApple()
        {
            Console.SetCursorPosition(apple.x, apple.y);
            Console.Write("A");
        }

        public Dir ApplePos()
        {
            return apple;
        }

        public void NewApplePos()
        {
            apple.x = new Random().Next(1, board.Width);
            apple.y = new Random().Next(1, board.Height);
        }
           
    }
}
