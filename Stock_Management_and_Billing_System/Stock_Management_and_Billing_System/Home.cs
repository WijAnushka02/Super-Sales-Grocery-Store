using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_and_Billing_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the login form
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        // Event handlers for all the buttons to navigate to different forms
        private void btn_customer_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Details Customer_Details = new Customer_Details();
            Customer_Details.ShowDialog();
        }

        private void btn_payment_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_Details Payment_Details = new Payment_Details();
            Payment_Details.ShowDialog();
        }

        private void btn_product_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_Details Product_Details = new Product_Details();
            Product_Details.ShowDialog();
        }

        private void btn_sales_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales_Details Sales_Details = new Sales_Details();
            Sales_Details.ShowDialog();
        }

        private void btn_supplier_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier_Details Supplier_Details = new Supplier_Details();
            Supplier_Details.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}
