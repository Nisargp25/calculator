# Calculator

A professional Windows Forms Calculator application built with C# and .NET 8.0, featuring a modern gradient UI design.

## Features

✨ **Modern Design**
- Dark theme with gradient background
- Contemporary color scheme with cyan operators and emerald green equals button
- Professional slate blue number buttons

⚙️ **Full Calculator Functionality**
- Basic arithmetic operations: Addition, Subtraction, Multiplication, Division
- Decimal point support for floating-point calculations
- Clear button (C) to reset the calculator
- Backspace button (←) to delete the last digit
- Division by zero error handling

## Project Structure

```
calculator/
├── Form1.cs               # Calculator logic and event handlers
├── Form1.Designer.cs      # UI layout and controls
├── Form1.resx             # Form resources
├── Program.cs             # Application entry point
├── Calculator.csproj      # Project file
├── calculator.sln         # Solution file
└── README.md              # This file
```

## Requirements

- .NET 8.0 or higher
- Windows OS (Windows 7 or later)
- Visual Studio 2022 or VS Code with C# extension

## How to Build and Run

### Using Visual Studio
1. Open `calculator.sln` in Visual Studio
2. Press `Ctrl+Shift+B` to build the solution
3. Press `F5` to run the application

### Using .NET CLI
```bash
cd calculator
dotnet build
dotnet run
```

## Usage

1. **Enter Numbers**: Click number buttons (0-9) to enter values
2. **Select Operation**: Click an operator button (+, −, ×, ÷)
3. **Calculate**: Click the equals button (=) to see the result
4. **Clear**: Click C to reset everything
5. **Delete**: Click ← to remove the last digit
6. **Decimal**: Click . to add a decimal point

## Technical Details

- **Language**: C#
- **Framework**: .NET 8.0
- **UI**: Windows Forms
- **Architecture**: Event-driven with state management
- **Gradient Rendering**: Custom Paint event for modern background

## Color Scheme

- **Background**: Dark blue to purple gradient
- **Display**: Dark gray with cyan text
- **Number Buttons**: Slate blue (60, 80, 120)
- **Operators**: Cyan (0, 180, 220)
- **Equals**: Emerald green (0, 200, 100)
- **Clear/Backspace**: Muted blue (80, 100, 140)

## License

This project is open source and available under the MIT License.

## Author

Created as a demonstration of modern Windows Forms design with .NET 8.0.
