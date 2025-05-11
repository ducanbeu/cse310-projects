namespace Bowling
{
    public class BowlingGame
    {
        private readonly int[] _rolls = new int[21];
        private int _currentRoll = 0;

        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int rollIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(rollIndex))
                {
                    score += 10 + _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
                    rollIndex += 1;
                }
                else if (IsSpare(rollIndex))
                {
                    score += 10 + _rolls[rollIndex + 2];
                    rollIndex += 2;
                }
                else
                {
                    score += _rolls[rollIndex] + _rolls[rollIndex + 1];
                    rollIndex += 2;
                }
            }

            return score;
        }

        private bool IsStrike(int rollIndex) => _rolls[rollIndex] == 10;
        private bool IsSpare(int rollIndex) => _rolls[rollIndex] + _rolls[rollIndex + 1] == 10;
    }
}
