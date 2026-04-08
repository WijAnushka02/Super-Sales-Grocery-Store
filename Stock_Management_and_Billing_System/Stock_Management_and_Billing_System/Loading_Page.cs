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
    public partial class Loading_Page : Form
    {
        public Loading_Page()
        {
            InitializeComponent();
        }

        // Method called when the form loads
        private void Loading_Page_Load(object sender, EventArgs e)
        {
            // Start the timer
            timer_loading_page.Start();
        }

        // Timer tick event handler
        private void timer_loading_page_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;

                // Update the progress label
                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                // Stop the timer
                timer_loading_page.Stop();

                // Hide the current form
                this.Hide();

                // Show the login form
                Login Login = new Login();
                Login.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_loading_Click(object sender, EventArgs e)
        {

        }
    }
}
