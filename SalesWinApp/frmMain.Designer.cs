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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsMember, tsProduct, tsOrder, postToolStripMenuItem, discountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsMember
            // 
            tsMember.Name = "tsMember";
            tsMember.Size = new Size(79, 24);
            tsMember.Text = "Member";
            tsMember.Click += memberToolStripMenuItem_Click;
            // 
            // tsProduct
            // 
            tsProduct.Name = "tsProduct";
            tsProduct.Size = new Size(74, 24);
            tsProduct.Text = "Product";
            tsProduct.Click += productManagementToolStripMenuItem_Click;
            // 
            // tsOrder
            // 
            tsOrder.Name = "tsOrder";
            tsOrder.Size = new Size(61, 24);
            tsOrder.Text = "Order";
            tsOrder.Click += tsOrder_Click;
            // 
            // postToolStripMenuItem
            // 
            postToolStripMenuItem.Name = "postToolStripMenuItem";
            postToolStripMenuItem.Size = new Size(50, 24);
            postToolStripMenuItem.Text = "Post";
            postToolStripMenuItem.Click += postToolStripMenuItem_Click;
            // 
            // discountToolStripMenuItem
            // 
            discountToolStripMenuItem.Name = "discountToolStripMenuItem";
            discountToolStripMenuItem.Size = new Size(81, 24);
            discountToolStripMenuItem.Text = "Discount";
            discountToolStripMenuItem.Click += discountToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}