# Day1-GuessingGame

## Project Overview

This is a C# console application implementing a number guessing game. The game challenges the user to guess a randomly generated number between 1 and 100 within a maximum of 6 attempts. It is developed using .NET 10.0.

The game provides feedback to the user after each guess, indicating whether their guess was "too low" or "too high." The game concludes when the user correctly guesses the number or runs out of attempts.

For testing purposes, the target number is currently hardcoded to `42`.

## Building and Running

To build and run this project, ensure you have the .NET 10.0 SDK installed.

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run
```

## Development Conventions

*   **Language:** C#
*   **Framework:** .NET 10.0
*   **Coding Style:** Follows general C# coding conventions. `ImplicitUsings` and `Nullable` are enabled in the project.
*   **Testing:** No specific testing framework or conventions are currently established for this project.

## Known Issues

*   The random number generation is currently overridden (`numberToGuess = 42;`) for testing purposes. This line should be removed or commented out for actual gameplay.
*   The logic for indicating when the user *won* inside the loop for the `totalGuess - guessLeft - 1` might be off by one in some edge cases.
*   Input validation is not robust; entering non-integer input will cause a crash.
