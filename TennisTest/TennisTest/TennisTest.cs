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
        public void score()
        {
            Assert.AreEqual("love all", Tennis.score(0,0));
        }
    }
}
