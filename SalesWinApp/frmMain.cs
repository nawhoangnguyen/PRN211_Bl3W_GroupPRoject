using BusinessObject.Models;

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

        private void postToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosts frmPosts = new frmPosts()
            {

                isAdmin = this.isAdmin,
                memberId = this.memberId
            };
            frmPosts.ShowDialog();
        }

        private void discountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiscount frmDiscount = new frmDiscount()
            {

                isAdmin = this.isAdmin,
                memberId = this.memberId
            };
            frmDiscount.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
}
