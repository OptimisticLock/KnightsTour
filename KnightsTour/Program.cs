

// Knight's tour: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Warnsdorff's rule: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Pohl: https://citeseerx.ist.psu.edu/viewdoc/download;jsessionid=FEE99ACB9A0E9055FE5D7CADBE83E2FE?doi=10.1.1.412.8410&rep=rep1&type=pdf
// Squirrel & Cull: https://github.com/douglassquirrel/warnsdorff/blob/master/5_Squirrel96.pdf

using System;

namespace KnightsTour
{
    class Matrix
    {
        public const int width = 8;
        public const int height = 8;
        public int[,] matrix = new int[8, 8];

        public static Matrix sample()
        {
            Matrix matrix = new Matrix();
            matrix.matrix[1, 1] = 1;
            matrix.matrix[2, 2] = 2;
            matrix.matrix[3, 3] = 33;
            return matrix;
        }

        public void write()
        {
            for (int y = 0; y < Matrix.height; y++)
            {
                for (int x = 0; x < Matrix.width; x++)
                    Console.Write(matrix[x, y] == 0 ? "  ." : $"{matrix[x, y],3}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    // TODO are tests required? 
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start");
            Matrix.sample().write();
            Console.WriteLine("End");

        }
    }
}
