namespace Stock_Management_and_Billing_System
{
    partial class Supplier_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Details));
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contact_number = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.contact_number = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_stock_price = new System.Windows.Forms.TextBox();
            this.txt_supplier_id = new System.Windows.Forms.TextBox();
            this.txt_supplier_name = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.stock_price = new System.Windows.Forms.Label();
            this.supplier_id = new System.Windows.Forms.Label();
            this.supplier_name = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.Label();
            this.dataGridView_SupplierDetails = new System.Windows.Forms.DataGridView();
            this.label_supplier_details = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupplierDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(106, 1128);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(501, 44);
            this.txt_email.TabIndex = 98;
            // 
            // txt_contact_number
            // 
            this.txt_contact_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact_number.Location = new System.Drawing.Point(106, 996);
            this.txt_contact_number.Margin = new System.Windows.Forms.Padding(6);
            this.txt_contact_number.Name = "txt_contact_number";
            this.txt_contact_number.Size = new System.Drawing.Size(501, 44);
            this.txt_contact_number.TabIndex = 97;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.DarkGray;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(39, 1080);
            this.email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(115, 42);
            this.email.TabIndex = 95;
            this.email.Text = "Email";
            // 
            // contact_number
            // 
            this.contact_number.AutoSize = true;
            this.contact_number.BackColor = System.Drawing.Color.DarkGray;
            this.contact_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_number.Location = new System.Drawing.Point(39, 948);
            this.contact_number.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contact_number.Name = "contact_number";
            this.contact_number.Size = new System.Drawing.Size(303, 42);
            this.contact_number.TabIndex = 94;
            this.contact_number.Text = "Contact Number";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(675, 1271);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(210, 87);
            this.btn_search.TabIndex = 93;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(448, 1271);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(215, 87);
            this.btn_delete.TabIndex = 92;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(221, 1271);
            this.btn_update.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(215, 87);
            this.btn_update.TabIndex = 91;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(15, 1271);
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
            this.btn_home.Location = new System.Drawing.Point(1202, 1271);
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
            this.btn_clear.Location = new System.Drawing.Point(897, 1271);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(194, 87);
            this.btn_clear.TabIndex = 88;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1408, 1271);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(194, 87);
            this.btn_exit.TabIndex = 86;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_stock_price
            // 
            this.txt_stock_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_price.Location = new System.Drawing.Point(106, 863);
            this.txt_stock_price.Margin = new System.Windows.Forms.Padding(6);
            this.txt_stock_price.Name = "txt_stock_price";
            this.txt_stock_price.Size = new System.Drawing.Size(501, 44);
            this.txt_stock_price.TabIndex = 85;
            // 
            // txt_supplier_id
            // 
            this.txt_supplier_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier_id.Location = new System.Drawing.Point(106, 336);
            this.txt_supplier_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_supplier_id.Name = "txt_supplier_id";
            this.txt_supplier_id.Size = new System.Drawing.Size(501, 44);
            this.txt_supplier_id.TabIndex = 84;
            // 
            // txt_supplier_name
            // 
            this.txt_supplier_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier_name.Location = new System.Drawing.Point(106, 601);
            this.txt_supplier_name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_supplier_name.Name = "txt_supplier_name";
            this.txt_supplier_name.Size = new System.Drawing.Size(501, 44);
            this.txt_supplier_name.TabIndex = 83;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_id.Location = new System.Drawing.Point(106, 466);
            this.txt_product_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.Size = new System.Drawing.Size(501, 44);
            this.txt_product_id.TabIndex = 82;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(106, 732);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(501, 44);
            this.txt_product_name.TabIndex = 81;
            // 
            // stock_price
            // 
            this.stock_price.AutoSize = true;
            this.stock_price.BackColor = System.Drawing.Color.DarkGray;
            this.stock_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_price.Location = new System.Drawing.Point(39, 815);
            this.stock_price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.stock_price.Name = "stock_price";
            this.stock_price.Size = new System.Drawing.Size(218, 42);
            this.stock_price.TabIndex = 80;
            this.stock_price.Text = "Stock Price";
            // 
            // supplier_id
            // 
            this.supplier_id.AutoSize = true;
            this.supplier_id.BackColor = System.Drawing.Color.DarkGray;
            this.supplier_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_id.Location = new System.Drawing.Point(39, 288);
            this.supplier_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.Size = new System.Drawing.Size(212, 42);
            this.supplier_id.TabIndex = 79;
            this.supplier_id.Text = "Supplier ID";
            // 
            // supplier_name
            // 
            this.supplier_name.AutoSize = true;
            this.supplier_name.BackColor = System.Drawing.Color.DarkGray;
            this.supplier_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_name.Location = new System.Drawing.Point(39, 553);
            this.supplier_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Size = new System.Drawing.Size(277, 42);
            this.supplier_name.TabIndex = 78;
            this.supplier_name.Text = "Supplier Name";
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.BackColor = System.Drawing.Color.DarkGray;
            this.product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id.Location = new System.Drawing.Point(39, 418);
            this.product_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(203, 42);
            this.product_id.TabIndex = 77;
            this.product_id.Text = "Product ID";
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.BackColor = System.Drawing.Color.DarkGray;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(39, 684);
            this.product_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(278, 42);
            this.product_name.TabIndex = 76;
            this.product_name.Text = "Product_Name";
            // 
            // dataGridView_SupplierDetails
            // 
            this.dataGridView_SupplierDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SupplierDetails.Location = new System.Drawing.Point(672, 246);
            this.dataGridView_SupplierDetails.Name = "dataGridView_SupplierDetails";
            this.dataGridView_SupplierDetails.RowHeadersWidth = 82;
            this.dataGridView_SupplierDetails.RowTemplate.Height = 33;
            this.dataGridView_SupplierDetails.Size = new System.Drawing.Size(913, 995);
            this.dataGridView_SupplierDetails.TabIndex = 99;
            // 
            // label_supplier_details
            // 
            this.label_supplier_details.AutoSize = true;
            this.label_supplier_details.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supplier_details.Location = new System.Drawing.Point(1053, 58);
            this.label_supplier_details.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_supplier_details.Name = "label_supplier_details";
            this.label_supplier_details.Size = new System.Drawing.Size(532, 114);
            this.label_supplier_details.TabIndex = 100;
            this.label_supplier_details.Text = "Supplier Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(469, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 103;
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
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(15, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 961);
            this.panel1.TabIndex = 104;
            // 
            // Supplier_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1623, 1373);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_supplier_details);
            this.Controls.Add(this.dataGridView_SupplierDetails);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contact_number);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contact_number);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_stock_price);
            this.Controls.Add(this.txt_supplier_id);
            this.Controls.Add(this.txt_supplier_name);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.stock_price);
            this.Controls.Add(this.supplier_id);
            this.Controls.Add(this.supplier_name);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Supplier_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier_Details";
            this.Load += new System.EventHandler(this.Supplier_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupplierDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contact_number;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contact_number;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_stock_price;
        private System.Windows.Forms.TextBox txt_supplier_id;
        private System.Windows.Forms.TextBox txt_supplier_name;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label stock_price;
        private System.Windows.Forms.Label supplier_id;
        private System.Windows.Forms.Label supplier_name;
        private System.Windows.Forms.Label product_id;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.DataGridView dataGridView_SupplierDetails;
        private System.Windows.Forms.Label label_supplier_details;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}