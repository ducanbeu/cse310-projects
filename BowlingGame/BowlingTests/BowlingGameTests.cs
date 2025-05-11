using Xunit;
using Bowling;

namespace BowlingTests
{
    public class BowlingGameTests
    {
        private readonly BowlingGame _game = new BowlingGame();

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
                _game.Roll(pins);
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
        }

        private void RollStrike()
        {
            _game.Roll(10);
        }

        [Fact]
        public void GutterGame_ReturnsZero()
        {
            RollMany(20, 0);
            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void AllOnes_Returns20()
        {
            RollMany(20, 1);
            Assert.Equal(20, _game.Score());
        }

        [Fact]
        public void OneSpare_AddsNextRoll()
        {
            RollSpare();
            _game.Roll(3);
            RollMany(17, 0);
            Assert.Equal(16, _game.Score());
        }

        [Fact]
        public void OneStrike_AddsNextTwoRolls()
        {
            RollStrike();
            _game.Roll(3);
            _game.Roll(4);
            RollMany(16, 0);
            Assert.Equal(24, _game.Score());
        }

        [Fact]
        public void PerfectGame_Returns300()
        {
            RollMany(12, 10);
            Assert.Equal(300, _game.Score());
        }
    }
}
