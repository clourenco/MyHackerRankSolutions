using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyHackerRankSolutions.SolveMeFirstSolutionChallenge;

namespace MyHackerRankSolutionsTests.SolveMeFirstSolutionChallengeTest
{
    [TestClass]
    public class SolveMeFirstSolutionTest
    {
        [TestMethod]
        public void TheAddMethodShouldBeAbleToAddTwoNumbers()
        {
            var a = 10;
            var b = 15;
            var solveMeFirst = new SolveMeFirstSolution();

            Assert.AreEqual(solveMeFirst.Add(a, b), a + b);
        }
    }
}
