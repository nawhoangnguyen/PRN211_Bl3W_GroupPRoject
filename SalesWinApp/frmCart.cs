using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
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
    public partial class frmCart : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        IProductRepository productRepository = new ProductRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        public int memberId { get; set; }
        public ShoppingSessionDTO shoppingSession { get; set; }

        BindingSource source;
        public frmCart()
        {
            InitializeComponent();
        }

        public void LoadProduct(List<ProductDTO> list)
        {
            try
            {

                txtCategoryId.Enabled = false;
                txtProductId.Enabled = false;
                txtProductName.Enabled = false;
                txtUnitPrice.Enabled = false;
                txtUnitsInStock.Enabled = false;
                txtWeight.Enabled = false;
                List<ProductDTO> products = new List<ProductDTO>();
                List<CartItemDTO> cartItems = CartItemDAO.Instance.GetAllCartItemsByShoppingId(shoppingSession.ShoppingId);
                foreach (var cartItem in cartItems)
                {
                    ProductDTO product = productRepository.GetOneById(cartItem.ProductId);
                    products.Add(product);
                }
                if (list.IsNullOrEmpty())
                {
                    products = productRepository.GetAll();

                }
                else
                {
                    products = list;
                }

                source = new BindingSource();
                source.DataSource = products;
                txtCategoryId.DataBindings.Clear();
                txtProductId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtWeight.DataBindings.Clear();

                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                cboCategory.DataSource = CategoryDAO.Instance.GetCategories();
                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "CategoryId";

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;

                dataGridView1.Columns["DiscountId"].Visible = false;
                dataGridView1.Columns["CartItems"].Visible = false;
                dataGridView1.Columns["Category"].Visible = false;
                dataGridView1.Columns["Discount"].Visible = false;
                dataGridView1.Columns["OrderDetails"].Visible = false;
                dataGridView1.Columns["CategoryId"].Visible = false;






            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void frmCart_Load(object sender, EventArgs e)
        {

            txtCategoryId.Enabled = false;
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtUnitsInStock.Enabled = false;
            txtWeight.Enabled = false;

            LoadProduct(null);
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
