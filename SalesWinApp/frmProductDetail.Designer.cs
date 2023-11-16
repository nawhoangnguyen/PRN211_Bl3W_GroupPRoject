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
            txtCategoryId = new TextBox();
            label2 = new Label();
            txtProductId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(466, 253);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 31);
            btnCancel.TabIndex = 47;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(136, 253);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 31);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(485, 131);
            txtUnitsInStock.Margin = new Padding(3, 2, 3, 2);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(184, 23);
            txtUnitsInStock.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 134);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 58;
            label6.Text = "UnitsInStock";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(485, 80);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(184, 23);
            txtUnitPrice.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 80);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 56;
            label5.Text = "UnitPrice";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(483, 33);
            txtWeight.Margin = new Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(184, 23);
            txtWeight.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 35);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 54;
            label4.Text = "Weight";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(138, 131);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(184, 23);
            txtProductName.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 134);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 52;
            label3.Text = "ProductName";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(138, 77);
            txtCategoryId.Margin = new Padding(3, 2, 3, 2);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(184, 23);
            txtCategoryId.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 82);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 50;
            label2.Text = "CategoryId";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(138, 30);
            txtProductId.Margin = new Padding(3, 2, 3, 2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(184, 23);
            txtProductId.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 48;
            label1.Text = "ProductId";
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtUnitsInStock);
            Controls.Add(label6);
            Controls.Add(txtUnitPrice);
            Controls.Add(label5);
            Controls.Add(txtWeight);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(txtCategoryId);
            Controls.Add(label2);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtCategoryId;
        private Label label2;
        private TextBox txtProductId;
        private Label label1;
    }
}