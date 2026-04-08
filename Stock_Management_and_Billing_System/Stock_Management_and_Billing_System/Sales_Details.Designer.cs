namespace Stock_Management_and_Billing_System
{
    partial class Sales_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Details));
            this.txt_quantity_available = new System.Windows.Forms.TextBox();
            this.txt_quantity_sold = new System.Windows.Forms.TextBox();
            this.sales_date = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity_sold = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_supplier_id = new System.Windows.Forms.TextBox();
            this.txt_customer_id = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.txt_sales_id = new System.Windows.Forms.TextBox();
            this.product_name = new System.Windows.Forms.Label();
            this.supplier_id = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.Label();
            this.sales_id = new System.Windows.Forms.Label();
            this.dataGridView_SalesDetails = new System.Windows.Forms.DataGridView();
            this.dtp_sales_date = new System.Windows.Forms.DateTimePicker();
            this.label_sales_details = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_quantity_available
            // 
            this.txt_quantity_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity_available.Location = new System.Drawing.Point(139, 1070);
            this.txt_quantity_available.Margin = new System.Windows.Forms.Padding(6);
            this.txt_quantity_available.Name = "txt_quantity_available";
            this.txt_quantity_available.Size = new System.Drawing.Size(501, 44);
            this.txt_quantity_available.TabIndex = 98;
            // 
            // txt_quantity_sold
            // 
            this.txt_quantity_sold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity_sold.Location = new System.Drawing.Point(139, 938);
            this.txt_quantity_sold.Margin = new System.Windows.Forms.Padding(6);
            this.txt_quantity_sold.Name = "txt_quantity_sold";
            this.txt_quantity_sold.Size = new System.Drawing.Size(501, 44);
            this.txt_quantity_sold.TabIndex = 97;
            // 
            // sales_date
            // 
            this.sales_date.AutoSize = true;
            this.sales_date.BackColor = System.Drawing.Color.DarkGray;
            this.sales_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_date.Location = new System.Drawing.Point(72, 1146);
            this.sales_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sales_date.Name = "sales_date";
            this.sales_date.Size = new System.Drawing.Size(211, 42);
            this.sales_date.TabIndex = 96;
            this.sales_date.Text = "Sales Date";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.DarkGray;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(72, 1022);
            this.price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(337, 42);
            this.price.TabIndex = 95;
            this.price.Text = "Quantity Available";
            // 
            // quantity_sold
            // 
            this.quantity_sold.AutoSize = true;
            this.quantity_sold.BackColor = System.Drawing.Color.DarkGray;
            this.quantity_sold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_sold.Location = new System.Drawing.Point(72, 890);
            this.quantity_sold.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.quantity_sold.Name = "quantity_sold";
            this.quantity_sold.Size = new System.Drawing.Size(255, 42);
            this.quantity_sold.TabIndex = 94;
            this.quantity_sold.Text = "Quantity Sold";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(442, 1325);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(221, 87);
            this.btn_search.TabIndex = 93;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(219, 1325);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(211, 87);
            this.btn_delete.TabIndex = 92;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(15, 1325);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(194, 87);
            this.btn_add.TabIndex = 90;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(1202, 1325);
            this.btn_home.Margin = new System.Windows.Forms.Padding(6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(194, 87);
            this.btn_home.TabIndex = 89;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(675, 1325);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(194, 87);
            this.btn_clear.TabIndex = 88;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1408, 1325);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(194, 87);
            this.btn_exit.TabIndex = 86;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(139, 805);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(501, 44);
            this.txt_product_name.TabIndex = 85;
            // 
            // txt_supplier_id
            // 
            this.txt_supplier_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier_id.Location = new System.Drawing.Point(139, 533);
            this.txt_supplier_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_supplier_id.Name = "txt_supplier_id";
            this.txt_supplier_id.Size = new System.Drawing.Size(501, 44);
            this.txt_supplier_id.TabIndex = 84;
            // 
            // txt_customer_id
            // 
            this.txt_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_id.Location = new System.Drawing.Point(139, 669);
            this.txt_customer_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_customer_id.Name = "txt_customer_id";
            this.txt_customer_id.Size = new System.Drawing.Size(501, 44);
            this.txt_customer_id.TabIndex = 83;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_id.Location = new System.Drawing.Point(139, 408);
            this.txt_product_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.Size = new System.Drawing.Size(501, 44);
            this.txt_product_id.TabIndex = 82;
            // 
            // txt_sales_id
            // 
            this.txt_sales_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sales_id.Location = new System.Drawing.Point(139, 283);
            this.txt_sales_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_sales_id.Name = "txt_sales_id";
            this.txt_sales_id.Size = new System.Drawing.Size(501, 44);
            this.txt_sales_id.TabIndex = 81;
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.BackColor = System.Drawing.Color.DarkGray;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(72, 757);
            this.product_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(268, 42);
            this.product_name.TabIndex = 80;
            this.product_name.Text = "Product Name";
            // 
            // supplier_id
            // 
            this.supplier_id.AutoSize = true;
            this.supplier_id.BackColor = System.Drawing.Color.DarkGray;
            this.supplier_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_id.Location = new System.Drawing.Point(72, 485);
            this.supplier_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(212, 42);
            this.supplier_id.TabIndex = 79;
            this.supplier_id.Text = "Supplier ID";
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.BackColor = System.Drawing.Color.DarkGray;
            this.customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id.Location = new System.Drawing.Point(72, 621);
            this.customer_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(236, 42);
            this.customer_id.TabIndex = 78;
            this.customer_id.Text = "Customer ID";
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.BackColor = System.Drawing.Color.DarkGray;
            this.product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id.Location = new System.Drawing.Point(72, 360);
            this.product_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(203, 42);
            this.product_id.TabIndex = 77;
            this.product_id.Text = "Product ID";
            // 
            // sales_id
            // 
            this.sales_id.AutoSize = true;
            this.sales_id.BackColor = System.Drawing.Color.DarkGray;
            this.sales_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_id.Location = new System.Drawing.Point(72, 235);
            this.sales_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sales_id.Name = "sales_id";
            this.sales_id.Size = new System.Drawing.Size(166, 42);
            this.sales_id.TabIndex = 76;
            this.sales_id.Text = "Sales ID";
            // 
            // dataGridView_SalesDetails
            // 
            this.dataGridView_SalesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SalesDetails.Location = new System.Drawing.Point(698, 216);
            this.dataGridView_SalesDetails.Name = "dataGridView_SalesDetails";
            this.dataGridView_SalesDetails.RowHeadersWidth = 82;
            this.dataGridView_SalesDetails.RowTemplate.Height = 33;
            this.dataGridView_SalesDetails.Size = new System.Drawing.Size(896, 1073);
            this.dataGridView_SalesDetails.TabIndex = 100;
            // 
            // dtp_sales_date
            // 
            this.dtp_sales_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_sales_date.Location = new System.Drawing.Point(139, 1214);
            this.dtp_sales_date.Name = "dtp_sales_date";
            this.dtp_sales_date.Size = new System.Drawing.Size(501, 44);
            this.dtp_sales_date.TabIndex = 101;
            // 
            // label_sales_details
            // 
            this.label_sales_details.AutoSize = true;
            this.label_sales_details.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sales_details.Location = new System.Drawing.Point(1160, 46);
            this.label_sales_details.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_sales_details.Name = "label_sales_details";
            this.label_sales_details.Size = new System.Drawing.Size(434, 114);
            this.label_sales_details.TabIndex = 102;
            this.label_sales_details.Text = "Sales Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(469, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 104;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(48, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 1072);
            this.panel1.TabIndex = 105;
            // 
            // Sales_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1622, 1427);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_sales_details);
            this.Controls.Add(this.dtp_sales_date);
            this.Controls.Add(this.dataGridView_SalesDetails);
            this.Controls.Add(this.txt_quantity_available);
            this.Controls.Add(this.txt_quantity_sold);
            this.Controls.Add(this.sales_date);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity_sold);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.txt_supplier_id);
            this.Controls.Add(this.txt_customer_id);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.txt_sales_id);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.supplier_id);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.sales_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Sales_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Details";
            this.Load += new System.EventHandler(this.Sales_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_quantity_available;
        private System.Windows.Forms.TextBox txt_quantity_sold;
        private System.Windows.Forms.Label sales_date;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity_sold;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_supplier_id;
        private System.Windows.Forms.TextBox txt_customer_id;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.TextBox txt_sales_id;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Label supplier_id;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.Label product_id;
        private System.Windows.Forms.Label sales_id;
        private System.Windows.Forms.DataGridView dataGridView_SalesDetails;
        private System.Windows.Forms.DateTimePicker dtp_sales_date;
        private System.Windows.Forms.Label label_sales_details;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}