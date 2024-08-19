# NMLs: .NET Math Libraries

## Overview

The **NMLs** solution is designed to explore and benchmark various .NET math libraries using .NET Core 8.0.X. It includes functionality to execute and evaluate mathematical expressions and provides tools for performance comparison between different libraries.

## Solution Structure

The Visual Studio solution consists of three main projects:

1. **MathLibsLogic**:
   - Contains implementations for various math libraries.
   - Each library is encapsulated in a class named `My[LibraryName]` for easy extension and customization.
   - Manages all NuGet package dependencies required for the math libraries.

2. **NMLs**:
   - A console application that allows users to input mathematical expressions and select library implementations to test.
   - Uses a loop with a property flag to continuously accept user input until instructed to exit.

3. **Benchmarking**:
   - Utilizes the BenchmarkDotNet package to compare the performance of different math libraries.
   - Provides functionality to update and run benchmark tests with various math expressions.

## External Projects

The following external projects are used in this research for evaluating math expressions:

- **ExpressionEvaluator 1.4.40**  
  [ExpressionEvaluator GitHub Repository](https://github.com/codingseb/ExpressionEvaluator)

- **ExpresiveParser 3.0.1**  
  [ExpresiveParser GitHub Repository](https://github.com/bijington/expressive)

- **Microsoft.ClearScript 7.4.5**  
  [Microsoft.ClearScript GitHub Repository](https://github.com/Microsoft/ClearScript)

## How to Run

### Using Visual Studio

1. Open the solution in Visual Studio.
2. Right-click on either the `Benchmarking` or `NMLs` project in the Solution Explorer.
3. Select **"Set as Startup Project"**.
4. Press `F5` or click the **"Start"** button to run the project.

### Using Terminal

1. Navigate to the root directory of the cloned repository.
2. Build the projects using the following commands:

```bash
dotnet build ./NMLs.csproj
dotnet build ./Benchmarking/Benchmarking.csproj
```

3. Run the desired project with:
```bash
dotnet run --project ./NMLs.csproj
```
or
```bash
dotnet run --project ./Benchmarking/Benchmarking.csproj
```

## Contribution
Feel free to contribute by submitting issues or pull requests.
