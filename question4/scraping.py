import requests
from bs4 import BeautifulSoup
import csv

url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

response = requests.get(url)

soup = BeautifulSoup(response.text, "html.parser")

books = soup.find_all("article", class_="product_pod")

data = []

for book in books:

    title = book.h3.a["title"]

    price = book.find("p", class_="price_color").text

    rating_class = book.find("p", class_="star-rating")["class"][1]

    rating_map = {
        "One":1,
        "Two":2,
        "Three":3,
        "Four":4,
        "Five":5
    }

    rating = rating_map.get(rating_class, 0)

    data.append([title, rating, price])


# Save to CSV
with open("books.csv", "w", newline="", encoding="utf-8") as file:

    writer = csv.writer(file)

    writer.writerow(["Book Name", "Rating", "Price"])

    writer.writerows(data)


print("Data successfully saved to books.csv\n")


# Read CSV and display in terminal
print("Displaying data from CSV:\n")

with open("books.csv", "r", encoding="utf-8") as file:

    reader = csv.reader(file)

    for row in reader:
        print(row)