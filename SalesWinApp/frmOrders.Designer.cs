namespace SalesWinApp
{
    partial class frmOrders
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
            txtFreight = new TextBox();
            label6 = new Label();
            txtShippedDate = new TextBox();
            label5 = new Label();
            txtRequriedDate = new TextBox();
            label4 = new Label();
            txtOrderDate = new TextBox();
            label3 = new Label();
            txtMemberId = new TextBox();
            sa = new Label();
            txtOrderId = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnFilter = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            groupBox2 = new GroupBox();
            txtDiscountDe = new TextBox();
            txtUnitPriceDe = new TextBox();
            txtProductIdDe = new TextBox();
            txtQuantityDe = new TextBox();
            txtOrderIdDe = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            dgvOrderDetail = new DataGridView();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(746, 134);
            txtFreight.Margin = new Padding(3, 2, 3, 2);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(184, 23);
            txtFreight.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(649, 139);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 56;
            label6.Text = "Freight";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(746, 86);
            txtShippedDate.Margin = new Padding(3, 2, 3, 2);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(184, 23);
            txtShippedDate.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(649, 86);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 54;
            label5.Text = "Shipped Date";
            // 
            // txtRequriedDate
            // 
            txtRequriedDate.Location = new Point(746, 38);
            txtRequriedDate.Margin = new Padding(3, 2, 3, 2);
            txtRequriedDate.Name = "txtRequriedDate";
            txtRequriedDate.Size = new Size(184, 23);
            txtRequriedDate.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(649, 40);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 52;
            label4.Text = "Required Date";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(186, 140);
            txtOrderDate.Margin = new Padding(3, 2, 3, 2);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(184, 23);
            txtOrderDate.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 142);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 50;
            label3.Text = "Order Date";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(186, 86);
            txtMemberId.Margin = new Padding(3, 2, 3, 2);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(184, 23);
            txtMemberId.TabIndex = 49;
            // 
            // sa
            // 
            sa.AutoSize = true;
            sa.Location = new Point(82, 91);
            sa.Name = "sa";
            sa.Size = new Size(65, 15);
            sa.TabIndex = 48;
            sa.Text = "Member Id";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(186, 38);
            txtOrderId.Margin = new Padding(3, 2, 3, 2);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(184, 23);
            txtOrderId.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 46;
            label1.Text = "Order Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 332);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(920, 201);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(127, 106);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(82, 22);
            btnFilter.TabIndex = 38;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 38);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 39;
            label8.Text = "From";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 76);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 41;
            label9.Text = "To";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpTo);
            groupBox1.Controls.Add(dtpFrom);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Location = new Point(357, 175);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(313, 140);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Date";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(69, 73);
            dtpTo.Margin = new Padding(3, 2, 3, 2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(214, 23);
            dtpTo.TabIndex = 43;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(69, 39);
            dtpFrom.Margin = new Padding(3, 2, 3, 2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(214, 23);
            dtpFrom.TabIndex = 42;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDiscountDe);
            groupBox2.Controls.Add(txtUnitPriceDe);
            groupBox2.Controls.Add(txtProductIdDe);
            groupBox2.Controls.Add(txtQuantityDe);
            groupBox2.Controls.Add(txtOrderIdDe);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(dgvOrderDetail);
            groupBox2.Location = new Point(1054, 29);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(429, 482);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Details";
            // 
            // txtDiscountDe
            // 
            txtDiscountDe.Location = new Point(96, 110);
            txtDiscountDe.Margin = new Padding(3, 2, 3, 2);
            txtDiscountDe.Name = "txtDiscountDe";
            txtDiscountDe.Size = new Size(98, 23);
            txtDiscountDe.TabIndex = 53;
            // 
            // txtUnitPriceDe
            // 
            txtUnitPriceDe.Location = new Point(318, 31);
            txtUnitPriceDe.Margin = new Padding(3, 2, 3, 2);
            txtUnitPriceDe.Name = "txtUnitPriceDe";
            txtUnitPriceDe.Size = new Size(92, 23);
            txtUnitPriceDe.TabIndex = 52;
            // 
            // txtProductIdDe
            // 
            txtProductIdDe.Location = new Point(96, 71);
            txtProductIdDe.Margin = new Padding(3, 2, 3, 2);
            txtProductIdDe.Name = "txtProductIdDe";
            txtProductIdDe.Size = new Size(98, 23);
            txtProductIdDe.TabIndex = 51;
            // 
            // txtQuantityDe
            // 
            txtQuantityDe.Location = new Point(318, 71);
            txtQuantityDe.Margin = new Padding(3, 2, 3, 2);
            txtQuantityDe.Name = "txtQuantityDe";
            txtQuantityDe.Size = new Size(92, 23);
            txtQuantityDe.TabIndex = 50;
            // 
            // txtOrderIdDe
            // 
            txtOrderIdDe.Location = new Point(96, 31);
            txtOrderIdDe.Margin = new Padding(3, 2, 3, 2);
            txtOrderIdDe.Name = "txtOrderIdDe";
            txtOrderIdDe.Size = new Size(98, 23);
            txtOrderIdDe.TabIndex = 48;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(243, 73);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 46;
            label10.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(243, 32);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 45;
            label11.Text = "UnitPrice";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 111);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 44;
            label12.Text = "Discount";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 73);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 43;
            label13.Text = "ProductId";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 32);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 42;
            label14.Text = "OrderId";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(5, 245);
            dgvOrderDetail.Margin = new Padding(3, 2, 3, 2);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetail.Size = new Size(418, 195);
            dgvOrderDetail.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.Location = new Point(888, 293);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(82, 22);
            btnView.TabIndex = 62;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 589);
            Controls.Add(btnView);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtFreight);
            Controls.Add(label6);
            Controls.Add(txtShippedDate);
            Controls.Add(label5);
            Controls.Add(txtRequriedDate);
            Controls.Add(label4);
            Controls.Add(txtOrderDate);
            Controls.Add(label3);
            Controls.Add(txtMemberId);
            Controls.Add(sa);
            Controls.Add(txtOrderId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOrders";
            Text = "OrderManagement";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFreight;
        private Label label6;
        private TextBox txtShippedDate;
        private Label label5;
        private TextBox txtRequriedDate;
        private Label label4;
        private TextBox txtOrderDate;
        private Label label3;
        private TextBox txtMemberId;
        private Label sa;
        private TextBox txtOrderId;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnFilter;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private GroupBox groupBox2;
        private TextBox txtDiscountDe;
        private TextBox txtUnitPriceDe;
        private TextBox txtProductIdDe;
        private TextBox txtQuantityDe;
        private TextBox txtOrderIdDe;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridView dgvOrderDetail;
        private Button btnView;
    }
}