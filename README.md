# Old Phone Pad Converter

This project is a C# implementation of an "Old Phone Pad" converter, a common software engineering interview challenge. The goal is to convert a string of numbers and symbols, representing key presses on an old mobile phone, into the corresponding text message.

## The Challenge

The challenge is to implement a method that takes a string input, like "4433555 555666#", and returns the correct alphabetical output, in this case, "HELLO".

The rules are as follows:
- Each number from 2 to 9 maps to a set of letters.
- Pressing a number button multiple times in succession cycles through the letters on that button.
- A space ` ` in the input string represents a pause, which finalizes the previous letter and allows for typing a new letter (even one from the same button).
- The `*` character acts as a backspace, deleting the last character from the output.
- The input string always terminates with a `#` character, which signifies the end of the message.

## Solution Structure

The solution is organized into two projects:

- `OldPhonePadApp/`: A .NET console application that contains the core logic for the converter and a simple program to demonstrate its usage.
  - `OldPhonePadConverter.cs`: A static class containing the `OldPhonePad` method implementation.
  - `Program.cs`: A simple console application that runs a few examples from the prompt.
- `OldPhonePadApp.Tests/`: A .NET NUnit test project containing unit tests for the `OldPhonePadConverter`.
  - `OldPhonePadTests.cs`: A suite of tests that verify the correctness of the converter, including edge cases.

## Getting Started

To build and run this project, you will need the .NET SDK installed on your machine. You can download it from the official [.NET website](https://dotnet.microsoft.com/download).

### Building the Project

To build both the application and the test project, navigate to the root directory of this repository in your terminal and run the following command:

```bash
dotnet build
```

### Running the Application

To run the console application and see the output of the example cases, use the `dotnet run` command, specifying the application's project:

```bash
dotnet run --project OldPhonePadApp/OldPhonePadApp.csproj
```

### Running the Tests

To run the unit tests and verify the correctness of the `OldPhonePad` implementation, run the following command from the root directory:

```bash
dotnet test
```

This will discover and execute all the tests in the `OldPhonePadApp.Tests` project and provide a summary of the results.
