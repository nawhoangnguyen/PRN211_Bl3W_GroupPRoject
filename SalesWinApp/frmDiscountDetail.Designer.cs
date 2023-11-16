namespace SalesWinApp
{
    partial class frmDiscountDetail
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
            label7 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label5 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtDiscountName = new TextBox();
            label3 = new Label();
            txtDiscountId = new TextBox();
            label1 = new Label();
            txtPercent = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtPercent).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(244, 16);
            label7.Name = "label7";
            label7.Size = new Size(201, 32);
            label7.TabIndex = 35;
            label7.Text = "Discount Details";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(519, 278);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 31);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(166, 278);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 31);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 212);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 44;
            label5.Text = "Percent";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(166, 163);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(470, 32);
            txtDescription.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 164);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 42;
            label4.Text = "Description";
            // 
            // txtDiscountName
            // 
            txtDiscountName.Location = new Point(166, 117);
            txtDiscountName.Margin = new Padding(3, 2, 3, 2);
            txtDiscountName.Multiline = true;
            txtDiscountName.Name = "txtDiscountName";
            txtDiscountName.Size = new Size(470, 32);
            txtDiscountName.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 118);
            label3.Name = "label3";
            label3.Size = new Size(138, 18);
            label3.TabIndex = 40;
            label3.Text = "DiscountTitle";
            // 
            // txtDiscountId
            // 
            txtDiscountId.Location = new Point(166, 64);
            txtDiscountId.Margin = new Padding(3, 2, 3, 2);
            txtDiscountId.Multiline = true;
            txtDiscountId.Name = "txtDiscountId";
            txtDiscountId.Size = new Size(470, 32);
            txtDiscountId.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 66);
            label1.Name = "label1";
            label1.Size = new Size(108, 18);
            label1.TabIndex = 36;
            label1.Text = "DiscountID";
            label1.Click += label1_Click;
            // 
            // txtPercent
            // 
            txtPercent.DecimalPlaces = 1;
            txtPercent.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            txtPercent.Location = new Point(166, 212);
            txtPercent.Margin = new Padding(3, 2, 3, 2);
            txtPercent.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(469, 23);
            txtPercent.TabIndex = 50;
            // 
            // frmDiscountDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 340);
            Controls.Add(txtPercent);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtDiscountName);
            Controls.Add(label3);
            Controls.Add(txtDiscountId);
            Controls.Add(label1);
            Controls.Add(label7);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDiscountDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiscountDetail";
            Load += DiscountDetail_Load;
            ((System.ComponentModel.ISupportInitialize)txtPercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button btnCancel;
        private Button btnSave;
        private Label label5;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtDiscountName;
        private Label label3;
        private TextBox txtDiscountId;
        private Label label1;
        private NumericUpDown txtPercent;
    }
}