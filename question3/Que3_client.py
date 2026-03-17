import socket

HOST = "127.0.0.1"
PORT = 4000

print("EasyDrive Registration System")

name = input("Enter Name: ")
address = input("Enter Address: ")
pps = input("Enter PPS Number: ")
license_doc = input("Enter Driving License Number: ")

data = f"{name}|{address}|{pps}|{license_doc}"

client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

client.connect((HOST, PORT))

client.send(data.encode())

reg_no = client.recv(1024).decode()

print("\nRegistration Successful!")
print("Your Registration Number:", reg_no)

client.close()