# NMLs
.Net Math Libraries

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
