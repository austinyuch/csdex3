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
        [Test]
        public void win()
        {
            Assert.AreEqual("Player one win", Tennis.score(4, 2));
            Assert.AreEqual("Player two win", Tennis.score(2, 4));
            //exhausted test
            Assert.AreEqual("Player two win", Tennis.score(6, 8));
        }

        [Test]
        public void advantage()
        {
            Assert.AreEqual("Player one advantage", Tennis.score(4, 3));
            Assert.AreEqual("Player one advantage", Tennis.score(5, 4));
            //exhausted test
            Assert.AreEqual("Player two advantage", Tennis.score(6, 7));

        }
        [Test]
        public void deuce()
        {
            Assert.AreEqual("Deuce", Tennis.score(4, 4));
            //exhausted test
            Assert.AreEqual("Deuce", Tennis.score(6, 6));
        }
    }
}
