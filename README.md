# Advanced Programming Techniques CA1

This repository contains four tasks implemented in separate folders. Each task includes a description of what was done and instructions for running the code.

## Contents

- [Question 1](#question-1-churros-order-system)
- [Question 2](#question-2-periodic-table-information-system)
- [Question 3](#question-3-easydrive-car-rental-registration-system)
- [Question 4](#question-4-book-data-web-scraper)

---

## Question 1: Churros Order System

A C# console application for a food truck that manages churros orders using a FIFO queue.

### What it does

- Displays a churros menu
- Accepts new orders
- Stores orders in a queue
- Delivers orders in the order received
- Uses OOP concepts with `Order`, `Churros`, and `Program` classes

### How to run

1. Open a terminal
2. `cd question1`
3. `dotnet run`
4. `dotnet test` - to run test

### Notes

- Uses `Queue<Order>` for FIFO order processing
- Includes MSTest unit tests in `question1/Tests`

---

## Question 2: Periodic Table Information System

A C# console application that stores information for the first 30 periodic table elements and lets the user look them up by atomic number.

### What it does

- Stores the first 30 elements in a `Dictionary<int, Element>`
- Prompts for an atomic number
- Displays element name and classification
- Validates input and handles invalid values

### How to run

1. Open a terminal
2. `cd question2`
3. `dotnet build`
4. `dotnet run`

---

## Question 3: EasyDrive Car Rental Registration System

A Python TCP client-server application for registering customers in a car rental service and storing the data in SQLite.

### What it does

- Uses a TCP socket connection between client and server
- Collects customer details: name, address, PPS number, and driving license
- Stores the data in `easydrive.db`
- Returns a unique registration number to the client

### How to run

1. Open two terminal windows
2. In one window: `cd question3` and `python Que3_server.py`
3. In the other window: `cd question3` and `python Que3_client.py`

---

## Question 4: Book Data Web Scraper

A Python web scraper for `books.toscrape.com` that extracts book titles, ratings, and prices, saves them to `books.csv`, and prints the results.

### What it does

- Uses `requests` to fetch the webpage
- Parses HTML with `BeautifulSoup`
- Extracts book name, rating, and price
- Saves results to `books.csv`
- Reads and displays the CSV contents

### Requirements

- Python 3
- `requests`
- `beautifulsoup4`

Install dependencies:

```bash
pip install requests beautifulsoup4
```

### How to run

1. Open a terminal
2. `cd question4`
3. `python scraping.py`

---

## Notes

- `question1` and `question2` are C# projects
- `question3` and `question4` are Python projects
- Each folder has its own README with full details and example output
