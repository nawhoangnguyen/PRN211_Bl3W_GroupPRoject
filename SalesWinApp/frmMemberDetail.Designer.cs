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
            label7 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(245, 407);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(536, 41);
            txtPassword.TabIndex = 31;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(79, 409);
            label6.Name = "label6";
            label6.Size = new Size(106, 22);
            label6.TabIndex = 30;
            label6.Text = "Password";
            label6.Click += label6_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(245, 342);
            txtCountry.Multiline = true;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(536, 41);
            txtCountry.TabIndex = 29;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 344);
            label5.Name = "label5";
            label5.Size = new Size(94, 22);
            label5.TabIndex = 28;
            label5.Text = "Country";
            label5.Click += label5_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(245, 279);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(536, 41);
            txtCity.TabIndex = 27;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 281);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 26;
            label4.Text = "City";
            label4.Click += label4_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(245, 218);
            txtCompanyName.Multiline = true;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(536, 41);
            txtCompanyName.TabIndex = 25;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 220);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 24;
            label3.Text = "CompanyName";
            label3.Click += label3_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(245, 150);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(536, 41);
            txtEmail.TabIndex = 23;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 152);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 22;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(245, 84);
            txtMemberId.Multiline = true;
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(536, 41);
            txtMemberId.TabIndex = 21;
            txtMemberId.TextChanged += txtMemberId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 86);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 20;
            label1.Text = "MemberId";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(245, 481);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 41);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(648, 481);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(133, 41);
            btnCancle.TabIndex = 33;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(392, 18);
            label7.Name = "label7";
            label7.Size = new Size(226, 41);
            label7.TabIndex = 34;
            label7.Text = "Member detail";
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 558);
            Controls.Add(label7);
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
            Name = "frmMemberDetail";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label7;
    }
}