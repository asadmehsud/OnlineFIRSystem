# OnlineFIRSystem – Online First Information Report Management System

**OnlineFIRSystem** is a software application developed to facilitate citizens in registering FIRs online and tracking their status without visiting police stations. It is designed for improved transparency, faster processing, and easier communication between civilians and law enforcement authorities.

## 🎯 Project Objective

To digitalize the traditional FIR process by allowing users to submit complaints online and track their status, while enabling police officers/admins to manage, verify, and update FIR records through a secure system.

---

## 🔍 Features

### 👥 Citizen Features
- Register and log in securely
- Submit FIRs with detailed descriptions
- View status updates and police responses
- Download a copy of FIR

### 👮 Police/Admin Features
- Login and view submitted FIRs
- Verify and approve or reject FIRs
- Assign FIRs to officers
- Update FIR progress and mark as resolved
- Generate reports

---

## 🧰 Tech Stack

| Technology         | Description                         |
|-------------------|-------------------------------------|
| C# / ASP.NET       | Application logic (Desktop or Web)  |
| Windows Forms / Razor Pages / MVC | UI layer            |
| ADO.NET or Entity Framework Core | Data Access          |
| SQL Server         | Database management                 |
| Crystal Reports    | (optional) Report printing          |
| Git & GitHub       | Version control                     |

---

## 🗃 Database Design (Entities)

- `Users` (Citizens)
- `FIRs` (FIR Records)
- `PoliceStations`
- `Admins` or `Officers`
- `FIR_StatusUpdates`
- `Attachments` (optional)

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2022+
- SQL Server 2019+
- .NET SDK (Framework or Core, depending on your version)

### Setup Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/asad-mehsud/OnlineFIRSystem.git
