using System;
using SolverLib;

namespace Solver
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var result = QuadraticEquationSolver.Solve(a, b, c);

            if (result.Length != 0)
                Console.WriteLine(result[0]);
            else
                Console.WriteLine("NaN");
        }
    }
}
