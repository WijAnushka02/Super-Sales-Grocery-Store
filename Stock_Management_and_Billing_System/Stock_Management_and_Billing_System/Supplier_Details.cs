using System;
using System.Collections;
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
    public partial class Supplier_Details : Form
    {
        // Database connection string
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO-YOGA-SLI\MSSQLSERVER02; Initial Catalog=Stock_Management_and_Billing_System_For_a_Grocery; Integrated Security=True");

        public Supplier_Details()
        {
            InitializeComponent();
        }
        void clearAll()
        {
            // Clear textboxes
            txt_supplier_id.Clear();
            txt_product_id.Clear();
            txt_supplier_name.Clear();
            txt_product_name.Clear();
            txt_stock_price.Clear();
            txt_contact_number.Clear();
            txt_email.Clear();
        }

        private void groupbox_payment_details_Enter(object sender, EventArgs e)
        {

        }

        private void Supplier_Details_Load(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * FROM Supplier_Details";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView_SupplierDetails.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit(); 
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            clearAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Add supplier data to the database
            string Supplier_ID = txt_supplier_id.Text;
            string Product_ID = txt_product_id.Text;
            string Supplier_Name = txt_supplier_name.Text;
            string Product_Name = txt_product_name.Text;
            string Stock_Price = txt_stock_price.Text;
            string Contact_Number = txt_contact_number.Text;
            string Email = txt_email.Text;

            string format = "INSERT INTO Supplier_Details (Supplier_ID, Product_ID, Supplier_Name, Product_Name, Stock_Price, Contact_Number, Email) VALUES " +
                "(@Supplier_ID, @Product_ID, @Supplier_Name, @Product_Name, @Stock_Price, @Contact_Number, @Email )";

            try
            {
                con.Open();

                SqlCommand insertcommand = new SqlCommand(format, con);

                insertcommand.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                insertcommand.Parameters.AddWithValue("@Product_ID", Product_ID);
                insertcommand.Parameters.AddWithValue("@Supplier_Name", Supplier_Name);
                insertcommand.Parameters.AddWithValue("@Product_Name", Product_Name);
                insertcommand.Parameters.AddWithValue("@Stock_Price", Stock_Price);
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
            // Update supplier data in the database
            string Supplier_ID = txt_supplier_id.Text;
            string Product_ID = txt_product_id.Text;
            string Supplier_Name = txt_supplier_name.Text;
            string Product_Name = txt_product_name.Text;
            string Stock_Price = txt_stock_price.Text;
            string Contact_Number = txt_contact_number.Text;
            string Email = txt_email.Text;

            string format = "UPDATE Supplier_Details SET Supplier_ID=@Supplier_ID, Product_ID=@Product_ID, Supplier_Name=@Supplier_Name, " +
                "Product_Name=@Product_Name, Stock_Price=@Stock_Price, Contact_Number=@Contact_Number, Email=@Email WHERE Supplier_ID=@Supplier_ID ;";


            try
            {
                con.Open();

                SqlCommand updatecommand = new SqlCommand(format, con);

                updatecommand.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                updatecommand.Parameters.AddWithValue("@Product_ID", Product_ID);
                updatecommand.Parameters.AddWithValue("@Supplier_Name", Supplier_Name);
                updatecommand.Parameters.AddWithValue("@Product_Name", Product_Name);
                updatecommand.Parameters.AddWithValue("@Stock_Price", Stock_Price);
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

                con.Close();
                clearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Delete supplier data from the database
            int Supplier_ID = int.Parse(txt_supplier_id.Text);

            string format = "DELETE FROM Supplier_Details WHERE Supplier_ID=@Supplier_ID;";

            try
            {
                con.Open();

                SqlCommand deletecommand = new SqlCommand(format, con);

                deletecommand.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);

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
            // Search for supplier data in the database
            int Supplier_ID = int.Parse(txt_supplier_id.Text);

            string format = "SELECT * FROM Supplier_Details WHERE Supplier_ID  = @Supplier_ID ";

            try
            {
                con.Open();
                SqlCommand searchcommand = new SqlCommand(format, con);
                searchcommand.Parameters.AddWithValue("@Supplier_ID ", Supplier_ID);
                SqlDataReader reader = searchcommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_supplier_id.Text = reader[0].ToString();
                        txt_product_id.Text = reader[1].ToString();
                        txt_supplier_name.Text = reader[2].ToString();
                        txt_product_name.Text = reader[3].ToString();
                        txt_stock_price.Text = reader[4].ToString();
                        txt_contact_number.Text = reader[5].ToString();
                        txt_email.Text = reader[6].ToString();
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

        private void btn_home_Click(object sender, EventArgs e)
        {
            // Navigate to the Home form
            this.Hide();
            Home Home = new Home();
            Home.ShowDialog();
        }
    }
}