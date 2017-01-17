using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests
{
    [TestClass()]
    public class Exercise1Tests
    {
        [TestMethod()]
        public void twoSolutions()
        {
            double a = -2;
            double b = 3;
            double c = 6;

            double[] expectedResult = { 2.63, -1.13 };
            double[] result = Exercise1.calculateQuadraticEq(a, b, c);
 
            Assert.AreEqual(expectedResult[0], result[0]);
            Assert.AreEqual(expectedResult[1], result[1]);
        }

        [TestMethod()]
        public void oneSolutions()
        {
            double a = 2;
            double b = 4;
            double c = 2;

            double[] expectedResult = {-1 };
            double[] result = Exercise1.calculateQuadraticEq(a, b, c);

            Assert.AreEqual(expectedResult[0], result[0]);
        }

        [TestMethod()]
        public void noSolutions()
        {
            double a = -4;
            double b = 2;
            double c = -5;

            double[] expectedResult = null;
            double[] result = Exercise1.calculateQuadraticEq(a, b, c);

            Assert.AreEqual(expectedResult, result);
        }
    }
}