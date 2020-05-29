

// Knight's tour: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Warnsdorff's rule: https://en.wikipedia.org/wiki/Knight%27s_tour#Warnsdorff's_rule
// Pohl: https://citeseerx.ist.psu.edu/viewdoc/download;jsessionid=FEE99ACB9A0E9055FE5D7CADBE83E2FE?doi=10.1.1.412.8410&rep=rep1&type=pdf
// Squirrel & Cull: https://github.com/douglassquirrel/warnsdorff/blob/master/5_Squirrel96.pdf

using System;

namespace KnightsTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start5");
            Board board = new Board();
            board.solve();
            board.write();
            Console.WriteLine("End");
        }
    }
}