namespace SalesWinApp
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            tsMember = new ToolStripMenuItem();
            tsProduct = new ToolStripMenuItem();
            tsOrder = new ToolStripMenuItem();
            postToolStripMenuItem = new ToolStripMenuItem();

            discountToolStripMenuItem = new ToolStripMenuItem();
            btnLogout = new Button();

            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsMember, tsProduct, tsOrder, postToolStripMenuItem, discountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsMember
            // 
            tsMember.Name = "tsMember";
            tsMember.Size = new Size(64, 20);
            tsMember.Text = "Member";
            tsMember.Click += memberToolStripMenuItem_Click;
            // 
            // tsProduct
            // 
            tsProduct.Name = "tsProduct";
            tsProduct.Size = new Size(61, 20);
            tsProduct.Text = "Product";
            tsProduct.Click += productManagementToolStripMenuItem_Click;
            // 
            // tsOrder
            // 
            tsOrder.Name = "tsOrder";
            tsOrder.Size = new Size(49, 20);
            tsOrder.Text = "Order";
            tsOrder.Click += tsOrder_Click;
            // 
            // postToolStripMenuItem
            // 
            postToolStripMenuItem.Name = "postToolStripMenuItem";
            postToolStripMenuItem.Size = new Size(42, 20);
            postToolStripMenuItem.Text = "Post";
            postToolStripMenuItem.Click += postToolStripMenuItem_Click;
            // 

            // discountToolStripMenuItem
            // 
            discountToolStripMenuItem.Name = "discountToolStripMenuItem";
            discountToolStripMenuItem.Size = new Size(81, 24);
            discountToolStripMenuItem.Text = "Discount";
            discountToolStripMenuItem.Click += discountToolStripMenuItem_Click;

            // btnLogout
            // 
            btnLogout.Location = new Point(695, 407);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(82, 22);
            btnLogout.TabIndex = 44;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Main";
            Load += frmMain_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsMember;
        private ToolStripMenuItem tsProduct;
        private ToolStripMenuItem tsOrder;
        private ToolStripMenuItem postToolStripMenuItem;
        private ToolStripMenuItem discountToolStripMenuItem;
        private Button btnLogout;
    }
}