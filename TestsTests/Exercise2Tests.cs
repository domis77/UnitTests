using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Tests.Tests
{
    [TestClass()]
    public class Exercise2Tests
    {
        [TestMethod()]
        public void randomNumberTest()
        {
            var executionTime = Stopwatch.StartNew();

            Exercise2.randomNumber();

            executionTime.Stop();
            Console.WriteLine(executionTime.Elapsed);
        }
    }
}