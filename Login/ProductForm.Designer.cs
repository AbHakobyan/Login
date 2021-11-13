namespace Login
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProductLogout = new System.Windows.Forms.Button();
            this.buttonProductCategoryBord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.buttonProductAddbox = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonProductUpdate = new System.Windows.Forms.Button();
            this.buttonProductDelete = new System.Windows.Forms.Button();
            this.buttonProductAdd = new System.Windows.Forms.Button();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.marketDataSet = new Login.MarketDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Login.MarketDataSetTableAdapters.CategoryTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.buttonProductLogout);
            this.panel1.Controls.Add(this.buttonProductCategoryBord);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 545);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonProductLogout
            // 
            this.buttonProductLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProductLogout.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProductLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductLogout.ForeColor = System.Drawing.Color.Orange;
            this.buttonProductLogout.Location = new System.Drawing.Point(23, 489);
            this.buttonProductLogout.Name = "buttonProductLogout";
            this.buttonProductLogout.Size = new System.Drawing.Size(117, 42);
            this.buttonProductLogout.TabIndex = 14;
            this.buttonProductLogout.Text = "Logout";
            this.buttonProductLogout.UseVisualStyleBackColor = false;
            this.buttonProductLogout.Click += new System.EventHandler(this.buttonProductLogout_Click);
            this.buttonProductLogout.MouseEnter += new System.EventHandler(this.buttonProductLogout_MouseEnter);
            this.buttonProductLogout.MouseLeave += new System.EventHandler(this.buttonProductLogout_MouseLeave);
            this.buttonProductLogout.MouseHover += new System.EventHandler(this.buttonProductLogout_MouseHover);
            // 
            // buttonProductCategoryBord
            // 
            this.buttonProductCategoryBord.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProductCategoryBord.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProductCategoryBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductCategoryBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductCategoryBord.ForeColor = System.Drawing.Color.Orange;
            this.buttonProductCategoryBord.Location = new System.Drawing.Point(3, 41);
            this.buttonProductCategoryBord.Name = "buttonProductCategoryBord";
            this.buttonProductCategoryBord.Size = new System.Drawing.Size(137, 42);
            this.buttonProductCategoryBord.TabIndex = 13;
            this.buttonProductCategoryBord.Text = "Category";
            this.buttonProductCategoryBord.UseVisualStyleBackColor = false;
            this.buttonProductCategoryBord.Click += new System.EventHandler(this.buttonProductCategoryBord_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1244, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonProductAddbox);
            this.panel2.Controls.Add(this.comboBoxCategory);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buttonProductUpdate);
            this.panel2.Controls.Add(this.buttonProductDelete);
            this.panel2.Controls.Add(this.buttonProductAdd);
            this.panel2.Controls.Add(this.comboBoxProductCategory);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxProductQuantity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxProductName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxProductPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TextBoxProductID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(167, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 504);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewProduct);
            this.panel3.Location = new System.Drawing.Point(364, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 379);
            this.panel3.TabIndex = 16;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(757, 379);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            this.dataGridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // buttonProductAddbox
            // 
            this.buttonProductAddbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProductAddbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductAddbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonProductAddbox.Location = new System.Drawing.Point(364, 66);
            this.buttonProductAddbox.Name = "buttonProductAddbox";
            this.buttonProductAddbox.Size = new System.Drawing.Size(88, 35);
            this.buttonProductAddbox.TabIndex = 15;
            this.buttonProductAddbox.Text = "Refresh";
            this.buttonProductAddbox.UseVisualStyleBackColor = false;
            this.buttonProductAddbox.Click += new System.EventHandler(this.buttonProductAddbox_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.categoryBindingSource;
            this.comboBoxCategory.DisplayMember = "CategoryName";
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(520, 78);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(237, 24);
            this.comboBoxCategory.TabIndex = 14;
            this.comboBoxCategory.ValueMember = "CategoryName";
            this.comboBoxCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(158, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(496, 35);
            this.label7.TabIndex = 13;
            this.label7.Text = "Manage Product";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonProductUpdate
            // 
            this.buttonProductUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonProductUpdate.Location = new System.Drawing.Point(124, 402);
            this.buttonProductUpdate.Name = "buttonProductUpdate";
            this.buttonProductUpdate.Size = new System.Drawing.Size(115, 47);
            this.buttonProductUpdate.TabIndex = 12;
            this.buttonProductUpdate.Text = "Update";
            this.buttonProductUpdate.UseVisualStyleBackColor = false;
            this.buttonProductUpdate.Click += new System.EventHandler(this.buttonProductUpdate_Click);
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductDelete.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonProductDelete.Location = new System.Drawing.Point(245, 402);
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.Size = new System.Drawing.Size(114, 47);
            this.buttonProductDelete.TabIndex = 11;
            this.buttonProductDelete.Text = "Delete";
            this.buttonProductDelete.UseVisualStyleBackColor = false;
            this.buttonProductDelete.Click += new System.EventHandler(this.buttonProductDelete_Click);
            // 
            // buttonProductAdd
            // 
            this.buttonProductAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductAdd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonProductAdd.Location = new System.Drawing.Point(17, 402);
            this.buttonProductAdd.Name = "buttonProductAdd";
            this.buttonProductAdd.Size = new System.Drawing.Size(101, 47);
            this.buttonProductAdd.TabIndex = 10;
            this.buttonProductAdd.Text = "Add";
            this.buttonProductAdd.UseVisualStyleBackColor = false;
            this.buttonProductAdd.Click += new System.EventHandler(this.buttonProductAdd_Click);
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.Location = new System.Drawing.Point(164, 340);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(195, 24);
            this.comboBoxProductCategory.TabIndex = 9;
            this.comboBoxProductCategory.Text = "Select Category";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(40, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "Category";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProductQuantity
            // 
            this.textBoxProductQuantity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProductQuantity.Location = new System.Drawing.Point(164, 283);
            this.textBoxProductQuantity.Multiline = true;
            this.textBoxProductQuantity.Name = "textBoxProductQuantity";
            this.textBoxProductQuantity.Size = new System.Drawing.Size(195, 35);
            this.textBoxProductQuantity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProductName.Location = new System.Drawing.Point(163, 169);
            this.textBoxProductName.Multiline = true;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(195, 35);
            this.textBoxProductName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProductPrice.Location = new System.Drawing.Point(164, 226);
            this.textBoxProductPrice.Multiline = true;
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(195, 35);
            this.textBoxProductPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxProductID
            // 
            this.TextBoxProductID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextBoxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxProductID.Location = new System.Drawing.Point(164, 119);
            this.TextBoxProductID.Multiline = true;
            this.TextBoxProductID.Name = "TextBoxProductID";
            this.TextBoxProductID.Size = new System.Drawing.Size(195, 35);
            this.TextBoxProductID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // marketDataSet
            // 
            this.marketDataSet.DataSetName = "MarketDataSet";
            this.marketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.marketDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxProductCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProductQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonProductUpdate;
        private System.Windows.Forms.Button buttonProductDelete;
        private System.Windows.Forms.Button buttonProductAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonProductAddbox;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonProductLogout;
        private System.Windows.Forms.Button buttonProductCategoryBord;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private MarketDataSet marketDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private MarketDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}