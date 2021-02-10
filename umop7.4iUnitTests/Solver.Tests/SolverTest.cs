using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass] // <= так нужно пометить класс, чтобы система тестирования начала искать в нем тесты.
    public class QuadraticEquatonSolverTest
    {
        [TestMethod] // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
        public void OrdinaryEquations()
        {
			// Arrange:
			var a = 1;
			var b = -3;
			var c = 2;

			//Act:
			var result = QuadraticEquationsSolver.Solve(a, b, c);

			//Assert:
			Assert.AreEqual(2, result.Length);
			Assert.AreEqual(2, result[0]);
			Assert.AreEqual(1, result[1]);
		}
    }
}
