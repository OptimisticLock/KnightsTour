using System;
namespace KnightsTour
{
    public class Knight
    {
        public struct Move
        {
            public int cols { get; set; }
            public int rows { get; set; }

            public Move(int cols, int rows) : this()
            {
                this.cols = cols;
                this.rows = rows;
            }
        }

        public static Move[] moves =
        {
            new Move(-1, -2),
            new Move(-2, -1),

            new Move(1, -2),
            new Move(2, -1),

            new Move(1, 2),
            new Move(2, 1),

            new Move(-1, 2),
            new Move(-2, 1),
        }; 
    }
}
