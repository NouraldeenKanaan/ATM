# ATM Project

## Project Description
The ATM project is a Windows Forms application built in C# using .NET Framework 4.8. It simulates an Automated Teller Machine (ATM) system, enabling users to perform core banking operations like checking account balances, depositing funds, withdrawing money, and transferring funds between accounts. The application follows a **3-Tier architecture** (Presentation, Business Logic, and Data Access layers) for modularity and maintainability, with business logic encapsulated in the `ATM_Business` project and a modern UI enhanced by the ReaLTaiizor library.

## Features
- **User Authentication**: Secure login interface for user access.
- **Balance Inquiry**: View current account balance.
- **Deposit**: Add funds to an account.
- **Withdrawal**: Withdraw funds from an account.
- **Transfer**: Transfer funds between accounts.
- **Modern UI**: Built with Windows Forms and styled using ReaLTaiizor for a sleek interface.

## 3-Tier Architecture
- **Presentation Layer**: Implemented in Windows Forms (`frmLogin.cs`, `frmMain.cs`, `frmBalance.cs`, `frmDeposit.cs`, `frmWithdraw.cs`, `frmTransfer.cs`) for user interaction.
- **Business Logic Layer**: Handled by the `ATM_Business` project, managing core operations and transaction logic.
- **Data Access Layer**: Separates data operations, ensuring clean interaction with data storage (not detailed in the provided `.csproj` but assumed to be part of `ATM_Business`).

## Project Structure
- **Forms** (Presentation Layer):
  - `frmLogin.cs`: User authentication interface.
  - `frmMain.cs`: Main dashboard for navigation.
  - `frmBalance.cs`: Displays account balance.
  - `frmDeposit.cs`: Handles deposit operations.
  - `frmWithdraw.cs`: Manages withdrawal operations.
  - `frmTransfer.cs`: Facilitates fund transfers.
- **Dependencies**:
  - .NET Framework 4.8
  - ReaLTaiizor library (v3.8.1.3) for UI components
  - `ATM_Business` project for business logic