using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameScript;

namespace Test
{
    [TestClass]
    public class TestHpEnemy
    {
        [TestMethod]
        public void TestYouHp1()
        {
            string gameObject = "Ammo";
            int Hp = 1;
            var expected = 0;

            EnemyHP hp = new EnemyHP();
            int actual = hp.TestEnemyHp(gameObject, Hp);

            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void TestYouHp2()
        {
            string gameObject = "Ammo";
            int Hp = 0;
            var expected = 0;

            EnemyHP hp = new EnemyHP();
            int actual = hp.TestEnemyHp(gameObject, Hp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestYouHp3()
        {
            string gameObject = "Player";
            int Hp = 2;
            var expected = 1;

            EnemyHP hp = new EnemyHP();
            int actual = hp.TestEnemyHp(gameObject, Hp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestYouHp4()
        {
            string gameObject = "Player";
            int Hp = 0;
            var expected = 0;

            EnemyHP hp = new EnemyHP();
            int actual = hp.TestEnemyHp(gameObject, Hp);

            Assert.AreEqual(expected, actual);
        }
    }
}
