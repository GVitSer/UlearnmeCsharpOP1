using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass] // <= так нужно пометить класс, чтобы система тестирования начала искать в нем тесты.
    public class QuadraticEquatonSolverTest
    {
        void TestEquation(double a, double b, double c, double[] expectedResult)
		{
			var result = QuadraticEquationsSolver.Solve(a, b, c);

			Assert.AreEqual(expectedResult.Length, result.Length);
			for (int i = 0; i < result.Length; i++)
				Assert.AreEqual(expectedResult[i], result[i]);
		}
		[TestMethod] // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
        public void OrdinaryEquations()
        {
			TestEquation(1, -3, 2, new double[] { 2, 1 });
		}
		
		[TestMethod] // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
		public void NegativeDiscriminant()
		{
			TestEquation(1, 1, 1, new double[0] );
		}
	}
}
