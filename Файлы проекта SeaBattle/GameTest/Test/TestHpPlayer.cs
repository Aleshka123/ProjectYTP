using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameScript;

namespace Test
{
    [TestClass]
    public class TestPlayerHp
    {
        [TestMethod]
        public void TestYouHp1()
        {
            string gameObject = "Wall";
            int Hp = 0;
            var expected = 0;

            PlayerHP hp = new PlayerHP();
            int actual = hp.TestPlayerHp(gameObject, Hp);

            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void TestYouHp2()
        {
            string gameObject = "Wall";
            int Hp = 5;
            var expected = 4;

            PlayerHP hp = new PlayerHP();
            int actual = hp.TestPlayerHp(gameObject, Hp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestYouHp3()
        {
            string gameObject = "Player";
            int Hp = 4;
            var expected = 4;

            PlayerHP hp = new PlayerHP();
            int actual = hp.TestPlayerHp(gameObject, Hp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestYouHp4()
        {
            string gameObject = "Enemy";
            int Hp = 5;
            var expected = 0;

            PlayerHP hp = new PlayerHP();
            int actual = hp.TestPlayerHp(gameObject, Hp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestYouHp5()
        {
            string gameObject = "AmmoEnemy";
            int Hp = 3;
            var expected = 2;

            PlayerHP hp = new PlayerHP();
            int actual = hp.TestPlayerHp(gameObject, Hp);

            Assert.AreEqual(expected, actual);
        }
    }
}
