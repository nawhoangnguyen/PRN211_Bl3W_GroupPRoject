namespace SalesWinApp
{
    partial class frmProducts
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
            btnLoad2 = new Button();
            btnBuy = new Button();
            groupBox1 = new GroupBox();
            txtTo = new TextBox();
            label9 = new Label();
            txtFrom = new TextBox();
            label8 = new Label();
            btnFilter = new Button();
            radUnitPrice = new RadioButton();
            radUnitsInStock = new RadioButton();
            grpSearch = new GroupBox();
            txtSearch = new TextBox();
            label7 = new Label();
            btnSearch = new Button();
            btnLoad = new Button();
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
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            cboCategory = new ComboBox();
            btnAddToCart = new Button();
            btnViewCart = new Button();
            groupBox1.SuspendLayout();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad2
            // 
            btnLoad2.Location = new Point(562, 179);
            btnLoad2.Margin = new Padding(3, 2, 3, 2);
            btnLoad2.Name = "btnLoad2";
            btnLoad2.Size = new Size(82, 22);
            btnLoad2.TabIndex = 64;
            btnLoad2.Text = "Load";
            btnLoad2.UseVisualStyleBackColor = true;
            btnLoad2.Click += btnLoad2_Click;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(562, 208);
            btnBuy.Margin = new Padding(3, 2, 3, 2);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(82, 22);
            btnBuy.TabIndex = 63;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtFrom);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Controls.Add(radUnitPrice);
            groupBox1.Controls.Add(radUnitsInStock);
            groupBox1.Location = new Point(582, 234);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(419, 100);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(262, 35);
            txtTo.Margin = new Padding(3, 2, 3, 2);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(130, 23);
            txtTo.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(232, 39);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 41;
            label9.Text = "To";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(78, 35);
            txtFrom.Margin = new Padding(3, 2, 3, 2);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(130, 23);
            txtFrom.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 37);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 39;
            label8.Text = "From";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(310, 74);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(82, 22);
            btnFilter.TabIndex = 38;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // radUnitPrice
            // 
            radUnitPrice.AutoSize = true;
            radUnitPrice.Location = new Point(26, 76);
            radUnitPrice.Margin = new Padding(3, 2, 3, 2);
            radUnitPrice.Name = "radUnitPrice";
            radUnitPrice.Size = new Size(76, 19);
            radUnitPrice.TabIndex = 36;
            radUnitPrice.TabStop = true;
            radUnitPrice.Text = "Unit Price";
            radUnitPrice.UseVisualStyleBackColor = true;
            // 
            // radUnitsInStock
            // 
            radUnitsInStock.AutoSize = true;
            radUnitsInStock.Location = new Point(177, 76);
            radUnitsInStock.Margin = new Padding(3, 2, 3, 2);
            radUnitsInStock.Name = "radUnitsInStock";
            radUnitsInStock.Size = new Size(97, 19);
            radUnitsInStock.TabIndex = 37;
            radUnitsInStock.TabStop = true;
            radUnitsInStock.Text = "Units In Stock";
            radUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(label7);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Location = new Point(135, 234);
            grpSearch.Margin = new Padding(3, 2, 3, 2);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(3, 2, 3, 2);
            grpSearch.Size = new Size(419, 100);
            grpSearch.TabIndex = 59;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(78, 35);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search By Product Name";
            txtSearch.Size = new Size(218, 23);
            txtSearch.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 37);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 39;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(316, 34);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(824, 179);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 58;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(791, 143);
            txtUnitsInStock.Margin = new Padding(3, 2, 3, 2);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(184, 23);
            txtUnitsInStock.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(707, 146);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 56;
            label6.Text = "UnitsInStock";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(791, 93);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(184, 23);
            txtUnitPrice.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(707, 93);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 54;
            label5.Text = "UnitPrice";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(789, 45);
            txtWeight.Margin = new Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(184, 23);
            txtWeight.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(707, 47);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 52;
            label4.Text = "Weight";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(243, 147);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(184, 23);
            txtProductName.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 149);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 50;
            label3.Text = "ProductName";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(243, 93);
            txtCategoryId.Margin = new Padding(3, 2, 3, 2);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(184, 23);
            txtCategoryId.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 98);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 48;
            label2.Text = "CategoryId";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(243, 45);
            txtProductId.Margin = new Padding(3, 2, 3, 2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(184, 23);
            txtProductId.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 46;
            label1.Text = "ProductId";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(651, 179);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(475, 179);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 44;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(282, 179);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(102, 375);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(920, 201);
            dataGridView1.TabIndex = 42;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(433, 93);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(145, 23);
            cboCategory.TabIndex = 65;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(834, 347);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(92, 23);
            btnAddToCart.TabIndex = 66;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Visible = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(947, 347);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(75, 23);
            btnViewCart.TabIndex = 67;
            btnViewCart.Text = "View Cart";
            btnViewCart.TextAlign = ContentAlignment.TopCenter;
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Visible = false;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 620);
            Controls.Add(btnViewCart);
            Controls.Add(btnAddToCart);
            Controls.Add(cboCategory);
            Controls.Add(btnLoad2);
            Controls.Add(btnBuy);
            Controls.Add(groupBox1);
            Controls.Add(grpSearch);
            Controls.Add(btnLoad);
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
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "frmProducts";
            Text = "Product";
            Load += frmProducts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad2;
        private Button btnBuy;
        private GroupBox groupBox1;
        private TextBox txtTo;
        private Label label9;
        private TextBox txtFrom;
        private Label label8;
        private Button btnFilter;
        private RadioButton radUnitPrice;
        private RadioButton radUnitsInStock;
        private GroupBox grpSearch;
        private TextBox txtSearch;
        private Label label7;
        private Button btnSearch;
        private Button btnLoad;
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
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private ComboBox cboCategory;
        private Button btnAddToCart;
        private Button btnViewCart;
    }
}