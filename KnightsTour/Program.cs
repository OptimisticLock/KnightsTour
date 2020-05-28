

// Knight's tour: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Warnsdorff's rule: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Pohl: https://citeseerx.ist.psu.edu/viewdoc/download;jsessionid=FEE99ACB9A0E9055FE5D7CADBE83E2FE?doi=10.1.1.412.8410&rep=rep1&type=pdf
// Squirrel & Cull: https://github.com/douglassquirrel/warnsdorff/blob/master/5_Squirrel96.pdf

using System;

namespace KnightsTour
{
    //============================================
    public struct Point
    {
        public int x { get; set; }
        public int y { get; set; }


        public Point(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator +(Point p, KnightMove m)
        {
            Point p2 = new Point(p.x + m.dx, p.y + m.dy);
            return p2;
        }

        public override string ToString()
        {
            return $"{base.ToString()}: ({x},{y})";
        }
    }

    //============================================
    public struct KnightMove
    {
        public int dx { get; set; }
        public int dy { get; set; }


        public KnightMove(int dx, int dy) : this()
        {
            this.dx = dx;
            this.dy = dy;
        }
    }


    //==============================================

    class Board
    {
        public const int width = 8;
        public const int height = 8;
        public int[,] matrix = new int[8, 8];
        private int visits = 0;

        public bool isAvailable(Point point)
        {
            int x = point.x;
            int y = point.y;
            return x >= 0 && y >= 0 && x < width && y < height && matrix[x, y] == 0;
        }

        //public static Board sample()
        //{
        //    Board board = new Board();
        //    board.matrix[1, 1] = 1;
        //    board.matrix[2, 2] = 2;
        //    board.matrix[3, 3] = 33;
        //    board.visit(0, 0);
        //    return board;
        //}

        public void write()
        {
            for (int y = 0; y < Board.height; y++)
            {
                for (int x = 0; x < Board.width; x++)
                {
                    int value = matrix[x, y];
                    Console.Write(value == 0 ? "  ." : $"{value,3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        //-------------------------------------
        public void solve()
        {
            Point? point = new Point(0, 0);

            do
            {
                visit((Point)point);
                point = getNextMove((Point)point);

            } while (point != null);
        }


        public Point? getNextMove(Point point)
        {
            // TODO: offset, not Point
            var knightMoves = new KnightMove[]
            {
                new KnightMove(dx:-2, dy:-1),
                new KnightMove(dx:-1, dy:-2),
                new KnightMove(dx:-1, dy:2),
                new KnightMove(dx:-2, dy:1),
                new KnightMove(dx:1, dy:-2),
                new KnightMove(dx:2, dy:-1),
                new KnightMove(dx:1, dy:2),
                new KnightMove(dx:2, dy:1)
            };

            foreach (var move in knightMoves)
            {
                Point nextPoint = point + move;

                if (isAvailable(nextPoint))
                    return (nextPoint);
            }

            return null;
        }


        public void visit(Point point)
        {
            int x = point.x;
            int y = point.y;

            Console.WriteLine($"Visit # {visits} cell ({x},{y})");


            // TODO x,y or y,x?

            if (matrix[x, y] > 0)
                throw new Exception($"Already visited cell ({x},{y})"); // TODO which Exception?

            matrix[x, y] = ++visits;
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
            board.write();
            Console.WriteLine("End");
        }
    }
}