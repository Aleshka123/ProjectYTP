using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameScript;

namespace Test
{
    [TestClass]
    public class TestController
    {
        [TestMethod]
        public void TestPlayerController1()
        {
            int X = 0;
            int Y = 0;
            float expected = 0f;

            PlayerController controller = new PlayerController();
            float actual = controller.TestPlayerController(X, Y);

            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void TestPlayerController2()
        {
            int X = 1;
            int Y = 0;
            float expected = 10f;

            PlayerController controller = new PlayerController();
            float actual = controller.TestPlayerController(X, Y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPlayerController3()
        {
            int X = 0;
            int Y = 1;
            float expected = 10f;

            PlayerController controller = new PlayerController();
            float actual = controller.TestPlayerController(X, Y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPlayerController4()
        {
            int X = -1;
            int Y = -1;
            float expected = 6.6666666666666666666666666666667f;

            PlayerController controller = new PlayerController();
            float actual = controller.TestPlayerController(X, Y);

            Assert.AreEqual(expected, actual);
        }
    }
}
