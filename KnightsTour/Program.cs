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
            int[,] matrix = new int[8, 8];
            matrix[1, 1] = 1;
            matrix[2, 2] = 2;
            matrix[3, 3] = 33;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    Console.Write($"{matrix[x, y], 3}");
                Console.WriteLine();
            }
            Console.WriteLine("Done");

        }
    }
}
