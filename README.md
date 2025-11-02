Week 7 – Item Sorter Robot
This project builds on the previous “Inventory System” from Week 6 and adds a robot integration that automatically collects items for shipment after an order is processed.
Project Description
The application is developed in C# using Avalonia UI. It combines an inventory and order management system with a robotic arm (UR16e) that executes movements through URScript programs. The robot connects via TCP/IP and performs predefined pick-and-place movements for each order.
Features
Processes orders through the graphical interface
Sends URScript commands to a physical or simulated robot
Uses asynchronous programming to keep the interface responsive
Displays live status messages for robot operations
Includes a test function to verify robot connection and movement
Technologies
C# (.NET 8, Avalonia UI)
URScript
TCP/IP Communication
MVVM Architecture
Robot Setup
Connect the robot via Ethernet.
Set the correct IP address in MainWindow.axaml.cs:
_robot.IpAddress = "172.20.254.201";
Ensure the robot is in Remote Control and Brake Released mode.
Use the “Test Robot Move” button to verify the connection.
Use the “Process (Robot)” button to execute order handling.
Project Structure
InventorySystem/
 ┣ Models/
 ┣ ViewModels/
 ┣ Robot.cs
 ┣ ItemSorterRobot.cs
 ┣ MainWindow.axaml
 ┣ MainWindow.axaml.cs
 ┣ robot.script
 ┣ App.axaml
 ┣ Program.cs
 ┗ README.md
Author
Hania Ahmed
DTU – 62236 Industrial Programming, Fall 2025
