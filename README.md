# Student Management System

A C# application for managing student records. It allows administrators to add, update, delete, and view student information. The system is connected to a SQL Server database to store student details.

## Features

- Add new students
- Update student records
- Delete student records
- View student details
- Search for students by registration number

## Technologies Used

- **C#**: For application logic
- **SQL Server**: For database management
- **Windows Forms**: For the user interface

## Installation

1. Clone this repository:
    ```bash
    git clone https://github.com/YourUsername/StudentManagement.git
    ```
2. Open the project in **Visual Studio**.
3. Build the project by pressing `Ctrl+Shift+B` or using the **Build** menu.
4. Run the application by pressing `F5`.

## Database Setup

1. Create a new database in SQL Server.
2. Run the following SQL query to create the `registration` table:
    ```sql
    CREATE TABLE registration (
        regNo INT IDENTITY(1,1) PRIMARY KEY,
        FirstName VARCHAR(50),
        LastName VARCHAR(50),
        DateOfBirth DATE,
        Address TEXT,
        Email VARCHAR(100),
        MobilePhone VARCHAR(15),
        HomePhone VARCHAR(15),
        ParentName VARCHAR(100),
        NIC VARCHAR(20),
        ContactNo VARCHAR(15)
    );
    ```
3. Update the connection string in the application to point to your SQL Server instance.

## How to Use

1. Launch the application.
2. Select a registration number from the dropdown list to search for existing student records.
3. Fill in the fields to add a new student or update an existing record.
4. Press the **Save** button to save the changes.

## Contributing

1. Fork the repository.
2. Create a new branch for your feature (`git checkout -b feature-name`).
3. Commit your changes (`git commit -m 'Add feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Create a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
