using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pRoJecTLULZ
{
    class Program
    {
        static public void Main(String[] args)
        {
           // Console.SetWindowSize(120, 30);
           

            bool gameOver = false;
            bool init = false;
            Board board = new Board();
            Body body = new Body(board);
            Apple apple = new Apple();

            while (!gameOver)
            {
                if (!init)
                {
                    board.SetBoard();
                    init = true;

                }
                try 
                { 
                board.UpdateBoard();
                body.readKey();
                apple.drawApple();
                body.drawBody();
                body.Move();
                body.GrowTail(apple.ApplePos(), apple);
                body.GameOver();
                    //Console.Read();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    gameOver = true;
                }
            }
        }


    }
}
