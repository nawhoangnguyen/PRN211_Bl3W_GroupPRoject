using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public bool isAdmin { get; set; }
        public int memberId { get; set; }
        public ShoppingSessionDTO shoppingSession { get; set; }

        public frmMain()
        {

            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                tsMember.Text = "Profile";
                tsProduct.Text = "Product List";
                tsOrder.Text = "Order History";
            }
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                frmMemberDetail frmMemberDetail = new()
                {
                    idToUpdate = memberId,
                    isAdmin = this.isAdmin
                };
                frmMemberDetail.ShowDialog();
            }
            else
            {
                frmMembers frmMembers = new frmMembers()
                {
                    isAdmin = this.isAdmin,

                };
                frmMembers.ShowDialog();
            }


        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmProducts frmProducts = new frmProducts()
            {
                isAdmin = this.isAdmin,
                memberId = this.memberId,
                shoppingSession = shoppingSession

            };
            frmProducts.ShowDialog();

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                tsMember.Text = "Profile";
                tsProduct.Text = "Product List";
                tsOrder.Text = "Order History";
            }
        }

        private void tsOrder_Click(object sender, EventArgs e)
        {

            frmOrders frmOrders = new frmOrders()
            {

                isAdmin = this.isAdmin,
                memberId = this.memberId
            };
            frmOrders.ShowDialog();
        }


    }
}
