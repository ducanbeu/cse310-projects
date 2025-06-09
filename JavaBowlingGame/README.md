# Java Bowling Game Kata

This is a simple implementation of the Bowling Game Kata in Java using TDD principles. You can run the tests from the terminal using `mvn test`.

## Project Structure

```
.
├── src/
│   ├── main/
│   │   └── java
│   │       └── BowlingGame.java
│   └── test
│       └── java
│           └── BowlingGameTest.java
├── README.md
└── pom.xml
```

## How to Compile and Run Tests

Open your terminal and navigate to the project root directory.

Then run:

```
mvn test
```

You should see:

```
[INFO] Results:
[INFO] 
[INFO] Tests run: 5, Failures: 0, Errors: 0, Skipped: 0
```

## App Features

- Handles gutter games
- Handles spares and strike bonuses
- Supports perfect game (300 score)
- All logic is test-driven

## Youtube link

- https://www.youtube.com/watch?v=rZNxE0HTrYg