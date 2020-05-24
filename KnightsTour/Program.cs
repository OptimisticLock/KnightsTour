

// Knight's tour: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Warnsdorff's rule: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Pohl: https://citeseerx.ist.psu.edu/viewdoc/download;jsessionid=FEE99ACB9A0E9055FE5D7CADBE83E2FE?doi=10.1.1.412.8410&rep=rep1&type=pdf
// Squirrel & Cull: https://github.com/douglassquirrel/warnsdorff/blob/master/5_Squirrel96.pdf

using System;

namespace KnightsTour
{

    // TODO are tests required? 
    class Program
    {
        static void Main(string[] args)
        {
            const int width = 8;
            const int height = 8;

            Console.WriteLine("Start");

            int[,] matrix = new int[8, 8];
            matrix[1, 1] = 1;
            matrix[2, 2] = 2;
            matrix[3, 3] = 33;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    Console.Write(matrix[x, y] == 0 ? "  ." : $"{matrix[x, y], 3}");           
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
