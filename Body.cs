﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pRoJecTLULZ
{
    public class Body
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        ConsoleKey currentDirection = ConsoleKey.D;
        Board board;

        List<Dir> bodyDir;
        public int x { get; set; }
        public int y { get; set; }

        public Body(Board board)
        {
            x = 15;
            y = 15;

            bodyDir = new List<Dir>();
            bodyDir.Add(new Dir(x, y));
            this.board = board;
        }
       

        public void drawBody()
        {
            foreach(Dir dir in bodyDir)
            {
                Console.SetCursorPosition(dir.x, dir.y);
                Console.Write("■");
            }
        }


        public void readKey()
        {
            if(Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                
                direction(keyInfo.Key);
            }
        }

        private void direction(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W:
                case ConsoleKey.A:
                case ConsoleKey.S:
                case ConsoleKey.D:
                    currentDirection = key;
                    break;
            }
        }


        public void Move()
        {
            //direction(key);
            switch (currentDirection)
            {
                case ConsoleKey.W:
                    y--;  //mby x, y, or dir xy 
                    break;
                case ConsoleKey.A:
                    x--;
                    break;
                case ConsoleKey.S:
                    y++;
                    break;
                case ConsoleKey.D:
                    x++;
                    break;
            }
            bodyDir.Add(new Dir(x, y));
            board.AddToClear(bodyDir.First());
            bodyDir.RemoveAt(0); //draw all snakie
            Thread.Sleep(100);
            if (currentDirection == ConsoleKey.W || currentDirection == ConsoleKey.S)
            {
                Thread.Sleep(100);
            }
           
        }
        public void GrowTail(Dir Apple, Apple a)
        {
            Dir head = bodyDir[bodyDir.Count - 1];

            if(head.x == Apple.x && head.y == Apple.y)
            {
                bodyDir.Add(new Dir(x,y));
                a.NewApplePos();
            }
        }

        public void GameOver()
        {
            Dir head = bodyDir[bodyDir.Count - 1];
            for(int i = 0; i < bodyDir.Count -2; i++)
            {
                Dir bod = (Dir)bodyDir[i];
                if (head.x == bod.x && head.y == bod.y) //collide w itself
                {
                    throw new Exception("YOU LOST!"); //throw new exceot
                }

            }
        }

        public void HitBoard()
        {
            Dir head = bodyDir[bodyDir.Count - 1];
            if (head.x <= 0 || head.x >= board.Width - 1 || head.y <= 0 || head.y >= board.Height - 1)
                //gameOver = true;
            //Dir head = bodyDir[bodyDir.Count - 1];
           // if (head.x >= board.Width || head.x <= 0 || head.y >= board.Height || head.y <= 0)
            {
                throw new Exception("YOU SUCK");
            }
        }
    }

}
