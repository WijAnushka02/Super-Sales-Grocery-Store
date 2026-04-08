namespace Stock_Management_and_Billing_System
{
    partial class Product_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Details));
            this.txt_stock_quantity = new System.Windows.Forms.TextBox();
            this.stock_quantity = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_unit_price = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.unit_price = new System.Windows.Forms.Label();
            this.expire_date = new System.Windows.Forms.Label();
            this.manufacture_date = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.Label();
            this.dtp_manufacture_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_expire_date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_ProductDetails = new System.Windows.Forms.DataGridView();
            this.label_product_details = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stock_quantity
            // 
            this.txt_stock_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_quantity.Location = new System.Drawing.Point(133, 967);
            this.txt_stock_quantity.Margin = new System.Windows.Forms.Padding(6);
            this.txt_stock_quantity.Name = "txt_stock_quantity";
            this.txt_stock_quantity.Size = new System.Drawing.Size(501, 44);
            this.txt_stock_quantity.TabIndex = 97;
            // 
            // stock_quantity
            // 
            this.stock_quantity.AutoSize = true;
            this.stock_quantity.BackColor = System.Drawing.Color.DarkGray;
            this.stock_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_quantity.Location = new System.Drawing.Point(66, 919);
            this.stock_quantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.Size = new System.Drawing.Size(275, 42);
            this.stock_quantity.TabIndex = 94;
            this.stock_quantity.Text = "Stock Quantity";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(674, 1104);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(208, 87);
            this.btn_search.TabIndex = 93;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(449, 1104);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(213, 87);
            this.btn_delete.TabIndex = 92;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(221, 1104);
            this.btn_update.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(216, 87);
            this.btn_update.TabIndex = 91;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(15, 1104);
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
            this.btn_home.Location = new System.Drawing.Point(1213, 1104);
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
            this.btn_clear.Location = new System.Drawing.Point(894, 1104);
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
            this.btn_exit.Location = new System.Drawing.Point(1419, 1104);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(194, 87);
            this.btn_exit.TabIndex = 86;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // txt_unit_price
            // 
            this.txt_unit_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_price.Location = new System.Drawing.Point(133, 834);
            this.txt_unit_price.Margin = new System.Windows.Forms.Padding(6);
            this.txt_unit_price.Name = "txt_unit_price";
            this.txt_unit_price.Size = new System.Drawing.Size(501, 44);
            this.txt_unit_price.TabIndex = 85;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(133, 437);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(501, 44);
            this.txt_product_name.TabIndex = 82;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_id.Location = new System.Drawing.Point(133, 312);
            this.txt_product_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.Size = new System.Drawing.Size(501, 44);
            this.txt_product_id.TabIndex = 81;
            // 
            // unit_price
            // 
            this.unit_price.AutoSize = true;
            this.unit_price.BackColor = System.Drawing.Color.DarkGray;
            this.unit_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_price.Location = new System.Drawing.Point(66, 786);
            this.unit_price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.unit_price.Name = "unit_price";
            this.unit_price.Size = new System.Drawing.Size(189, 42);
            this.unit_price.TabIndex = 80;
            this.unit_price.Text = "Unit Price";
            // 
            // expire_date
            // 
            this.expire_date.AutoSize = true;
            this.expire_date.BackColor = System.Drawing.Color.DarkGray;
            this.expire_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expire_date.Location = new System.Drawing.Point(66, 656);
            this.expire_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.expire_date.Name = "expire_date";
            this.expire_date.Size = new System.Drawing.Size(224, 42);
            this.expire_date.TabIndex = 79;
            this.expire_date.Text = "Expire Date";
            // 
            // manufacture_date
            // 
            this.manufacture_date.AutoSize = true;
            this.manufacture_date.BackColor = System.Drawing.Color.DarkGray;
            this.manufacture_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacture_date.Location = new System.Drawing.Point(66, 524);
            this.manufacture_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manufacture_date.Name = "manufacture_date";
            this.manufacture_date.Size = new System.Drawing.Size(331, 42);
            this.manufacture_date.TabIndex = 78;
            this.manufacture_date.Text = "Manufacture Date";
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.BackColor = System.Drawing.Color.DarkGray;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(66, 389);
            this.product_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(268, 42);
            this.product_name.TabIndex = 77;
            this.product_name.Text = "Product Name";
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.BackColor = System.Drawing.Color.DarkGray;
            this.product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id.Location = new System.Drawing.Point(66, 264);
            this.product_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(203, 42);
            this.product_id.TabIndex = 76;
            this.product_id.Text = "Product ID";
            // 
            // dtp_manufacture_date
            // 
            this.dtp_manufacture_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_manufacture_date.Location = new System.Drawing.Point(133, 581);
            this.dtp_manufacture_date.Name = "dtp_manufacture_date";
            this.dtp_manufacture_date.Size = new System.Drawing.Size(493, 44);
            this.dtp_manufacture_date.TabIndex = 98;
            // 
            // dtp_expire_date
            // 
            this.dtp_expire_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_expire_date.Location = new System.Drawing.Point(133, 715);
            this.dtp_expire_date.Name = "dtp_expire_date";
            this.dtp_expire_date.Size = new System.Drawing.Size(493, 44);
            this.dtp_expire_date.TabIndex = 99;
            // 
            // dataGridView_ProductDetails
            // 
            this.dataGridView_ProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductDetails.Location = new System.Drawing.Point(691, 209);
            this.dataGridView_ProductDetails.Name = "dataGridView_ProductDetails";
            this.dataGridView_ProductDetails.RowHeadersWidth = 82;
            this.dataGridView_ProductDetails.RowTemplate.Height = 33;
            this.dataGridView_ProductDetails.Size = new System.Drawing.Size(911, 869);
            this.dataGridView_ProductDetails.TabIndex = 100;
            // 
            // label_product_details
            // 
            this.label_product_details.AutoSize = true;
            this.label_product_details.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product_details.Location = new System.Drawing.Point(1061, 48);
            this.label_product_details.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_product_details.Name = "label_product_details";
            this.label_product_details.Size = new System.Drawing.Size(527, 114);
            this.label_product_details.TabIndex = 101;
            this.label_product_details.Text = "Product Details";
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
            this.panel1.Location = new System.Drawing.Point(43, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 812);
            this.panel1.TabIndex = 104;
            // 
            // Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1628, 1206);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_product_details);
            this.Controls.Add(this.dataGridView_ProductDetails);
            this.Controls.Add(this.dtp_expire_date);
            this.Controls.Add(this.dtp_manufacture_date);
            this.Controls.Add(this.txt_stock_quantity);
            this.Controls.Add(this.stock_quantity);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_unit_price);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.unit_price);
            this.Controls.Add(this.expire_date);
            this.Controls.Add(this.manufacture_date);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Product_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_stock_quantity;
        private System.Windows.Forms.Label stock_quantity;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_unit_price;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.Label unit_price;
        private System.Windows.Forms.Label expire_date;
        private System.Windows.Forms.Label manufacture_date;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Label product_id;
        private System.Windows.Forms.DateTimePicker dtp_manufacture_date;
        private System.Windows.Forms.DateTimePicker dtp_expire_date;
        private System.Windows.Forms.DataGridView dataGridView_ProductDetails;
        private System.Windows.Forms.Label label_product_details;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}