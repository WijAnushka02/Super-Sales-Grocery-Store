
# 🛒 Stock Management and Billing System for "Super Sales" Grocery

A comprehensive digital solution designed to transition grocery stores from manual, handwritten stock management to an automated, integrated platform. This system streamlines inventory control and billing processes to enhance operational efficiency and accuracy.

---

## 🚀 Key Features

* **Inventory Management:** Real-time tracking of stock levels, product categorization, and automated alerts for low stock.
* **Efficient Billing:** User-friendly interface for cashiers featuring barcode scanning and multiple payment options.
* **Data-Driven Insights:** Reporting tools to analyze sales trends, popular products, and stock turnover rates.
* **Automated Replenishment:** System-generated reorder requests based on predefined stock thresholds.
* **Secure User Management:** Role-based access control with secure login authentication.

---

## 🛠️ Tech Stack

* **Development Environment:** Microsoft Visual Studio 2022
* **Programming Language:** C# (Windows Forms)
* **Database Management:** MS SQL Server 2022
* **Tooling:** SQL Server Management Studio (SSMS)

---

## 💻 System Requirements

### Hardware

* **Processor:** Intel Core i7
* **Memory:** 8GB RAM
* **Storage:** 256GB SSD

### Software

* Windows Operating System
* .NET Framework (compatible with Visual Studio 2022)
* SQL Server 2022 instance

---

## 📂 Project Structure

The system is built using the Waterfall methodology and includes the following modules:

* **Login Module:** Secure gateway for authorized personnel
* **Customer Details:** Management of customer records and history
* **Product Details:** Database management for inventory items, including manufacture and expiry dates
* **Payment & Sales Details:** Transaction handling and sales record maintenance
* **Supplier Details:** Tracking supplier information and stock replenishment history

---

## 🏗️ Setup and Installation

### 1. Clone the Repository

```bash
git clone https://github.com/YourUsername/YourRepoName.git
```

### 2. Database Configuration

* Open SQL Server Management Studio
* Create a new database named:
  `Stock_Management_and_Billing_System_For_a_Grocery`
* Execute the provided SQL scripts to create required tables (Customer, Payment, Product, Sales, Supplier)

### 3. Update Connection String

* Open the project in Visual Studio
* Locate the `SqlConnection` string in form files (e.g., `Customer_Details.cs`)
* Update the `Data Source` according to your local SQL Server instance

### 4. Run the Application

* Build and run the project in Visual Studio
* Use default credentials:

  * **Username:** Admin
  * **Password:** 1234

---

## 📝 Contributors

* Anushka Wijesinghe
* Maneesha Sachinthaka
* Nipuni Bhagya
* Udeshika Piyumali
* Himasha Dilrukshi
* Kavisha Lunugama
* Thejaka Wijerathna

**Under the supervision of Mr. Nuwan Hirantha Rathnayake**

---

