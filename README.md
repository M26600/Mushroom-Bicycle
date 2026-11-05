# 🍄🚲 Mushroom & Bicycle Management System

A C# Windows Forms desktop application developed using **.NET Framework 4.7.2**. The application combines a mushroom identification quiz and a bicycle rental cost calculator in one simple, interactive desktop system.

## ✨ Features

### 🔐 Login System
- Login using a username and password.
- Prevents users from submitting empty fields.
- Navigate to the main menu after successful login.

### 🚲 Bicycle Rental Calculator
- Enter bicycle rental starting and ending hours.
- Automatically calculates the rental cost based on hourly rates.
- Displays the total amount in RWF.
- Validates time inputs before calculating.

**Hourly rental rates:**

| Time period | Rate per hour |
|---|---:|
| 00:00 – 06:59 | 500 RWF |
| 07:00 – 13:59 | 1,000 RWF |
| 14:00 – 18:59 | 1,500 RWF |
| 19:00 – 20:59 | 1,000 RWF |
| 21:00 – 23:59 | 500 RWF |

### 🍄 Mushroom Identification
- Interactive question-and-answer process.
- Uses a decision-tree approach to identify mushrooms.
- Displays the identification result using message boxes.
- Allows users to restart the identification process.

### 🧭 Navigation
- Main menu for selecting application features.
- Back buttons for returning to the main menu.
- Logout buttons for returning to the login screen.

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET Framework 4.7.2
- **IDE:** Microsoft Visual Studio
- **Application Type:** Windows Forms
- **Version Control:** Git & GitHub

## 📁 Project Structure

```text
Mushroom-Bicycle/
│
├── Lab2A.slnx
│
├── Lab2A/
│   ├── Bicycle.cs
│   ├── Bicycle.Designer.cs
│   ├── ChooseForm.cs
│   ├── ChooseForm.Designer.cs
│   ├── LoginForm.cs
│   ├── LoginForm.Designer.cs
│   ├── MushroomForm.cs
│   ├── MushroomForm.Designer.cs
│   ├── Program.cs
│   └── Lab2A.csproj
│
└── README.md
```

## 🚀 Getting Started

### Prerequisites

Before running the project, make sure you have:

- Windows operating system.
- Microsoft Visual Studio.
- .NET Framework 4.7.2 targeting pack.

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/M26600/Mushroom-Bicycle.git
   ```

2. Open the project folder.

3. Open `Lab2A.slnx` using Visual Studio.

4. Build the solution.

5. Run the application.

## 🔑 Login Credentials

Use the following credentials to access the application:

| Field | Value |
|---|---|
| Username | `admin` |
| Password | `1234` |

*Note: These are demonstration credentials for this project.*

## 🎯 Project Objectives

This project demonstrates practical application of:

- C# programming fundamentals.
- Windows Forms GUI development.
- Event handling and user interaction.
- Conditional statements and loops.
- Input validation.
- Basic navigation between forms.
- Decision-tree logic.
- Arithmetic calculations.

## 👩‍💻 Author

**Mugeni Cynthia**

Software Engineering Student | C# Developer

GitHub: [@M26600](https://github.com/M26600)

---

⭐ If you find this project interesting, feel free to explore the repository!
