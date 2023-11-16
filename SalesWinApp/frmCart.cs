using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
using System.Data;

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

        public void LoadProduct(List<CartItemDTO> list)
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

                // Tạo một cột mới
                DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();

                // Cấu hình các thuộc tính của cột
                quantityColumn.HeaderText = "Quantity";
                quantityColumn.Name = "Quantity";

                // Thêm cột vào DataGridView
                dataGridView1.Columns.Add(quantityColumn);

                dataGridView1.Columns["DiscountId"].Visible = false;
                dataGridView1.Columns["CartItems"].Visible = false;
                dataGridView1.Columns["Category"].Visible = false;
                dataGridView1.Columns["Discount"].Visible = false;
                dataGridView1.Columns["OrderDetails"].Visible = false;
                dataGridView1.Columns["CategoryId"].Visible = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int productId = Convert.ToInt32(row.Cells["ProductId"].Value);

                    List<CartItemDTO> cartItem = cartItems.Where(item => item.ProductId == productId).ToList();
                    int count = 0;
                    foreach (var cart in cartItem)
                    {
                        count++;
                    }
                    if (!cartItem.IsNullOrEmpty())
                    {
                        // Gán giá trị Quantity từ CartItemDTO cho cột "Quantity"
                        row.Cells["Quantity"].Value = count;
                    }
                    else
                    {
                        // Nếu không tìm thấy CartItemDTO, có thể đặt giá trị mặc định hoặc để trống tùy thuộc vào yêu cầu
                        row.Cells["Quantity"].Value = 0; // Hoặc giá trị mặc định khác
                    }
                }




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
    }
}
