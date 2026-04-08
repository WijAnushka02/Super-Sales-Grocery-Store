using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Stock_Management_and_Billing_System
{
    public partial class Payment_Details : Form
    {
        // Database connection string
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO-YOGA-SLI\MSSQLSERVER02; Initial Catalog=Stock_Management_and_Billing_System_For_a_Grocery; Integrated Security=True");

        public Payment_Details()
        {
            InitializeComponent();

            // Initialize printDocument and attach event handler
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        void clearAll()
        {
            // Clear textboxes 
            txt_payment_id.Clear();
            txt_product_id.Clear();
            txt_customer_id.Clear();
            txt_supplier_id.Clear();
            txt_product_name.Clear();
            txt_payment_method.Clear();
            txt_price.Clear();
            dtp_payment_date.Value = DateTimePicker.MinimumDateTime;
        }


        private void label_customer_details_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Details_Load(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * FROM Payment_Details";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView_PaymentDetails.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Add data to the database
            int Payment_ID = int.Parse(txt_payment_id.Text);
            int Product_ID = int.Parse(txt_product_id.Text);
            int Customer_ID = int.Parse(txt_customer_id.Text);
            int Supplier_ID = int.Parse(txt_supplier_id.Text);

            string Product_Name = txt_product_name.Text;
            string Payment_Method = txt_payment_method.Text;
            string Price = txt_price.Text;
            DateTime Payment_Date = dtp_payment_date.Value;



            string format = "INSERT INTO Payment_Details (Payment_ID, Product_ID, Customer_ID, Supplier_ID, Product_Name, Payment_Method, Price, Payment_Date) VALUES (@Payment_ID, @Product_ID, @Customer_ID, @Supplier_ID, @Product_Name, @Payment_Method, @Price, @Payment_Date)";


            try
            {
                con.Open();

                SqlCommand insertcommand = new SqlCommand(format, con);

                insertcommand.Parameters.AddWithValue("@Payment_ID", Payment_ID);
                insertcommand.Parameters.AddWithValue("@Product_ID", Product_ID);
                insertcommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                insertcommand.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                insertcommand.Parameters.AddWithValue("@Product_Name", Product_Name);
                insertcommand.Parameters.AddWithValue("@Payment_Method", Payment_Method);
                insertcommand.Parameters.AddWithValue("@Price", Price);
                insertcommand.Parameters.AddWithValue("@Payment_Date", Payment_Date);

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
            string Payment_ID = txt_payment_id.Text;
            string Product_ID = txt_product_id.Text;
            string Customer_ID = txt_customer_id.Text;
            string Supplier_ID = txt_supplier_id.Text;
            string Product_Name = txt_product_name.Text;
            string Payment_Method = txt_payment_method.Text;
            string Price = txt_price.Text;
            DateTime Payment_Date = dtp_payment_date.Value;

            string format = "UPDATE Payment_Details SET Payment_ID=@Payment_ID, Product_ID=@Product_ID, Customer_ID=@Customer_ID, Supplier_ID=@Supplier_ID, " +
                "Product_Name=@Product_Name, Payment_Method=@Payment_Method, Price=@Price, Payment_Date=@Payment_Date WHERE Payment_ID=@Payment_ID ;";


            try
            {
                con.Open();

                SqlCommand updatecommand = new SqlCommand(format, con);

                updatecommand.Parameters.AddWithValue("@Payment_ID", Payment_ID);
                updatecommand.Parameters.AddWithValue("@Product_ID", Product_ID);
                updatecommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                updatecommand.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);
                updatecommand.Parameters.AddWithValue("@Product_Name", Product_Name);
                updatecommand.Parameters.AddWithValue("@Payment_Method", Payment_Method);
                updatecommand.Parameters.AddWithValue("@Price", Price);
                updatecommand.Parameters.AddWithValue("@Payment_Date", Payment_Date);

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
            int Payment_ID = int.Parse(txt_payment_id.Text);

            string format = "DELETE FROM Payment_Details WHERE Payment_ID=@Payment_ID;";

            try
            {
                con.Open();

                SqlCommand deletecommand = new SqlCommand(format, con);

                deletecommand.Parameters.AddWithValue("@Payment_ID", Payment_ID);

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
            int Payment_ID = int.Parse(txt_payment_id.Text);

            string format = "SELECT * FROM Payment_Details WHERE Payment_ID  = @Payment_ID ";

            try
            {
                con.Open();
                SqlCommand searchcommand = new SqlCommand(format, con);
                searchcommand.Parameters.AddWithValue("@Payment_ID ", Payment_ID);
                SqlDataReader reader = searchcommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_payment_id.Text = reader[0].ToString();
                        txt_product_id.Text = reader[1].ToString();
                        txt_customer_id.Text = reader[2].ToString();
                        txt_supplier_id.Text = reader[3].ToString();
                        txt_product_name.Text = reader[4].ToString();
                        txt_payment_method.Text = reader[5].ToString();
                        txt_price.Text = reader[6].ToString();
                        dtp_payment_date.Text = reader[7].ToString();
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

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            // Clear textboxes 
            clearAll();
        }

        private void payment_id_Click(object sender, EventArgs e)
        {

        }

        private void product_id_Click(object sender, EventArgs e)
        {

        }

        private void customer_id_Click(object sender, EventArgs e)
        {

        }

        private void supplier_id_Click(object sender, EventArgs e)
        {

        }

        private void product_name_Click(object sender, EventArgs e)
        {

        }

        private void payment_method_Click(object sender, EventArgs e)
        {

        }

        private void payment_date_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private PrintDocument printDocument = new PrintDocument();

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Display print dialog and print DataGridView
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        // Event handler for printing DataGridView
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(dataGridView_PaymentDetails.Width, dataGridView_PaymentDetails.Height);
            dataGridView_PaymentDetails.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView_PaymentDetails.Width, dataGridView_PaymentDetails.Height));
            e.Graphics.DrawImage(bitmap, 50, 50);
        }



    }
}
