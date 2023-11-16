namespace SalesWinApp
{
    partial class frmPosts
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
            grpSearch = new GroupBox();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            label7 = new Label();
            btnFind = new Button();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            lbPostId = new Label();
            lbTitle = new Label();
            txtContent = new TextBox();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(cboSort);
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(label7);
            grpSearch.Controls.Add(btnFind);
            grpSearch.Location = new Point(62, 68);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(432, 133);
            grpSearch.TabIndex = 82;
            grpSearch.TabStop = false;
            grpSearch.Text = "Filter";
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "Sort Date", "Newest", "Oldest" });
            cboSort.Location = new Point(327, 46);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(94, 28);
            cboSort.TabIndex = 41;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(231, 27);
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
            // btnFind
            // 
            btnFind.Location = new Point(89, 98);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 38;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(400, 24);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 81;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(62, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 68;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(288, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(173, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 66;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(432, 268);
            dataGridView1.TabIndex = 65;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbPostId);
            groupBox1.Controls.Add(lbTitle);
            groupBox1.Controls.Add(txtContent);
            groupBox1.Location = new Point(599, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 465);
            groupBox1.TabIndex = 83;
            groupBox1.TabStop = false;
            groupBox1.Text = "Post Detail";
            // 
            // lbPostId
            // 
            lbPostId.AutoSize = true;
            lbPostId.Location = new Point(96, 41);
            lbPostId.Name = "lbPostId";
            lbPostId.Size = new Size(50, 20);
            lbPostId.TabIndex = 2;
            lbPostId.Text = "label1";
            lbPostId.Visible = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(15, 29);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(61, 35);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Title";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(15, 81);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(525, 370);
            txtContent.TabIndex = 0;
            // 
            // frmPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 505);
            Controls.Add(groupBox1);
            Controls.Add(grpSearch);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "frmPosts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPost";
            Load += frmPosts_Load;
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpSearch;
        private TextBox txtSearch;
        private Label label7;
        private Button btnFind;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private ComboBox cboSort;
        private GroupBox groupBox1;
        private Label lbTitle;
        private TextBox txtContent;
        private Label lbPostId;
    }
}