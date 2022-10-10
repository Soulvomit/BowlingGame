using BowlingGame;

namespace BowlingGameTests
{
    [TestClass]
    public class GameTests
    {
        Game g = new Game();

        [TestMethod]
        public void testGutterGame()
        {
            rollMany(20, 0);
            Assert.AreEqual(0, g.score());
        }

        [TestMethod]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, g.score());
        }

        [TestMethod]
        public void testOneSpare()
        {
            rollSpare();
            g.roll(3);
            rollMany(17, 0);
            Assert.AreEqual(16, g.score());
        }
        [TestMethod]
        public void testOneStrike()
        {
            rollStrike(); 
            g.roll(3);
            g.roll(4);
            rollMany(16, 0);
            Assert.AreEqual(24, g.score());
        }
        public void testPerfectGame()
        {
            rollMany(12,10);
            Assert.AreEqual(300, g.score());
        }

        #region Private Methods
        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.roll(pins);
        }
        private void rollSpare()
        {
            g.roll(5);
            g.roll(5);
        }
        private void rollStrike()
        {
            g.roll(10);
        }
        #endregion
    }
}