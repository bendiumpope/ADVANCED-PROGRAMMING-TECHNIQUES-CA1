# Book Data Web Scraper

**Advanced Programming Techniques – CA1**
**Section II: Programming in Python – Task 4**

Language: **Python**
Libraries: **Requests, BeautifulSoup, CSV**

---

# 1. Project Overview

This project implements a **Python web scraping application** that extracts information from a webpage and stores it in a CSV file.

The webpage used for scraping is:

https://books.toscrape.com/catalogue/category/books/travel_2/index.html

The program extracts the following information for each book:

* Book Name
* Rating
* Price

After scraping the data, the program performs the following steps:

1. Saves the extracted data to a **CSV file**
2. Reads the CSV file
3. Displays the stored data in the **terminal window**

---

# 2. Technologies and Libraries Used

The program uses the following Python libraries:

| Library       | Purpose                                         |
| ------------- | ----------------------------------------------- |
| requests      | Sends HTTP requests to retrieve webpage content |
| BeautifulSoup | Parses HTML and extracts required data          |
| csv           | Stores and retrieves data from CSV files        |

These libraries are commonly used for **web scraping and data processing in Python**.

---

# 3. Data Extracted

The following information is extracted from the webpage:

| Field     | Description                 |
| --------- | --------------------------- |
| Book Name | Title of the book           |
| Rating    | Rating value of the book    |
| Price     | Price of the book in pounds |

Example scraped data:

```text
Book Name: It's Only the Himalayas
Rating: 2
Price: £45.17
```

---

# 4. Program Workflow

The program follows the steps below:

1. Send a request to the webpage using the **requests module**
2. Parse the HTML content using **BeautifulSoup**
3. Locate all book entries in the webpage
4. Extract:

   * Book title
   * Price
   * Rating
5. Store the extracted data in a **CSV file**
6. Open the CSV file
7. Display the stored data in the terminal

---

# 5. Project Structure

```text
question4
│
├── scraping.py
├── books.csv
└── README.md
```

| File        | Description                              |
| ----------- | ---------------------------------------- |
| scraping.py | Python script that performs web scraping |
| books.csv   | CSV file containing scraped data         |
| README.md   | Project documentation                    |

---

# 6. Example CSV File Output

After running the program, the following CSV file will be created:

```text
books.csv
```

Example content:

```text
Book Name,Rating,Price
It's Only the Himalayas,2,£45.17
Full Moon over Noah’s Ark,4,£49.43
See America,3,£48.87
Vagabonding,2,£36.94
Under the Tuscan Sun,3,£37.33
```

---

# 7. Example Terminal Output

When the program runs, it displays the data retrieved from the CSV file.

Example:

```text
Data successfully saved to books.csv

Displaying data from CSV:

['Book Name', 'Rating', 'Price']
["It's Only the Himalayas", '2', '£45.17']
['Full Moon over Noah’s Ark', '4', '£49.43']
['See America', '3', '£48.87']
['Vagabonding', '2', '£36.94']
```

---

# 8. Requirements

Before running the program, ensure the following are installed:

* Python 3
* Required Python libraries

---

# 9. Install Required Libraries

Install the required libraries using pip:

```bash
pip install requests beautifulsoup4
```

If using Python3 explicitly:

```bash
pip3 install requests beautifulsoup4
```

---

# 10. How to Run the Program

### Step 1 – Navigate to the project directory

```bash
cd question4
```

### Step 2 – Run the Python script

```bash
python scraping.py
```

or

```bash
python3 scraping.py
```

---

# 11. Program Output

The program will:

1. Scrape book data from the website
2. Save the data to **books.csv**
3. Display the contents of the CSV file in the terminal

---

# 12. Files to Submit

The following files should be submitted for the assignment:

* `scraping.py`
* `books.csv`
* Screenshots showing:

  * Successful program execution
  * Data displayed in the terminal
  * CSV file contents

---

# 13. Conclusion

This project demonstrates the use of **Python for web scraping and data storage**. The program successfully retrieves book information from a webpage, stores the data in a structured CSV format, and displays the results in the terminal.

The implementation highlights practical use of **HTTP requests, HTML parsing, and file handling**, which are important skills for data extraction and automation tasks.
