using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TennisScore;

namespace TennisScore
{
    [TestFixture()]
    public class TennisTest
    {
        [Test]
        public void equalScore()
        {
            Assert.AreEqual("Love all", Tennis.score(0,0));
            Assert.AreEqual("Fifteen all", Tennis.score(1,1));
            Assert.AreEqual("Thirty all", Tennis.score(2,2));
            Assert.AreEqual("Forty all", Tennis.score(3, 3));
        }
        [Test]
        public void diffScore()
        {
            Assert.AreEqual("Fifteen Love", Tennis.score(1, 0));
            Assert.AreEqual("Thirty Love", Tennis.score(2, 0));
            
        }

    }
}
