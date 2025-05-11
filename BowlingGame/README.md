# Bowling Game Kata (TDD with .NET & xUnit)

This project is an implementation of the Bowling Game kata by Uncle Bob (https://github.com/unclebob), designed to practice Test-Driven Development (TDD). I have used this kata to enhance my understanding of .NET and TDD within the language.

---

## Problem Description

The goal is to write a program that calculates the score of a bowling game. The rules are simple, but scoring includes edge cases like strikes and spares, which make it an good exercise for iterative, test-first development.

### Bowling Rules Recap:
- A game consists of 10 frames.
- Each frame can have 2 rolls, except the 10th which can have a bonus roll if a spare or strike is rolled.
- A strike (10 pins in 1 roll) adds the next 2 rolls as a bonus.
- A spare (10 pins in 2 rolls) adds the next 1 roll as a bonus.
- The maximum score is 300 (12 strikes).

YOUTUBE EXPLANATION: https://youtu.be/ymsceKdsoAg