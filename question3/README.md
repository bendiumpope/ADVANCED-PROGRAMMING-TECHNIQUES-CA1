# EasyDrive Car Rental Registration System

**Advanced Programming Techniques – CA1**
**Section II: Programming in Python – Task 3**

Language: **Python**
Communication Protocol: **TCP (Connection-Oriented)**
Database: **SQLite (Persistent Relational Database)**

---

# 1. Project Overview

This project implements a **client-server application** for the EasyDrive car rental company.
EasyDrive offers a scheme called **“Drive by the hour, any day, any time”**, where registered customers can rent vehicles and only pay for the time they use.

To register for the service, customers must provide the following information:

* Name
* Address
* PPS Number
* Driving License document

The system uses a **TCP-based client-server architecture** where:

1. The **client application** collects customer information.
2. The **server application** receives the data and stores it in a database.
3. The server generates a **unique registration number** and sends it back to the client.

---

# 2. System Architecture

The application follows a **three-component architecture**.

```text
Client Application  →  TCP Connection  →  Server Application  →  SQLite Database
```

### Workflow

1. The client collects user information.
2. The client sends the data to the server through a **TCP socket connection**.
3. The server receives the data.
4. The server stores the information in a **database**.
5. The server generates a **unique registration number**.
6. The server sends the registration number back to the client.

---

# 3. Technologies Used

| Technology     | Purpose                                    |
| -------------- | ------------------------------------------ |
| Python         | Programming language                       |
| Socket Library | Client-server communication                |
| TCP Protocol   | Reliable connection-oriented data transfer |
| SQLite         | Persistent relational database             |
| UUID Library   | Generation of unique registration numbers  |

---

# 4. Customer Information Collected

The following information is required from customers during registration:

| Field           | Description                     |
| --------------- | ------------------------------- |
| Name            | Full name of the customer       |
| Address         | Residential address             |
| PPS Number      | Personal Public Service number  |
| Driving License | Driving license document number |

---

# 5. Database Design

The system uses **SQLite**, which is a lightweight relational database stored locally on disk.

Database file:

```text
easydrive.db
```

Table structure:

| Column  | Description                |
| ------- | -------------------------- |
| reg_no  | Unique registration number |
| name    | Customer name              |
| address | Customer address           |
| pps     | PPS number                 |
| license | Driving license number     |

Example record stored in database:

```text
reg_no: ab12cd34
name: John Doe
address: Dublin
pps: 1234567A
license: DL998877
```

---

# 6. Project Structure

```text
question3
│
├── Que3_server.py
├── Que3_client.py
├── easydrive.db
└── README.md
```

| File           | Description           |
| -------------- | --------------------- |
| Que3_server.py | Server application    |
| Que3_client.py | Client application    |
| easydrive.db   | SQLite database file  |
| README.md      | Project documentation |

---

# 7. Server Functionality

The server performs the following tasks:

1. Creates the database if it does not exist.
2. Waits for incoming client connections.
3. Receives customer registration information.
4. Stores the data in the database.
5. Generates a **unique registration number**.
6. Sends the registration number back to the client.

Example server output:

```text
Server running...
Waiting for client connection...
Connected by ('127.0.0.1', 53021)

Customer registered: John Doe
Registration Number: ab12cd34
```

---

# 8. Client Functionality

The client application performs the following tasks:

1. Prompts the user to enter registration details.
2. Connects to the server using a **TCP socket**.
3. Sends the user information to the server.
4. Receives the generated registration number.
5. Displays the registration number to the user.

Example client output:

```text
EasyDrive Registration System

Enter Name: John Doe
Enter Address: Dublin
Enter PPS Number: 1234567A
Enter Driving License Number: DL12345

Registration Successful!
Your Registration Number: ab12cd34
```

---

# 9. How to Run the Application

The system requires **two terminal windows**: one for the server and one for the client.

---

## Step 1 – Navigate to the project directory

```bash
cd Task3
```

---

## Step 2 – Start the server

Run the server program:

```bash
python Que4_server.py
```

Output:

```text
Server running...
Waiting for client connection...
```

The server will now wait for client requests.

---

## Step 3 – Run the client

Open another terminal window and run:

```bash
python Que4_client.py
```

The client will ask for registration details.

Example:

```text
Enter Name: John Doe
Enter Address: Dublin
Enter PPS Number: 1234567A
Enter Driving License Number: DL12345
```

---

## Step 4 – Receive registration number

After the server processes the data, the client will receive a unique registration number:

```text
Registration Successful!
Your Registration Number: ab12cd34
```

---

# 10. TCP Communication

The application uses **TCP (Transmission Control Protocol)**, which provides:

* Reliable data transmission
* Error checking
* Ordered delivery of data

TCP ensures that customer information is transmitted safely between the client and the server.

---

# 11. Persistent Data Storage

Customer data is stored in a **disk-based SQLite database**, meaning:

* Data is preserved after the program stops
* Multiple registrations can be stored
* Records can be retrieved later if required

---

# 12. Conclusion

This project demonstrates the implementation of a **Python client-server system using TCP communication and database storage**.

The system successfully collects customer registration details, transmits the data securely to a server, stores it in a relational database, and generates a unique registration number for each customer.

The implementation highlights practical concepts such as **network programming, socket communication, persistent data storage, and client-server architecture**.
