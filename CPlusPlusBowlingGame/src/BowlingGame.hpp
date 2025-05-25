#ifndef BOWLING_GAME_HPP
#define BOWLING_GAME_HPP

class BowlingGame {
public:
    BowlingGame();
    void roll(int pins);
    int score() const;

private:
    int rolls[21];
    int currentRoll;
};

#endif // BOWLING_GAME_HPP