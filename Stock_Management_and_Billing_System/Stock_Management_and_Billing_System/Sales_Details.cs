using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Stock_Management_and_Billing_System
{
    public partial class Sales_Details : Form
    {
        // Database connection string
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO-YOGA-SLI\MSSQLSERVER02; Initial Catalog=Stock_Management_and_Billing_System_For_a_Grocery; Integrated Security=True");

        public Sales_Details()
        {
            InitializeComponent();
        }
        void clearAll()
        {
            // Clear textboxes
            txt_sales_id.Clear();
            txt_product_id.Clear();
            txt_supplier_id.Clear();
            txt_customer_id.Clear();
            txt_product_name.Clear();
            txt_quantity_sold.Clear();
            txt_quantity_available.Clear();
            dtp_sales_date.Value = DateTimePicker.MinimumDateTime;
        }

        private void Sales_Details_Load(object sender, EventArgs e)
        {
            LoadDataGridView(); 
        }
        private void LoadDataGridView()
        {
            try
            {
                // Load data from the database into the DataGridView
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Sales_Details";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView_SalesDetails.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Add sales data to the database
            // Update stock quantity in Product_Details table
            string Sales_ID = txt_sales_id.Text;
            string Product_ID = txt_product_id.Text;
            string Supplier_ID = txt_supplier_id.Text;
            string Customer_ID = txt_customer_id.Text;
            string Product_Name = txt_product_name.Text;
            string Quantity_Sold = txt_quantity_sold.Text;
            string Quantity_Available = txt_quantity_available.Text;
            DateTime Sales_Date = dtp_sales_date.Value;

            string format = "INSERT INTO Sales_Details (Sales_ID, Product_ID, Supplier_ID, Customer_ID, Product_Name, Quantity_Sold, Quantity_Available, Sales_Date) VALUES " +
                "(@Sales_ID, @Product_ID, @Supplier_ID, @Customer_ID, @Product_Name, @Quantity_Sold, @Quantity_Available, @Sales_Date)";


            try
            {
                con.Open();

                SqlCommand insertcommand = new SqlCommand(format, con);

                insertcommand.Parameters.AddWithValue("@Sales_ID", Sales_ID);
                insertcommand.Parameters.AddWithValue("@Product_ID", Product_ID);
                insertcommand.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                insertcommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                insertcommand.Parameters.AddWithValue("@Product_Name", Product_Name);
                insertcommand.Parameters.AddWithValue("@Quantity_Sold", Quantity_Sold);
                insertcommand.Parameters.AddWithValue("@Quantity_Available", Quantity_Available);
                insertcommand.Parameters.AddWithValue("@Sales_Date", Sales_Date);

                int r = insertcommand.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Data Added Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Not Added Successful!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();


                string sql_query = "Update Product_Details SET Stock_Quantity= Stock_Quantity - "+ Quantity_Sold + " where Product_ID='"+ Product_ID + "'";


                con.Open();

                SqlCommand cmd = new SqlCommand(sql_query, con);


                int r1 = cmd.ExecuteNonQuery();

                if (r1 > 0)
                {
                    MessageBox.Show("Stock Updated Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Stock Not Updated Successfully!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Delete sales data from the database
            int Sales_ID = int.Parse(txt_sales_id.Text);

            string format = "DELETE FROM Sales_Details WHERE Sales_ID=@Sales_ID;";

            try
            {
                con.Open();

                SqlCommand deletecommand = new SqlCommand(format, con);

                deletecommand.Parameters.AddWithValue("@Sales_ID", Sales_ID);

                int r = deletecommand.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Record Deleted Successfully!, Please Update the Stock in Product Details Table...!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Record Not Deleted Suceesfully!", " Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Search for sales data in the database
            int Sales_ID = int.Parse(txt_sales_id.Text);

            string format = "SELECT * FROM Sales_Details WHERE Sales_ID  = @Sales_ID ";

            try
            {
                con.Open();
                SqlCommand searchcommand = new SqlCommand(format, con);
                searchcommand.Parameters.AddWithValue("@Sales_ID ", Sales_ID);
                SqlDataReader reader = searchcommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_sales_id.Text = reader[0].ToString();
                        txt_product_id.Text = reader[1].ToString();
                        txt_supplier_id.Text = reader[2].ToString();
                        txt_customer_id.Text = reader[3].ToString();
                        txt_product_name.Text = reader[4].ToString();
                        txt_quantity_sold.Text = reader[5].ToString();
                        txt_quantity_available.Text = reader[6].ToString();
                        dtp_sales_date.Text = reader[7].ToString();
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

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            // Clear textboxes
            clearAll();
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
