namespace Stock_Management_and_Billing_System
{
    partial class Payment_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Details));
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_supplier_id = new System.Windows.Forms.TextBox();
            this.txt_customer_id = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.txt_payment_id = new System.Windows.Forms.TextBox();
            this.product_name = new System.Windows.Forms.Label();
            this.supplier_id = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.Label();
            this.payment_id = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_payment_method = new System.Windows.Forms.TextBox();
            this.payment_date = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.payment_method = new System.Windows.Forms.Label();
            this.dataGridView_PaymentDetails = new System.Windows.Forms.DataGridView();
            this.dtp_payment_date = new System.Windows.Forms.DateTimePicker();
            this.label_payment_details = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PaymentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(669, 1316);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(213, 87);
            this.btn_search.TabIndex = 68;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(444, 1316);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(213, 87);
            this.btn_delete.TabIndex = 67;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(221, 1316);
            this.btn_update.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(211, 87);
            this.btn_update.TabIndex = 66;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(15, 1316);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(194, 87);
            this.btn_add.TabIndex = 65;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(1334, 1316);
            this.btn_home.Margin = new System.Windows.Forms.Padding(6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(194, 87);
            this.btn_home.TabIndex = 64;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(894, 1316);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(194, 87);
            this.btn_clear.TabIndex = 63;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1540, 1313);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(194, 87);
            this.btn_exit.TabIndex = 61;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(120, 796);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(501, 44);
            this.txt_product_name.TabIndex = 60;
            // 
            // txt_supplier_id
            // 
            this.txt_supplier_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier_id.Location = new System.Drawing.Point(120, 666);
            this.txt_supplier_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_supplier_id.Name = "txt_supplier_id";
            this.txt_supplier_id.Size = new System.Drawing.Size(501, 44);
            this.txt_supplier_id.TabIndex = 59;
            // 
            // txt_customer_id
            // 
            this.txt_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_id.Location = new System.Drawing.Point(120, 534);
            this.txt_customer_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_customer_id.Name = "txt_customer_id";
            this.txt_customer_id.Size = new System.Drawing.Size(501, 44);
            this.txt_customer_id.TabIndex = 58;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_id.Location = new System.Drawing.Point(120, 399);
            this.txt_product_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.Size = new System.Drawing.Size(501, 44);
            this.txt_product_id.TabIndex = 57;
            // 
            // txt_payment_id
            // 
            this.txt_payment_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment_id.Location = new System.Drawing.Point(120, 274);
            this.txt_payment_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_payment_id.Name = "txt_payment_id";
            this.txt_payment_id.Size = new System.Drawing.Size(501, 44);
            this.txt_payment_id.TabIndex = 56;
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.BackColor = System.Drawing.Color.DarkGray;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(53, 748);
            this.product_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(268, 42);
            this.product_name.TabIndex = 55;
            this.product_name.Text = "Product Name";
            this.product_name.Click += new System.EventHandler(this.product_name_Click);
            // 
            // supplier_id
            // 
            this.supplier_id.AutoSize = true;
            this.supplier_id.BackColor = System.Drawing.Color.DarkGray;
            this.supplier_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_id.Location = new System.Drawing.Point(53, 618);
            this.supplier_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(212, 42);
            this.supplier_id.TabIndex = 54;
            this.supplier_id.Text = "Supplier ID";
            this.supplier_id.Click += new System.EventHandler(this.supplier_id_Click);
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.BackColor = System.Drawing.Color.DarkGray;
            this.customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id.Location = new System.Drawing.Point(53, 486);
            this.customer_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(236, 42);
            this.customer_id.TabIndex = 53;
            this.customer_id.Text = "Customer ID";
            this.customer_id.Click += new System.EventHandler(this.customer_id_Click);
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.BackColor = System.Drawing.Color.DarkGray;
            this.product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id.Location = new System.Drawing.Point(53, 351);
            this.product_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(203, 42);
            this.product_id.TabIndex = 52;
            this.product_id.Text = "Product ID";
            this.product_id.Click += new System.EventHandler(this.product_id_Click);
            // 
            // payment_id
            // 
            this.payment_id.AutoSize = true;
            this.payment_id.BackColor = System.Drawing.Color.DarkGray;
            this.payment_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_id.Location = new System.Drawing.Point(53, 226);
            this.payment_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.payment_id.Name = "payment_id";
            this.payment_id.Size = new System.Drawing.Size(221, 42);
            this.payment_id.TabIndex = 51;
            this.payment_id.Text = "Payment ID";
            this.payment_id.Click += new System.EventHandler(this.payment_id_Click);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(120, 1061);
            this.txt_price.Margin = new System.Windows.Forms.Padding(6);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(501, 44);
            this.txt_price.TabIndex = 73;
            // 
            // txt_payment_method
            // 
            this.txt_payment_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment_method.Location = new System.Drawing.Point(120, 929);
            this.txt_payment_method.Margin = new System.Windows.Forms.Padding(6);
            this.txt_payment_method.Name = "txt_payment_method";
            this.txt_payment_method.Size = new System.Drawing.Size(501, 44);
            this.txt_payment_method.TabIndex = 72;
            // 
            // payment_date
            // 
            this.payment_date.AutoSize = true;
            this.payment_date.BackColor = System.Drawing.Color.DarkGray;
            this.payment_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_date.Location = new System.Drawing.Point(53, 1137);
            this.payment_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.payment_date.Name = "payment_date";
            this.payment_date.Size = new System.Drawing.Size(266, 42);
            this.payment_date.TabIndex = 71;
            this.payment_date.Text = "Payment Date";
            this.payment_date.Click += new System.EventHandler(this.payment_date_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.DarkGray;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(53, 1013);
            this.price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(108, 42);
            this.price.TabIndex = 70;
            this.price.Text = "Price";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // payment_method
            // 
            this.payment_method.AutoSize = true;
            this.payment_method.BackColor = System.Drawing.Color.DarkGray;
            this.payment_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_method.Location = new System.Drawing.Point(53, 881);
            this.payment_method.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.payment_method.Name = "payment_method";
            this.payment_method.Size = new System.Drawing.Size(314, 42);
            this.payment_method.TabIndex = 69;
            this.payment_method.Text = "Payment Method";
            this.payment_method.Click += new System.EventHandler(this.payment_method_Click);
            // 
            // dataGridView_PaymentDetails
            // 
            this.dataGridView_PaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PaymentDetails.Location = new System.Drawing.Point(684, 227);
            this.dataGridView_PaymentDetails.Name = "dataGridView_PaymentDetails";
            this.dataGridView_PaymentDetails.RowHeadersWidth = 82;
            this.dataGridView_PaymentDetails.RowTemplate.Height = 33;
            this.dataGridView_PaymentDetails.Size = new System.Drawing.Size(1028, 1046);
            this.dataGridView_PaymentDetails.TabIndex = 75;
            // 
            // dtp_payment_date
            // 
            this.dtp_payment_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_payment_date.Location = new System.Drawing.Point(120, 1197);
            this.dtp_payment_date.Name = "dtp_payment_date";
            this.dtp_payment_date.Size = new System.Drawing.Size(501, 44);
            this.dtp_payment_date.TabIndex = 99;
            // 
            // label_payment_details
            // 
            this.label_payment_details.AutoSize = true;
            this.label_payment_details.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment_details.Location = new System.Drawing.Point(1153, 50);
            this.label_payment_details.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_payment_details.Name = "label_payment_details";
            this.label_payment_details.Size = new System.Drawing.Size(559, 114);
            this.label_payment_details.TabIndex = 100;
            this.label_payment_details.Text = "Payment Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(197, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(469, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(34, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 1068);
            this.panel1.TabIndex = 103;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(1100, 1316);
            this.btn_print.Margin = new System.Windows.Forms.Padding(6);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(194, 87);
            this.btn_print.TabIndex = 104;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Payment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1749, 1415);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_payment_details);
            this.Controls.Add(this.dtp_payment_date);
            this.Controls.Add(this.dataGridView_PaymentDetails);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_payment_method);
            this.Controls.Add(this.payment_date);
            this.Controls.Add(this.price);
            this.Controls.Add(this.payment_method);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.txt_supplier_id);
            this.Controls.Add(this.txt_customer_id);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.txt_payment_id);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.supplier_id);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.payment_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Payment_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_Details";
            this.Load += new System.EventHandler(this.Payment_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PaymentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_supplier_id;
        private System.Windows.Forms.TextBox txt_customer_id;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.TextBox txt_payment_id;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Label supplier_id;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.Label product_id;
        private System.Windows.Forms.Label payment_id;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_payment_method;
        private System.Windows.Forms.Label payment_date;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label payment_method;
        private System.Windows.Forms.DataGridView dataGridView_PaymentDetails;
        private System.Windows.Forms.DateTimePicker dtp_payment_date;
        private System.Windows.Forms.Label label_payment_details;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_print;
    }
}