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
            cboCategory.Location = new Point(361, 107);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(165, 28);
            cboCategory.TabIndex = 78;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(770, 173);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(210, 27);
            txtUnitsInStock.TabIndex = 77;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(674, 177);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 76;
            label6.Text = "UnitsInStock";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(770, 107);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(210, 27);
            txtUnitPrice.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 107);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 74;
            label5.Text = "UnitPrice";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(768, 43);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(210, 27);
            txtWeight.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(674, 45);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 72;
            label4.Text = "Weight";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(144, 179);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(210, 27);
            txtProductName.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 181);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 70;
            label3.Text = "ProductName";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(144, 107);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(210, 27);
            txtCategoryId.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 68;
            label2.Text = "CategoryId";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(144, 43);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(210, 27);
            txtProductId.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 47);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 66;
            label1.Text = "ProductId";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1051, 268);
            dataGridView1.TabIndex = 79;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(503, 231);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(94, 29);
            btnBuy.TabIndex = 80;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 568);
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
            Margin = new Padding(3, 4, 3, 4);
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