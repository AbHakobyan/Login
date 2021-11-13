namespace Login
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.buttonCategoryProductBord = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCategoryUpdate = new System.Windows.Forms.Button();
            this.buttonCategoryDelete = new System.Windows.Forms.Button();
            this.buttonCategoryAdd = new System.Windows.Forms.Button();
            this.buttonProductLogout = new System.Windows.Forms.Button();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCategoryID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCategory
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewCategory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 24;
            this.dataGridViewCategory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategory.Size = new System.Drawing.Size(757, 391);
            this.dataGridViewCategory.TabIndex = 0;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellContentClick);
            this.dataGridViewCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellContentClick);
            // 
            // buttonCategoryProductBord
            // 
            this.buttonCategoryProductBord.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCategoryProductBord.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCategoryProductBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategoryProductBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCategoryProductBord.ForeColor = System.Drawing.Color.Orange;
            this.buttonCategoryProductBord.Location = new System.Drawing.Point(3, 41);
            this.buttonCategoryProductBord.Name = "buttonCategoryProductBord";
            this.buttonCategoryProductBord.Size = new System.Drawing.Size(138, 42);
            this.buttonCategoryProductBord.TabIndex = 13;
            this.buttonCategoryProductBord.Text = "Product";
            this.buttonCategoryProductBord.UseVisualStyleBackColor = false;
            this.buttonCategoryProductBord.Click += new System.EventHandler(this.buttonCategoryProductBord_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewCategory);
            this.panel3.Location = new System.Drawing.Point(364, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 383);
            this.panel3.TabIndex = 16;
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
            this.label7.Text = "Manage Category";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCategoryUpdate
            // 
            this.buttonCategoryUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCategoryUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCategoryUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCategoryUpdate.Location = new System.Drawing.Point(114, 284);
            this.buttonCategoryUpdate.Name = "buttonCategoryUpdate";
            this.buttonCategoryUpdate.Size = new System.Drawing.Size(121, 47);
            this.buttonCategoryUpdate.TabIndex = 12;
            this.buttonCategoryUpdate.Text = "Update";
            this.buttonCategoryUpdate.UseVisualStyleBackColor = false;
            this.buttonCategoryUpdate.Click += new System.EventHandler(this.buttonCategoryUpdate_Click);
            // 
            // buttonCategoryDelete
            // 
            this.buttonCategoryDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCategoryDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCategoryDelete.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCategoryDelete.Location = new System.Drawing.Point(241, 284);
            this.buttonCategoryDelete.Name = "buttonCategoryDelete";
            this.buttonCategoryDelete.Size = new System.Drawing.Size(117, 47);
            this.buttonCategoryDelete.TabIndex = 11;
            this.buttonCategoryDelete.Text = "Delete";
            this.buttonCategoryDelete.UseVisualStyleBackColor = false;
            this.buttonCategoryDelete.Click += new System.EventHandler(this.buttonCategoryDelete_Click);
            // 
            // buttonCategoryAdd
            // 
            this.buttonCategoryAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCategoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCategoryAdd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCategoryAdd.Location = new System.Drawing.Point(7, 284);
            this.buttonCategoryAdd.Name = "buttonCategoryAdd";
            this.buttonCategoryAdd.Size = new System.Drawing.Size(101, 47);
            this.buttonCategoryAdd.TabIndex = 10;
            this.buttonCategoryAdd.Text = "Add";
            this.buttonCategoryAdd.UseVisualStyleBackColor = false;
            this.buttonCategoryAdd.Click += new System.EventHandler(this.buttonCategoryAdd_Click);
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
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategoryName.Location = new System.Drawing.Point(163, 157);
            this.textBoxCategoryName.Multiline = true;
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(195, 35);
            this.textBoxCategoryName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(164, 214);
            this.textBoxCategoryDescription.Multiline = true;
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(195, 35);
            this.textBoxCategoryDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxCategoryID
            // 
            this.TextBoxCategoryID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextBoxCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCategoryID.Location = new System.Drawing.Point(164, 107);
            this.TextBoxCategoryID.Multiline = true;
            this.TextBoxCategoryID.Name = "TextBoxCategoryID";
            this.TextBoxCategoryID.Size = new System.Drawing.Size(195, 35);
            this.TextBoxCategoryID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buttonCategoryUpdate);
            this.panel2.Controls.Add(this.buttonCategoryDelete);
            this.panel2.Controls.Add(this.buttonCategoryAdd);
            this.panel2.Controls.Add(this.textBoxCategoryName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxCategoryDescription);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TextBoxCategoryID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(167, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 504);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1244, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.buttonProductLogout);
            this.panel1.Controls.Add(this.buttonCategoryProductBord);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 545);
            this.panel1.TabIndex = 7;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Button buttonCategoryProductBord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCategoryUpdate;
        private System.Windows.Forms.Button buttonCategoryDelete;
        private System.Windows.Forms.Button buttonCategoryAdd;
        private System.Windows.Forms.Button buttonProductLogout;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCategoryDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxCategoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}