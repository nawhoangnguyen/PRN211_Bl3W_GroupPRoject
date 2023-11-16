namespace SalesWinApp
{
    partial class frmMemberDetail
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
            txtPassword = new TextBox();
            label6 = new Label();
            txtCountry = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtCompanyName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtMemberId = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnCancle = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(490, 114);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(184, 23);
            txtPassword.TabIndex = 31;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 116);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 30;
            label6.Text = "Password";
            label6.Click += label6_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(490, 63);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(184, 23);
            txtCountry.TabIndex = 29;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 65);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 28;
            label5.Text = "Country";
            label5.Click += label5_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(488, 16);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(184, 23);
            txtCity.TabIndex = 27;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 18);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 26;
            label4.Text = "City";
            label4.Click += label4_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(144, 114);
            txtCompanyName.Margin = new Padding(3, 2, 3, 2);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(184, 23);
            txtCompanyName.TabIndex = 25;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 116);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 24;
            label3.Text = "CompanyName";
            label3.Click += label3_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 60);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 23;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 65);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 22;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(144, 13);
            txtMemberId.Margin = new Padding(3, 2, 3, 2);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(184, 23);
            txtMemberId.TabIndex = 21;
            txtMemberId.TextChanged += txtMemberId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 16);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 20;
            label1.Text = "MemberId";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(144, 212);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 31);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(473, 212);
            btnCancle.Margin = new Padding(3, 2, 3, 2);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(116, 31);
            btnCancle.TabIndex = 33;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtCountry);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtCompanyName);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtMemberId);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMemberDetail";
            Text = "frmMemberDetail";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label6;
        private TextBox txtCountry;
        private Label label5;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtCompanyName;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtMemberId;
        private Label label1;
        private Button btnSave;
        private Button btnCancle;
    }
}