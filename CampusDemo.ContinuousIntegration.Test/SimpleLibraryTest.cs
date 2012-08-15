using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CampusDemo.ContinuousIntegration.SimpleLibrary;

namespace Campus.Demo.ContinuousIntegration.Test
{
    [TestFixture]
    public class SimpleLibraryTest
    {
        private CampusDemo.ContinuousIntegration.SimpleLibrary.Math _math;

        [TestFixtureSetUp]
        public void SetUpFixture()
        {
            _math = new CampusDemo.ContinuousIntegration.SimpleLibrary.Math();
        }

        [Test]
        public void SumTest()
        {
            int x = 2, y = 3, expected = 5, actual;

            actual=_math.Sum(x, y);

            Assert.AreEqual(expected, actual, "The value returned was different than the expected value.");
            Assert.IsTrue(false);
        }

        [Test]
        public void DifferenceTest()
        {
            int x = 10, y = 4, expected = 6, actual;

            actual = _math.Difference(x, y);

            Assert.AreEqual(expected, actual, "The value returned was different than the expected value.");
        }

        [TestFixtureTearDown]
        public void TearDownFixture()
        {
            //Do nothing
        }
    }
}
