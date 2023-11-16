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
            btnLoad2.Location = new Point(642, 239);
            btnLoad2.Name = "btnLoad2";
            btnLoad2.Size = new Size(94, 29);
            btnLoad2.TabIndex = 64;
            btnLoad2.Text = "Load";
            btnLoad2.UseVisualStyleBackColor = true;
            btnLoad2.Click += btnLoad2_Click;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(642, 277);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(94, 29);
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
            groupBox1.Location = new Point(665, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 133);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(299, 47);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(148, 27);
            txtTo.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(265, 52);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 41;
            label9.Text = "To";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(89, 47);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(148, 27);
            txtFrom.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 49);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 39;
            label8.Text = "From";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(354, 99);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 38;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // radUnitPrice
            // 
            radUnitPrice.AutoSize = true;
            radUnitPrice.Location = new Point(30, 101);
            radUnitPrice.Name = "radUnitPrice";
            radUnitPrice.Size = new Size(93, 24);
            radUnitPrice.TabIndex = 36;
            radUnitPrice.TabStop = true;
            radUnitPrice.Text = "Unit Price";
            radUnitPrice.UseVisualStyleBackColor = true;
            // 
            // radUnitsInStock
            // 
            radUnitsInStock.AutoSize = true;
            radUnitsInStock.Location = new Point(202, 101);
            radUnitsInStock.Name = "radUnitsInStock";
            radUnitsInStock.Size = new Size(119, 24);
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
            grpSearch.Location = new Point(154, 312);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(479, 133);
            grpSearch.TabIndex = 59;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(249, 27);
            txtSearch.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 49);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 39;
            label7.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(368, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(942, 239);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 58;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(904, 191);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(210, 27);
            txtUnitsInStock.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(808, 195);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 56;
            label6.Text = "UnitsInStock";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(904, 124);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(210, 27);
            txtUnitPrice.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(808, 124);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 54;
            label5.Text = "UnitPrice";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(902, 60);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(210, 27);
            txtWeight.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(808, 63);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 52;
            label4.Text = "Weight";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(278, 196);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(210, 27);
            txtProductName.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 199);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 50;
            label3.Text = "ProductName";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(509, 124);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(210, 27);
            txtCategoryId.TabIndex = 49;
            txtCategoryId.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 131);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 48;
            label2.Text = "Category";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(278, 60);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(210, 27);
            txtProductId.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 64);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 46;
            label1.Text = "ProductId";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(744, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(543, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 44;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(322, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 500);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1051, 268);
            dataGridView1.TabIndex = 42;
            // 
            // cboCategory
            // 
            cboCategory.Enabled = false;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(278, 124);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(210, 28);
            cboCategory.TabIndex = 65;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(953, 463);
            btnAddToCart.Margin = new Padding(3, 4, 3, 4);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(105, 31);
            btnAddToCart.TabIndex = 66;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(1082, 463);
            btnViewCart.Margin = new Padding(3, 4, 3, 4);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(86, 31);
            btnViewCart.TabIndex = 67;
            btnViewCart.Text = "View Cart";
            btnViewCart.TextAlign = ContentAlignment.TopCenter;
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 827);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProducts";
            Text = "frmProducts";
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