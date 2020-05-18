using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameScript;

namespace Test
{
    [TestClass]
    public class TestLook
    {
        [TestMethod]
        public void TestPlayerLook()
        {
            double XPlayer = 0;
            double YPayer = 0;
            double XEnemy = 0;
            double YEnemy = 0;

            double expected = 0;

            LookPlayer look = new LookPlayer();
            double actual = look.TestPlayerLook(XPlayer, YPayer, XEnemy, YEnemy);

            Assert.AreEqual(expected, actual); 
        }
    }
}
