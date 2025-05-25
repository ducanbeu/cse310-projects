#include "BowlingGame.hpp"

BowlingGame::BowlingGame() : currentRoll(0) {
    for (int &roll : rolls) {
        roll = 0;
    }
}

void BowlingGame::roll(int pins) {
    rolls[currentRoll++] = pins;
}

int BowlingGame::score() const {
    int score = 0;
    int rollIndex = 0;
    for (int frame = 0; frame < 10; frame++) {
        if (rolls[rollIndex] == 10) {
            score += 10 + rolls[rollIndex + 1] + rolls[rollIndex + 2];
            rollIndex += 1;
        } else if (rolls[rollIndex] + rolls[rollIndex + 1] == 10) {
            score += 10 + rolls[rollIndex + 2];
            rollIndex += 2;
        } else {
            score += rolls[rollIndex] + rolls[rollIndex + 1];
            rollIndex += 2;
        }
    }
    return score;
}