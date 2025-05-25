#include <iostream>
#include <cassert>
#include "../src/BowlingGame.hpp"

void testGutterGame() {
    BowlingGame game;
    for (int i = 0; i < 20; ++i) game.roll(0);
    assert(game.score() == 0);
}

void testAllOnes() {
    BowlingGame game;
    for (int i = 0; i < 20; ++i) game.roll(1);
    assert(game.score() == 20);
}

void testOneSpare() {
    BowlingGame game;
    game.roll(5);
    game.roll(5);
    game.roll(3);
    for (int i = 0; i < 17; ++i) game.roll(0);
    assert(game.score() == 16);
}

void testOneStrike() {
    BowlingGame game;
    game.roll(10);
    game.roll(3);
    game.roll(4);
    for (int i = 0; i < 16; ++i) game.roll(0);
    assert(game.score() == 24);
}

void testPerfectGame() {
    BowlingGame game;
    for (int i = 0; i < 12; ++i) game.roll(10);
    assert(game.score() == 300);
}

int main() {
    testGutterGame();
    testAllOnes();
    testOneSpare();
    testOneStrike();
    testPerfectGame();
    std::cout << "All tests passed!" << std::endl;
    return 0;
}