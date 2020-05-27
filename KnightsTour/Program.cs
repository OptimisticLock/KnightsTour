

// Knight's tour: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Warnsdorff's rule: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Pohl: https://citeseerx.ist.psu.edu/viewdoc/download;jsessionid=FEE99ACB9A0E9055FE5D7CADBE83E2FE?doi=10.1.1.412.8410&rep=rep1&type=pdf
// Squirrel & Cull: https://github.com/douglassquirrel/warnsdorff/blob/master/5_Squirrel96.pdf

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace KnightsTour
{
    class Board
    {
        public const int width = 8;
        public const int height = 8;
        public int[,] matrix = new int[8, 8];
        private int visits = 0;

        public bool isAvailable(int x, int y)
        {
            return x >= 0 && y >= 0 && x < width && y < height && matrix[y, x] == 0;
        }

        public static Board sample()
        {
            Board board = new Board();
            board.matrix[1, 1] = 1;
            board.matrix[2, 2] = 2;
            board.matrix[3, 3] = 33;
            board.visit(0, 0);
            return board;
        }

        public void write()
        {
            for (int y = 0; y < Board.height; y++)
            {
                for (int x = 0; x < Board.width; x++)
                {
                    int value = matrix[x, y];
                    Console.Write(value == 0 ? "  ." : $"{value, 3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        //-------------------------------------
        public void solve()
        {
            int x = 0;
            int y = 0; 

            while (true)
            {
                var nextMove = getNextMove(x, y);

                if (nextMove == null)
                    break;

              
            }
        }


        public (int x, int y)? getNextMove(int x, int y)
        {
            (int x, int y)[] knightMoves = new (int, int)[] { (1, 2), (2, 1)};

            foreach (var move in knightMoves)
            {
                var nextX = x + move.x;
                var nextY = y + move.y;

                if (isAvailable(x, y))
                    return (x, y);
            }

            return null;
        }

        
        public bool visit(int x, int y)
        {
            Console.WriteLine("$Visiting cell ({x},{y})");

            if (matrix[x, y] > 0)
                throw new Exception("$Already visited cell ({x},{y})"); // TODO which Exception?

            matrix[x, y] = ++visits;
            return false;
        }
    }


    //================================================================

    // TODO are tests required? 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start4");
            Board board = new Board();
            board.solve();
            Board.sample().write();
            Console.WriteLine("End");
        }
    }
}
