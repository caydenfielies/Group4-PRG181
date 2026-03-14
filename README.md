# 🛒 Best Buys Supermarket Sales Tracker

A console-based C# application that tracks sales transactions across seven departments for the Best Buys Supermarket. Built as part of the Programming 1781 (PRG181) project at Belgium Campus ITversity.

---

## 📋 Overview

This program allows cashiers to log sales transactions per department and view running totals in real time.

---

## 🏬 Departments

| Code | Department     |
|------|----------------|
| ELE  | Electronics    |
| CAM  | Cameras        |
| OFF  | Office         |
| HOM  | Home           |
| AUD  | Audio          |
| GAM  | Gaming         |
| ACC  | Accessories    |

---

## ⚙️ Features

- Add sales transactions to any of the 7 departments
- Real-time running totals displayed after each sale
- Input validation for:
  - Invalid department codes
  - Invalid or negative sale amounts
  - Department capacity limit (1,000 transactions per department)
- Type `QUIT` at any time to exit the program

---

## 🗂️ Data Structure

The program uses three arrays to manage data:

- **1D `string[]` array** — stores the 7 department codes
- **2D `double[,]` array** — stores up to 1,000 sales transactions per department (7 rows × 1,000 columns)
- **1D `int[]` array** — tracks the number of transactions per department

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) with the C# Dev Kit extension

### Running the Program

**Option 1 — Run from source (requires .NET 8 SDK)**
```bash
# Clone the repository
https://github.com/caydenfielies/Group4-PRG181.git
 
# Navigate into the project folder
cd BestBuysSupermarket
 
# Run the program
dotnet run
```
 
**Option 2 — Run the executable directly (no .NET SDK required)**
 
A prebuilt executable is included in the repository:
 
```bash
# Navigate to the executable
cd BestBuysSupermarket/bin/Debug/net8.0/
 
# Run on Windows
BestBuysSupermarket.exe
 
# Run on Mac/Linux
./BestBuysSupermarket
```
 
> **Note:** You're running .NET 10. On Mac/Linux the executable has no `.exe` extension — just run `./BestBuysSupermarket` directly.
---

## 💻 Example Output

```
----------------------------------
Best Buy Supermarket Sales Tracker
----------------------------------
Type QUIT to stop the program.

Enter a department code. (ELE, CAM, OFF, HOM, AUD, GAM, ACC)
ELE

Enter a sales transaction amount.
299.99

Success!

DEPT    QTY     AMOUNT
-----------------------------
ELE     1       R 299.99
CAM     0       R 0.00
OFF     0       R 0.00
HOM     0       R 0.00
AUD     0       R 0.00
GAM     0       R 0.00
ACC     0       R 0.00
-----------------------------
```

---

## 📁 Project Structure

```
BestBuysSupermarket/
│
├── Program.cs                                ← main source code
├── BestBuysSupermarket.csproj                ← project configuration
├── BestBuysSupermarket.sln                   ← solution file
├── README.md                                 ← you are here
│
├── bin/Debug/net10.0/
│   ├── BestBuysSupermarket                   ← executable (Mac/Linux)
│   ├── BestBuysSupermarket.dll               ← compiled program
│   ├── BestBuysSupermarket.deps.json         ← dependency manifest
│   ├── BestBuysSupermarket.pdb               ← debug symbols
│   └── BestBuysSupermarket.runtimeconfig.json← runtime configuration
│
└── obj/                                      ← auto-generated build files (do not edit)
```

---

## 👨‍💻 Authors

Built by Group 4 — Belgium Campus ITversity  
Programming 1781 — Project 1 (2026)
