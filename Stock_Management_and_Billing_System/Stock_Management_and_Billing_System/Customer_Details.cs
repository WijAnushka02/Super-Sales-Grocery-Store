using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_and_Billing_System
{
    public partial class Customer_Details : Form
    {
        // Database connection string
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO-YOGA-SLI\MSSQLSERVER02; Initial Catalog=Stock_Management_and_Billing_System_For_a_Grocery; Integrated Security=True");

        public Customer_Details()
        {
            InitializeComponent();
        }
        void clearAll()
        {
            // Clear textboxes
            txt_customer_id.Clear();
            txt_first_name.Clear();
            txt_last_name.Clear();
            txt_contact_no.Clear();
            txt_email.Clear();
        }

        private void Customer_Details_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                // Load data from the database into the DataGridView
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Customer_Details";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_CustomerDetails.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            clearAll(); 
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Add data to the database
            string Customer_ID = txt_customer_id.Text;
            string First_Name = txt_first_name.Text;
            string Last_Name = txt_last_name.Text;
            string Contact_Number = txt_contact_no.Text;
            string Email = txt_email.Text;

            string format = "INSERT INTO Customer_Details (Customer_ID, First_Name, Last_Name, Contact_Number, Email) VALUES (@Customer_ID, @First_Name, @Last_Name, @Contact_Number, @Email)";


            try
            {
                con.Open();

                SqlCommand insertcommand = new SqlCommand(format, con);

                insertcommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                insertcommand.Parameters.AddWithValue("@First_Name", First_Name);
                insertcommand.Parameters.AddWithValue("@Last_Name", Last_Name);
                insertcommand.Parameters.AddWithValue("@Contact_Number", Contact_Number);
                insertcommand.Parameters.AddWithValue("@Email", Email);

                int r = insertcommand.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Data Added Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Data Not Added Successful!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                clearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Update data in the database
            int Customer_ID = int.Parse(txt_customer_id.Text);
            string First_Name = txt_first_name.Text;
            string Last_Name = txt_last_name.Text;
            string Contact_Number = txt_contact_no.Text;
            string Email = txt_email.Text;

            string format = "UPDATE Customer_Details SET Customer_ID=@Customer_ID, First_Name=@First_Name, Last_Name=@Last_Name, Contact_Number=@Contact_Number, " +
                "Email=@Email WHERE Customer_ID=@Customer_ID ;";


            try
            {
                con.Open();

                SqlCommand updatecommand = new SqlCommand(format, con);

                updatecommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                updatecommand.Parameters.AddWithValue("@First_Name", First_Name);
                updatecommand.Parameters.AddWithValue("@Last_Name", Last_Name);
                updatecommand.Parameters.AddWithValue("@Contact_Number", Contact_Number);
                updatecommand.Parameters.AddWithValue("@Email", Email);

                int rowsAffected = updatecommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Updated Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("No Data Updated! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
                clearAll();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Delete data from the database
            int Customer_ID = int.Parse(txt_customer_id.Text);

            string format = "DELETE FROM Customer_Details WHERE Customer_ID=@Customer_ID;";

            try
            {
                con.Open();

                SqlCommand deletecommand = new SqlCommand(format, con);

                deletecommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);

                int r = deletecommand.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show(" Record Deleted Successfully! ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show(" Record Not Deleted Suceesfully!", " Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Search for data in the database
            int Customer_ID = int.Parse(txt_customer_id.Text);

            string format = "SELECT * FROM Customer_Details WHERE Customer_ID  = @Customer_ID ";

            try
            {
                con.Open();
                SqlCommand searchcommand = new SqlCommand(format, con);
                searchcommand.Parameters.AddWithValue("@Customer_ID ", Customer_ID);
                SqlDataReader reader = searchcommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_customer_id.Text = reader[0].ToString();
                        txt_first_name.Text = reader[1].ToString();
                        txt_last_name.Text = reader[2].ToString();
                        txt_contact_no.Text = reader[3].ToString();
                        txt_email.Text = reader[4].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No Data in the database with this ID ", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void dataGridView_CustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}