using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHackerRankSolutions.SolveMeFirstSolutionChallenge
{
    public class SolveMeFirstSolution
    {
        public void DisplaySolveMeFirst()
        {
            Console.WriteLine("Input first value:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second value:");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = Add(a, b);

            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
