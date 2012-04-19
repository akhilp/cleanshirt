using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CampusDemo.ContinuousIntegration.URLTree;

namespace Campus.Demo.ContinuousIntegration.Test
{
    [TestFixture]
    class URLTreeTest
    {
        private Tree _tree;

        [TestFixtureSetUp]
        public void SetUpFixture()
        {
            _tree = new Tree();
            _tree.Add("www.newspaper.com", "default news script");
            _tree.Add("www.newspaper.com/sports", "sports script");
            _tree.Add("www.newspaper.com/sports/golf", "golf script");
            _tree.Add("www.newspaper.com/sports/golf/article_about_the_masters", "masters script");
        }

        [Test]
        public void NodeCountTest()
        {
            int expected=4, actual;
            actual = _tree.Count;

            Assert.AreEqual(expected, actual, "Expected and actual count different.");
        }

        [Test]
        public void FindPayloadTest()
        {
            string expected, actual;

            expected = "sports script";
            actual = _tree.Findpayload("www.newspaper.com/sports");
            Assert.AreEqual(expected, actual, "The payload returned differed from the expected payload.");

            expected = "masters script";
            actual = _tree.Findpayload("www.newspaper.com/sports/golf/article_about_the_masters");
            Assert.AreEqual(expected, actual, "The payload returned differed from the expected payload.");

            expected = "sports script";
            actual = _tree.Findpayload("www.newspaper.com/sports/hockey/article_about_the_stars");
            Assert.AreEqual(expected, actual, "The payload returned differed from the expected payload.");

            expected = "masters script";
            actual = _tree.Findpayload("www.newspaper.com/sports/golf/article_about_the_masters");
            Assert.AreEqual(expected, actual, "The payload returned differed from the expected payload.");

            expected = "default news script";
            actual = _tree.Findpayload("www.newspaper.com/culture/art/art_show_downtown");
            Assert.AreEqual(expected, actual, "The payload returned differed from the expected payload.");
        }

        [TestFixtureTearDown]
        public void TearDownFixture()
        {
            //do nothing
        }
    }
}
