namespace SalesWinApp
{
    partial class frmDiscount
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtDescript = new TextBox();
            txtPercent = new NumericUpDown();
            btnAdd = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPercent).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 238);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(715, 276);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 47);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Discount ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "DiscountCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 50);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 87);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 4;
            label4.Text = "Discount Percent";
            // 
            // txtID
            // 
            txtID.Location = new Point(139, 45);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(196, 23);
            txtID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 90);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 23);
            txtName.TabIndex = 7;
            // 
            // txtDescript
            // 
            txtDescript.Location = new Point(508, 45);
            txtDescript.Margin = new Padding(3, 2, 3, 2);
            txtDescript.Name = "txtDescript";
            txtDescript.Size = new Size(196, 23);
            txtDescript.TabIndex = 8;
            // 
            // txtPercent
            // 
            txtPercent.DecimalPlaces = 1;
            txtPercent.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            txtPercent.Location = new Point(514, 80);
            txtPercent.Margin = new Padding(3, 2, 3, 2);
            txtPercent.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(131, 23);
            txtPercent.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(66, 176);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(274, 176);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(457, 176);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 13;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 519);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(txtPercent);
            Controls.Add(txtDescript);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDiscount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discount";
            Load += frmDiscount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDescript;
        private NumericUpDown txtPercent;
        private Button btnAdd;
        private Button button1;
        private Button button2;
    }
}