namespace SalesWinApp
{
    partial class frmPostDetail
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
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtPostId = new TextBox();
            txtContent = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 81);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Post Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 19);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Post Id";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(140, 81);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(322, 56);
            txtTitle.TabIndex = 2;
            // 
            // txtPostId
            // 
            txtPostId.Enabled = false;
            txtPostId.Location = new Point(140, 16);
            txtPostId.Name = "txtPostId";
            txtPostId.Size = new Size(126, 27);
            txtPostId.TabIndex = 3;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(140, 189);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(672, 286);
            txtContent.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 189);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 4;
            label3.Text = "Post Content";
            // 
            // button1
            // 
            button1.Location = new Point(250, 505);
            button1.Name = "button1";
            button1.Size = new Size(136, 43);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(557, 505);
            button2.Name = "button2";
            button2.Size = new Size(136, 43);
            button2.TabIndex = 7;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmPostDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 569);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtContent);
            Controls.Add(label3);
            Controls.Add(txtPostId);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPostDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPostDetail";
            Load += frmPostDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtPostId;
        private TextBox txtContent;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}