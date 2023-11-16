namespace SalesWinApp
{
    partial class frmCart
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
            cboCategory = new ComboBox();
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
            dataGridView1 = new DataGridView();
            btnBuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(316, 80);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(145, 23);
            cboCategory.TabIndex = 78;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(674, 130);
            txtUnitsInStock.Margin = new Padding(3, 2, 3, 2);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(184, 23);
            txtUnitsInStock.TabIndex = 77;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(590, 133);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 76;
            label6.Text = "UnitsInStock";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(674, 80);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(184, 23);
            txtUnitPrice.TabIndex = 75;
            txtUnitPrice.KeyPress += txtUnitPrice_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(590, 80);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 74;
            label5.Text = "UnitPrice";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(672, 32);
            txtWeight.Margin = new Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(184, 23);
            txtWeight.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(590, 34);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 72;
            label4.Text = "Weight";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(126, 134);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(184, 23);
            txtProductName.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 136);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 70;
            label3.Text = "ProductName";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(126, 80);
            txtCategoryId.Margin = new Padding(3, 2, 3, 2);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(184, 23);
            txtCategoryId.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 68;
            label2.Text = "CategoryId";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(126, 32);
            txtProductId.Margin = new Padding(3, 2, 3, 2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(184, 23);
            txtProductId.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 66;
            label1.Text = "ProductId";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 212);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(920, 201);
            dataGridView1.TabIndex = 79;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(440, 173);
            btnBuy.Margin = new Padding(3, 2, 3, 2);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(82, 22);
            btnBuy.TabIndex = 80;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 450);
            Controls.Add(btnBuy);
            Controls.Add(dataGridView1);
            Controls.Add(cboCategory);
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
            Name = "frmCart";
            Text = "Cart";
            Load += frmCart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCategory;
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
        private DataGridView dataGridView1;
        private Button btnBuy;
    }
}