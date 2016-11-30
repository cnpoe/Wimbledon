using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWimbledon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            var p = new Wimbledon.Program(0, 0);
            //ACT
            Assert.AreEqual(p.getScore(), "Love - Love");
        }
        [TestMethod]
        public void TestMethod2()
        {
            //ARRANGE
            var p = new Wimbledon.Program(15, 0);
            //ACT
            Assert.AreEqual(p.getScore(), "Fifteen - Love");
        }
        [TestMethod]
        public void TestMethod3()
        {
            var p = new Wimbledon.Program(40, 40);
            //ACT
            p.scorePoint("a");
            Assert.AreEqual(p.getScore(),"Advantage - Fourthy");
        }
        [TestMethod]
        public void TestMethod4()
        {
            var p = new Wimbledon.Program(40, 40);
            //ACT
            p.scorePoint("b");
            Assert.AreEqual(p.getScore(), "Fourthy - Advantage");
        }
    }
}
