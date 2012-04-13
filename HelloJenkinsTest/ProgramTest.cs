using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace HelloJenkinsTest
{
    [TestFixture]
    class ProgramTest
    {
        [Test]
        public void ProgramTestMethod()
        {
            int expected = 1, actual = 1;

            Assert.AreEqual(expected, actual, "The expected and actual results were different.");
        }
    }
}
