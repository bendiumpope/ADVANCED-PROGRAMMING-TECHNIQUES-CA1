# Periodic Table Information System (First 30 Elements)

**Course:** Advanced Programming Techniques
**Language:** C# (.NET Console Application)
**Task:** Question 2 – Periodic Table Program

---

# 1. Project Overview

This project implements a **C# console application** that stores and retrieves information about the **first 30 elements of the periodic table**.

The user can request information about an element by entering its **atomic number**. The system then displays the corresponding **element name and classification**.

After displaying the information, the user can choose to **continue searching for other elements** or **terminate the program**.

---

# 2. Program Objective

The main objectives of this program are:

* Store information about the **first 30 elements of the periodic table**
* Allow users to **search elements using atomic numbers**
* Display basic element information
* Demonstrate the use of a **suitable data structure in C#**

---

# 3. Data Structure Used

The program uses a **Dictionary data structure**:

```csharp
Dictionary<int, Element>
```

### Reason for Using Dictionary

A dictionary is used because:

* Each element has a **unique atomic number**
* Atomic numbers act as **keys**
* It allows **fast lookup of elements**

Example:

```
Atomic Number → Element
1 → Hydrogen
6 → Carbon
26 → Iron
```

This ensures efficient retrieval of data when the user enters an atomic number.

---

# 4. System Design

The application consists of two main components:

| Component     | Description                              |
| ------------- | ---------------------------------------- |
| Element Class | Stores information about an element      |
| Program Class | Handles user input and program execution |

---

# 5. Element Class

The `Element` class represents a chemical element.

### Attributes

| Attribute      | Description                         |
| -------------- | ----------------------------------- |
| AtomicNumber   | Unique atomic number of the element |
| Name           | Name of the element                 |
| Classification | Category of the element             |

### Constructor Example

```csharp
public Element(int atomicNumber, string name, string classification)
{
    AtomicNumber = atomicNumber;
    Name = name;
    Classification = classification;
}
```

The constructor initializes the properties when a new element object is created.

---

# 6. Program Workflow

The program follows these steps:

1. Store the first **30 periodic elements** in a dictionary.
2. Prompt the user to enter an **atomic number**.
3. Search the dictionary for the corresponding element.
4. Display the element’s information.
5. Ask the user if they want to continue.
6. If the user enters **y**, the program continues.
7. If the user enters **n**, the program terminates.

---

# 7. Example Program Execution

```
Hi there! Happy to help!

Provide atomic number of the element: 1

Atomic Number: 1
Name: Hydrogen
Class: Nonmetal

Do you want to know more elements [y/n]? y

Provide atomic number of the element: 26

Atomic Number: 26
Name: Iron
Class: Transition Metal

Do you want to know more elements [y/n]? n

Thanks!
```

---

# 8. Project Structure

```
question2
│
├── Program.cs
├── question2.csproj
└── README.md
```

---

# 9. Requirements

To run this project, ensure the following software is installed:

* **.NET SDK (version 10.0 or later)**
* Terminal or Command Prompt
* Optional: Visual Studio Code or Visual Studio

Check installed .NET version using:

```
dotnet --version
```

---

# 10. How to Run the Project

Follow these steps to run the program.

### Step 1 – Navigate to the Project Folder

```
cd question2
```

### Step 2 – Build the Project

```
dotnet build
```

This compiles the C# program.

---

### Step 3 – Run the Application

```
dotnet run
```

The program will start and prompt the user to enter an atomic number.

---

# 11. Error Handling

The program includes basic input validation to handle:

* Invalid inputs (non-numeric values)
* Atomic numbers outside the range of 1–30

Example message:

```
Element not found. Please enter a number between 1 and 30.
```

---

# 12. Conclusion

This project demonstrates how a **C# console application** can be used to store and retrieve structured scientific data. The use of a **dictionary data structure** allows efficient lookup of elements using atomic numbers. Additionally, the program provides a simple interactive interface for users to access periodic table information.

The implementation highlights key programming concepts such as **data structures, classes, constructors, and user interaction in C#**.
