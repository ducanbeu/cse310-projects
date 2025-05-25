# Bowling Game Kata

This is a simple implementation of the Bowling Game Kata in C++ using TDD principles. You can run the tests from the terminal using `g++`.

## Project Structure

```
.
├── src/
│   ├── BowlingGame.cpp
│   └── BowlingGame.hpp
├── tests/
│   └── BowlingGameTest.cpp
└── README.md
```

## How to Compile and Run Tests

Open your terminal and navigate to the project root directory.

Then run:

```
g++ -std=c++17 -I./src tests/BowlingGameTest.cpp src/BowlingGame.cpp -o test_runner
./test_runner
```

You should see:

```
All tests passed!
```

## App Features

- Handles gutter games
- Handles spares and strike bonuses
- Supports perfect game (300 score)
- All logic is test-driven

## Youtube link

- https://youtu.be/Xk6bvCfq0f4