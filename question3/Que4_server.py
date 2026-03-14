import socket
import sqlite3
import uuid

HOST = "127.0.0.1"
PORT = 4000

# Create database
conn = sqlite3.connect("easydrive.db")
cursor = conn.cursor()

cursor.execute("""
CREATE TABLE IF NOT EXISTS customers (
    reg_no TEXT PRIMARY KEY,
    name TEXT,
    address TEXT,
    pps TEXT,
    license TEXT
)
""")

conn.commit()

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((HOST, PORT))
server.listen()

print("Server running...")
print("Waiting for client connection...")

while True:

    conn_socket, addr = server.accept()
    print("Connected by", addr)

    data = conn_socket.recv(1024).decode()

    name, address, pps, license_doc = data.split("|")

    reg_no = str(uuid.uuid4())[:8]

    cursor.execute(
        "INSERT INTO customers VALUES (?, ?, ?, ?, ?)",
        (reg_no, name, address, pps, license_doc)
    )

    conn.commit()

    conn_socket.send(reg_no.encode())

    print("Customer registered:", name)
    print("Registration Number:", reg_no)

    conn_socket.close()