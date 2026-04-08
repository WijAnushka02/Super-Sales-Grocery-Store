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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from textboxes
            string username = this.txt_username.Text;
            string password = this.txt_password.Text;

            // Check if both username and password are empty
            if (username == "Admin" && password == "1234")
            {
                // Show success message
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the current form
                this.Hide();

                // Show the Home form
                Home f2 = new Home();
                f2.ShowDialog();
            }
            else
            {
                // Show error message
                MessageBox.Show("Login Not Successful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_username.Focus();
                txt_password.SelectAll();

                // Clear password textbox
                txt_password.Clear();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void ch_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility based on checkbox state
            if (ch_show_pass.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
