# Bank Automation System

This project is a **C#** application that simulates a banking system, providing essential functionalities such as customer management, transaction tracking, and financial reporting. It was developed during my second year of university, showcasing fundamental principles of Object-Oriented Programming (OOP).

## Features

- **Customer Management**:
  - Add new customers to the bank's customer list.
  - Verify customer identity based on their unique national ID (TCKimlikNo).

- **Transaction Tracking**:
  - Track total deposited and withdrawn funds for the bank.
  - Automatically calculate the bank's total balance.

- **Financial Reporting**:
  - Generate reports that include:
    - Total funds held by the bank.
    - Total amount deposited by customers.
    - Total amount withdrawn by customers.

## How It Works

1. **Class Design**:
   - The `Banka` class acts as the central component of the application, managing:
     - A list of customers (`Musteriler`).
     - Total funds, deposits, and withdrawals.
   - The `Musteri` class represents individual customers, each with a unique identification number.

2. **Adding Customers**:
   - Use the `MusteriEkle` method to add new customers to the bank.

3. **Customer Login**:
   - The `MusteriGirisiniKontrolEt` method checks the validity of a customer's national ID (TCKimlikNo) to verify their identity.

4. **Report Generation**:
   - Use the `RaporSun` method to create financial summaries of total deposits, withdrawals, and the bank's available funds.

## Technologies Used

- **C#**: The application was developed using C#, leveraging core OOP principles.

## How to Run

1. **Set Up**:
   - Clone the repository or download the source code.
   - Open the project in any C# IDE, such as Visual Studio.

2. **Compile and Execute**:
   - Compile the code to ensure there are no errors.
   - Run the application to start managing customers and transactions.

3. **Usage**:
   - Add customers, perform deposit and withdrawal transactions, and generate reports to monitor the bank's performance.

## Future Improvements

- Add a graphical user interface (GUI) for better user interaction.
- Save customer and transaction data to a file for persistence.
- Include features such as account types, interest calculation, and loan management.

## License

This project is free to use and modify for educational purposes. Contributions are welcome!
