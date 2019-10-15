namespace Assignment2
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.usernameText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordbox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.loginButton = new System.Windows.Forms.Button();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.viewBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.usernameText.Font = new System.Drawing.Font("Arial", 12F);
            this.usernameText.Location = new System.Drawing.Point(117, 142);
            this.usernameText.Multiline = true;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(253, 23);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "Username";
            this.usernameText.Click += new System.EventHandler(this.usernameText_TextChanged);
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            this.usernameText.Enter += new System.EventHandler(this.usernameText_Enter);
            this.usernameText.Leave += new System.EventHandler(this.usernameText_Leave);
            // 
            // firstNameText
            // 
            this.firstNameText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameText.Font = new System.Drawing.Font("Arial", 12F);
            this.firstNameText.Location = new System.Drawing.Point(117, 204);
            this.firstNameText.Multiline = true;
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(253, 23);
            this.firstNameText.TabIndex = 2;
            this.firstNameText.Text = "First Name";
            this.firstNameText.Enter += new System.EventHandler(this.firstname_Enter);
            this.firstNameText.Leave += new System.EventHandler(this.firstname_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordBox.Location = new System.Drawing.Point(115, 332);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(253, 23);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.Text = "Password";
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.Enter += new System.EventHandler(this.password_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.password_Leave);
            // 
            // confirmPasswordbox
            // 
            this.confirmPasswordbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.confirmPasswordbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordbox.Font = new System.Drawing.Font("Arial", 12F);
            this.confirmPasswordbox.Location = new System.Drawing.Point(115, 400);
            this.confirmPasswordbox.Multiline = true;
            this.confirmPasswordbox.Name = "confirmPasswordbox";
            this.confirmPasswordbox.Size = new System.Drawing.Size(253, 23);
            this.confirmPasswordbox.TabIndex = 5;
            this.confirmPasswordbox.Text = "Confirm Password";
            this.confirmPasswordbox.TextChanged += new System.EventHandler(this.confirmPasswordbox_TextChanged);
            this.confirmPasswordbox.Enter += new System.EventHandler(this.confirmPassword_Enter);
            this.confirmPasswordbox.Leave += new System.EventHandler(this.confirmPassword_Leave);
            // 
            // DOB
            // 
            this.DOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.DOB.CustomFormat = "dd-mm-yyyy";
            this.DOB.Font = new System.Drawing.Font("Arial", 12F);
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(111, 534);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(253, 26);
            this.DOB.TabIndex = 7;
            this.DOB.Value = new System.DateTime(2018, 10, 9, 0, 0, 0, 0);
            this.DOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Moccasin;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(22, 584);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(181, 40);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // lastNameText
            // 
            this.lastNameText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameText.Font = new System.Drawing.Font("Arial", 12F);
            this.lastNameText.Location = new System.Drawing.Point(117, 264);
            this.lastNameText.Multiline = true;
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(253, 23);
            this.lastNameText.TabIndex = 3;
            this.lastNameText.Text = "Last Name";
            this.lastNameText.Enter += new System.EventHandler(this.lastname_Enter);
            this.lastNameText.Leave += new System.EventHandler(this.lastName_Leave);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.Moccasin;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.Location = new System.Drawing.Point(298, 584);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(181, 40);
            this.register_button.TabIndex = 9;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // viewBox
            // 
            this.viewBox.BackColor = System.Drawing.Color.White;
            this.viewBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewBox.Font = new System.Drawing.Font("Arial", 12F);
            this.viewBox.FormattingEnabled = true;
            this.viewBox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.viewBox.Location = new System.Drawing.Point(113, 469);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(253, 26);
            this.viewBox.TabIndex = 6;
            this.viewBox.SelectedIndexChanged += new System.EventHandler(this.viewBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirm Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "View: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date of Birth: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(117, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 2);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(117, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 2);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(115, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 2);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(115, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 2);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(113, 423);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 2);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(114, 493);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(254, 2);
            this.panel6.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(110, 558);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(254, 2);
            this.panel7.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(25, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(444, 42);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Create your Account";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(513, 675);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.confirmPasswordbox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.usernameText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox confirmPasswordbox;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.ComboBox viewBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox2;
    }
}