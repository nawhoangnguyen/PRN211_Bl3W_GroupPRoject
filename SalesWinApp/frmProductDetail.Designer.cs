namespace SalesWinApp
{
    partial class frmProductDetail
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
            btnCancel = new Button();
            btnSave = new Button();
            txtUnitsInStock = new TextBox();
            label6 = new Label();
            txtUnitPrice = new TextBox();
            label5 = new Label();
            txtWeight = new TextBox();
            label4 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtProductId = new TextBox();
            label1 = new Label();
            cboCategoryId = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(533, 337);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 41);
            btnCancel.TabIndex = 47;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(155, 337);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 41);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(554, 175);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(210, 27);
            txtUnitsInStock.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 179);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 58;
            label6.Text = "UnitsInStock";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(554, 107);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(210, 27);
            txtUnitPrice.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 107);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 56;
            label5.Text = "UnitPrice";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(552, 44);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(210, 27);
            txtWeight.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 47);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 54;
            label4.Text = "Weight";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(158, 175);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(210, 27);
            txtProductName.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 179);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 52;
            label3.Text = "ProductName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 109);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 50;
            label2.Text = "Category";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(158, 40);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(210, 27);
            txtProductId.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 48;
            label1.Text = "ProductId";
            // 
            // cboCategoryId
            // 
            cboCategoryId.FormattingEnabled = true;
            cboCategoryId.Location = new Point(158, 106);
            cboCategoryId.Name = "cboCategoryId";
            cboCategoryId.Size = new Size(210, 28);
            cboCategoryId.TabIndex = 60;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(cboCategoryId);
            Controls.Add(txtUnitsInStock);
            Controls.Add(label6);
            Controls.Add(txtUnitPrice);
            Controls.Add(label5);
            Controls.Add(txtWeight);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmProductDetail";
            Text = "frmProductDetail";
            Load += frmProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtUnitsInStock;
        private Label label6;
        private TextBox txtUnitPrice;
        private Label label5;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtProductName;
        private Label label3;
        private Label label2;
        private TextBox txtProductId;
        private Label label1;
        private ComboBox cboCategoryId;
    }
}