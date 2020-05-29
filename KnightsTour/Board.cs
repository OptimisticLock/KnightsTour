using System;
namespace KnightsTour
{

    //==============================================

    class Board
    {
        public const int width = 8;
        public const int height = 8;
        public int[,] matrix = new int[8, 8];
        private int visits = 0;

        // A cell is available if it's valid and empty.
        public bool isAvailable(Cell cell)
        {
            int col = cell.col;
            int row = cell.row;
            return col >= 0 && row >= 0 && col < width && row < height && matrix[col, row] == 0;
        }


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

        public void solve()
        {
            Cell? cell = new Cell(0, 0);

            do
            {
                visit((Cell)cell);
                cell = getNextMove((Cell)cell);

            } while (cell != null);
        }


        public Cell? getNextMove(Cell cell)
        {
            foreach (var move in Knight.moves)
            {
                Cell nextCell = cell + move;

                if (isAvailable(nextCell))
                    return (nextCell);
            }

            return null;
        }


        public void visit(Cell cell)
        {
            int col = cell.col;
            int row = cell.row;

            Console.WriteLine($"Visit # {visits} cell ({col},{row})");


            // TODO x,y or y,x?

            if (matrix[col, row] > 0)
                throw new InvalidOperationException($"Already visited cell ({col},{row})"); 

            matrix[col, row] = ++visits;
        }
    }
}
