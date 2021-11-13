namespace Login
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLoginSubmit = new System.Windows.Forms.Button();
            this.textLoginPassword = new System.Windows.Forms.TextBox();
            this.textLoginEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonRegistrSubmit = new System.Windows.Forms.Button();
            this.textRegistrConfirmPassword = new System.Windows.Forms.TextBox();
            this.textRegistrPassword = new System.Windows.Forms.TextBox();
            this.textRegistrEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.buttonLoginSubmit);
            this.tabPage1.Controls.Add(this.textLoginPassword);
            this.tabPage1.Controls.Add(this.textLoginEmail);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log In";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources._299105_lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(127, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources._72144_base_btn_email_icon;
            this.pictureBox1.Location = new System.Drawing.Point(127, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLoginSubmit
            // 
            this.buttonLoginSubmit.BackColor = System.Drawing.Color.Black;
            this.buttonLoginSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLoginSubmit.FlatAppearance.BorderSize = 2;
            this.buttonLoginSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLoginSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonLoginSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoginSubmit.Location = new System.Drawing.Point(330, 324);
            this.buttonLoginSubmit.Name = "buttonLoginSubmit";
            this.buttonLoginSubmit.Size = new System.Drawing.Size(141, 50);
            this.buttonLoginSubmit.TabIndex = 17;
            this.buttonLoginSubmit.Text = "Log in";
            this.buttonLoginSubmit.UseVisualStyleBackColor = false;
            this.buttonLoginSubmit.Click += new System.EventHandler(this.buttonLoginSubmit_Click);
            // 
            // textLoginPassword
            // 
            this.textLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLoginPassword.Location = new System.Drawing.Point(244, 244);
            this.textLoginPassword.MaxLength = 14;
            this.textLoginPassword.Multiline = true;
            this.textLoginPassword.Name = "textLoginPassword";
            this.textLoginPassword.PasswordChar = '*';
            this.textLoginPassword.Size = new System.Drawing.Size(415, 74);
            this.textLoginPassword.TabIndex = 16;
            // 
            // textLoginEmail
            // 
            this.textLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLoginEmail.Location = new System.Drawing.Point(244, 164);
            this.textLoginEmail.Multiline = true;
            this.textLoginEmail.Name = "textLoginEmail";
            this.textLoginEmail.Size = new System.Drawing.Size(415, 74);
            this.textLoginEmail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(127, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(532, 69);
            this.label5.TabIndex = 8;
            this.label5.Text = "Authorization";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.buttonRegistrSubmit);
            this.tabPage2.Controls.Add(this.textRegistrConfirmPassword);
            this.tabPage2.Controls.Add(this.textRegistrPassword);
            this.tabPage2.Controls.Add(this.textRegistrEmail);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign Up";
            // 
            // buttonRegistrSubmit
            // 
            this.buttonRegistrSubmit.BackColor = System.Drawing.Color.Black;
            this.buttonRegistrSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRegistrSubmit.FlatAppearance.BorderSize = 2;
            this.buttonRegistrSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRegistrSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonRegistrSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistrSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrSubmit.Location = new System.Drawing.Point(322, 326);
            this.buttonRegistrSubmit.Name = "buttonRegistrSubmit";
            this.buttonRegistrSubmit.Size = new System.Drawing.Size(141, 50);
            this.buttonRegistrSubmit.TabIndex = 18;
            this.buttonRegistrSubmit.Text = "Registration";
            this.buttonRegistrSubmit.UseVisualStyleBackColor = false;
            this.buttonRegistrSubmit.Click += new System.EventHandler(this.buttonRegistrSubmit_Click);
            // 
            // textRegistrConfirmPassword
            // 
            this.textRegistrConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRegistrConfirmPassword.Location = new System.Drawing.Point(322, 269);
            this.textRegistrConfirmPassword.MaxLength = 14;
            this.textRegistrConfirmPassword.Multiline = true;
            this.textRegistrConfirmPassword.Name = "textRegistrConfirmPassword";
            this.textRegistrConfirmPassword.PasswordChar = '*';
            this.textRegistrConfirmPassword.Size = new System.Drawing.Size(347, 51);
            this.textRegistrConfirmPassword.TabIndex = 13;
            // 
            // textRegistrPassword
            // 
            this.textRegistrPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRegistrPassword.Location = new System.Drawing.Point(322, 200);
            this.textRegistrPassword.MaxLength = 14;
            this.textRegistrPassword.Multiline = true;
            this.textRegistrPassword.Name = "textRegistrPassword";
            this.textRegistrPassword.PasswordChar = '*';
            this.textRegistrPassword.Size = new System.Drawing.Size(347, 51);
            this.textRegistrPassword.TabIndex = 12;
            // 
            // textRegistrEmail
            // 
            this.textRegistrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRegistrEmail.Location = new System.Drawing.Point(322, 131);
            this.textRegistrEmail.Multiline = true;
            this.textRegistrEmail.Name = "textRegistrEmail";
            this.textRegistrEmail.Size = new System.Drawing.Size(347, 51);
            this.textRegistrEmail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(91, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(91, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(91, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(96, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registrartion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // labelClose
            // 
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(769, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 27);
            this.labelClose.TabIndex = 2;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(815, 492);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textLoginPassword;
        private System.Windows.Forms.TextBox textLoginEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textRegistrConfirmPassword;
        private System.Windows.Forms.TextBox textRegistrPassword;
        private System.Windows.Forms.TextBox textRegistrEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoginSubmit;
        private System.Windows.Forms.Button buttonRegistrSubmit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelClose;
    }
}

