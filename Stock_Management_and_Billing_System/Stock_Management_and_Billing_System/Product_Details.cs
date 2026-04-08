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
    public partial class Product_Details : Form
    {
        // Database connection string
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO-YOGA-SLI\MSSQLSERVER02;Initial Catalog=Stock_Management_and_Billing_System_For_a_Grocery;Integrated Security=True");
        
        public Product_Details()
        {
            InitializeComponent();
        }
        void clearAll()
        {
            // Clear textboxes 
            txt_product_id.Clear();
            txt_product_name.Clear();
            dtp_manufacture_date.Value = DateTimePicker.MinimumDateTime;
            dtp_expire_date.Value = DateTimePicker.MinimumDateTime;
            txt_unit_price.Clear();
            txt_stock_quantity.Clear();
        }
        private void groupbox_payment_details_Enter(object sender, EventArgs e)
        {

        }

        private void Product_Details_Load(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * FROM Product_Details";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView_ProductDetails.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            // Navigate to the Home form 
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
            string Product_ID = txt_product_id.Text;
            string Product_Name = txt_product_name.Text;
            DateTime Manufacture_Date = dtp_manufacture_date.Value;
            DateTime Expire_Date = dtp_expire_date.Value;
            string Unit_Price = txt_unit_price.Text;
            string Stock_Quantity = txt_stock_quantity.Text;

            string format = "INSERT INTO Product_Details (Product_ID, Product_Name, Manufacture_Date, Expire_Date, Unit_Price, Stock_Quantity) VALUES " +
                "(@Product_ID, @Product_Name, @Manufacture_Date, @Expire_Date, @Unit_Price, @Stock_Quantity)";


            try
            {
                con.Open();

                SqlCommand insertcommand = new SqlCommand(format, con);

                insertcommand.Parameters.AddWithValue("@Product_ID", Product_ID);
                insertcommand.Parameters.AddWithValue("@Product_Name", Product_Name);
                insertcommand.Parameters.AddWithValue("@Manufacture_Date", Manufacture_Date);
                insertcommand.Parameters.AddWithValue("@Expire_Date", Expire_Date);
                insertcommand.Parameters.AddWithValue("@Unit_Price", Unit_Price);
                insertcommand.Parameters.AddWithValue("@Stock_Quantity", Stock_Quantity);

                int r = insertcommand.ExecuteNonQuery();

                if (r != 0)
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
            string Product_ID = txt_product_id.Text;
            string Product_Name = txt_product_name.Text;
            DateTime Manufacture_Date = dtp_manufacture_date.Value;
            DateTime Expire_Date = dtp_expire_date.Value;
            string Unit_Price = txt_unit_price.Text;
            string Stock_Quantity = txt_stock_quantity.Text;
           

            string format = "UPDATE Product_Details SET Product_ID=@Product_ID, Product_Name=@Product_Name, Manufacture_Date=@Manufacture_Date, " +
                "Expire_Date=@Expire_Date, Unit_Price=@Unit_Price, Stock_Quantity=@Stock_Quantity WHERE Product_ID=@Product_ID ;";


            try
            {
                con.Open();

                SqlCommand updatecommand = new SqlCommand(format, con);

                updatecommand.Parameters.AddWithValue("@Product_ID", Product_ID);
                updatecommand.Parameters.AddWithValue("@Product_Name", Product_Name);
                updatecommand.Parameters.AddWithValue("@Manufacture_Date", Manufacture_Date);
                updatecommand.Parameters.AddWithValue("@Expire_Date", Expire_Date);
                updatecommand.Parameters.AddWithValue("@Unit_Price", Unit_Price);
                updatecommand.Parameters.AddWithValue("@Stock_Quantity", Stock_Quantity);

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
            // Delete data from the database
            int Product_ID = int.Parse(txt_product_id.Text);

            string format = "DELETE FROM Product_Details WHERE Product_ID=@Product_ID;";

            try
            {
                con.Open();

                SqlCommand deletecommand = new SqlCommand(format, con);

                deletecommand.Parameters.AddWithValue("@Product_ID", Product_ID);

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
            int Product_ID = int.Parse(txt_product_id.Text);

            string format = "SELECT * FROM Product_Details WHERE Product_ID  = @Product_ID ";

            try
            {
                con.Open();
                SqlCommand searchcommand = new SqlCommand(format, con);
                searchcommand.Parameters.AddWithValue("@Product_ID ", Product_ID);
                SqlDataReader reader = searchcommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_product_id.Text = reader[0].ToString();
                        txt_product_name.Text = reader[1].ToString();
                        dtp_manufacture_date.Text = reader[2].ToString();
                        dtp_expire_date.Text = reader[3].ToString();
                        txt_unit_price.Text = reader[4].ToString();
                        txt_stock_quantity.Text = reader[5].ToString();
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

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            // Navigate to the Home form
            this.Hide();
            Home Home = new Home();
            Home.ShowDialog();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}
