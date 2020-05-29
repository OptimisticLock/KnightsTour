using System;

namespace KnightsTour
{
    public struct Cell
    {
        public int col { get; set; }
        public int row { get; set; }


        public Cell(int col, int row) : this()
        {
            this.col = col;
            this.row = row;
        }

        public static Cell operator +(Cell cell, Knight.Move move)
        {
            return new Cell(cell.row + move.rows, cell.col + move.cols);
        }

        public override string ToString()
        {
            return $"{base.ToString()}: ({col},{row})";
        }
    }
}
