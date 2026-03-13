# 1. Project Overview

This project implements a menu-driven console application for a food truck that sells churros. Customers place orders, make payment, and receive an order number. The orders are stored in a queue and are delivered in a First-In-First-Out (FIFO) order.

The system is operated by the stall owner, who performs the following actions:

- Place a new order
- Deliver the next order in the queue
- Exit the application

The system demonstrates Object-Oriented Programming (OOP) concepts and the use of data structures for managing orders efficiently.

---

# 2. Menu Interface

When the application runs, the following menu is displayed:

```
----------------------------------------
Delicious Churros
----------------------------------------
Churros with plain sugar: €6
Churros with cinnamon sugar: €6
Churros with chocolate sauce: €8
Churros with Nutella: €8

1. Place order
2. Deliver order
0. Exit
----------------------------------------
```

---

# 3. System Design

The application is composed of the following classes:

| Class   | Description                    |
|---------|--------------------------------|
| Order   | Represents a customer's order  |
| Churros | Represents churros menu items  |
| Program | Contains the main menu and program logic |

---

# 4. Object-Oriented Programming Concepts Used

## 4.1 Classes and Objects

The system is structured using classes such as **Order** and **Churros**. Objects of these classes are created to represent real-world entities.

**Example:**

```csharp
Order order = new Order(1, "Churros with Plain Sugar", 2);
```

## 4.2 Encapsulation

Attributes are declared as private fields and accessed through public properties.

**Example:**

```csharp
private int order_no;
public int OrderNo { get; set; }
```

This protects internal data and ensures controlled access.

## 4.3 Properties

Properties allow safe access and modification of class attributes.

**Example:**

```csharp
public string OrderDetails { get; set; }
public int Quantity { get; set; }
```

## 4.4 Constructors

Constructors are used to initialize object attributes when a new object is created.

**Example:**

```csharp
public Order(int orderNo, string orderDetails, int quantity)
{
    OrderNo = orderNo;
    OrderDetails = orderDetails;
    Quantity = quantity;
}
```

## 4.5 Access Modifiers

Access modifiers define the visibility of class members.

| Modifier | Purpose                        |
|----------|--------------------------------|
| public   | Accessible from any class      |
| private  | Accessible only within the class |

---

# 5. Data Structures Used

A **Queue** data structure is used to manage customer orders.

```csharp
Queue<Order> orderQueue = new Queue<Order>();
```

### Why Queue?

The queue ensures that orders are delivered in the same order they were placed: **FIFO (First In First Out)**.

**Example flow:**

- Customer 1 → Order 1  
- Customer 2 → Order 2  
- Customer 3 → Order 3  

**Delivery order:** 1 → 2 → 3

---

# 6. Order Class

The Order class contains the following attributes:

| Attribute    | Description           |
|-------------|------------------------|
| OrderNo     | Unique order number   |
| OrderDetails| Type of churros       |
| Quantity    | Number of items       |
| Bill        | Total payment amount  |

### Methods

| Method        | Description                |
|---------------|----------------------------|
| PlaceOrder()  | Creates a new order       |
| PayBill()     | Calculates the total bill |
| CollectOrder()| Removes order from queue  |

**Example bill calculation:** Bill = Price × Quantity

---

# 7. Unit Testing

Unit tests were implemented using **MSTest** to verify that system functions operate correctly.

### Test Framework Used

- **MSTest**

### Required packages

- Microsoft.NET.Test.Sdk
- MSTest.TestAdapter
- MSTest.TestFramework

---

# 8. Implemented Unit Tests

The following tests were created to verify the `PayBill()` method.

| Test Name                  | Purpose                                |
|----------------------------|----------------------------------------|
| PayBillTest                | Tests basic bill calculation           |
| PayBillMultipleQuantityTest| Tests calculation with multiple items  |
| PayBillSingleItemTest      | Tests bill for one item                |
| PayBillZeroQuantityTest    | Tests edge case when quantity is zero  |
| CreateOrderTest            | Verifies order creation                |

**Example test:**

```csharp
[TestMethod]
public void PayBillTest()
{
    Order order = new Order(1, "Churros with Plain Sugar", 2);

    double result = order.PayBill(6);

    Assert.AreEqual(12, result);
}
```

This test verifies that the bill calculation is correct.

---

# 9. How to Run the Project

1. Navigate to the project folder:

   ```bash
   cd question1
   ```

2. Build the project:

   ```bash
   dotnet build
   ```

3. Run the program:

   ```bash
   dotnet run
   ```

The console menu will appear, allowing the user to interact with the ordering system.

---

# 10. How to Run Unit Tests

1. Navigate to the test folder (from the project root):

   ```bash
   cd question1/Tests
   ```

2. Execute all unit tests:

   ```bash
   dotnet test
   ```

**Example output:**

```
Starting test execution...

Passed   PayBillTest
Passed   PayBillMultipleQuantityTest
Passed   PayBillSingleItemTest
Passed   PayBillZeroQuantityTest
Passed   CreateOrderTest

Total tests: 5
Passed: 5
Failed: 0
```

---

# 11. Conclusion

This project demonstrates the implementation of a menu-driven console application using C# and Object-Oriented Programming principles. The use of classes, encapsulation, constructors, and properties ensures modular and maintainable code.

The use of a queue data structure ensures that orders are processed in the correct order. Additionally, unit testing with MSTest ensures that critical methods such as bill calculation function correctly and reliably.

Overall, the project highlights practical application of OOP concepts, data structures, and software testing in the development of a simple real-world ordering system.
