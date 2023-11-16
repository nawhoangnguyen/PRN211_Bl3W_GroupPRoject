using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        IProductRepository productRepository = new ProductRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public bool isAdmin { get; set; }
        public int memberId { get; set; }
        public ShoppingSessionDTO shoppingSession { get; set; }

        BindingSource source;
        public frmProducts()
        {
            InitializeComponent();


        }
        private void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            txtWeight.Text = string.Empty;
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





                if (isAdmin == false)
                {
                    if (products.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = true;

                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
                else
                {
                    if (products.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;

                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail()
            {
                action = true
            };

            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProduct(null);
                source.Position = source.Count - 1;
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            txtCategoryId.Enabled = false;
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtUnitsInStock.Enabled = false;
            txtWeight.Enabled = false;

            LoadProduct(null);
            if (!isAdmin)
            {
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnLoad.Visible = false;
            }
            else
            {

                btnBuy.Visible = false;
                btnLoad2.Visible = false;
                btnAddToCart.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you sure you want to delete this product ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productRepository.Delete(Int32.Parse(txtProductId.Text));
                LoadProduct(null);
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail()
            {
                action = false,
                idToUpdate = Int32.Parse(txtProductId.Text)

            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProduct(null);
                source.Position = source.Count - 1;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProduct(null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            bool check = true;
            /* if (radId.Checked)
             {
                 check = false;
             }*/

            try
            {
                LoadProduct(productRepository.SearchByNameAndIdOrSortByUnitPriceAndUnitsPriceInStock(txtSearch.Text, null, null, check));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            bool check = true;
            var from = 0;

            if (radUnitsInStock.Checked)
            {
                check = false;
            }
            try
            {
                LoadProduct(productRepository.SearchByNameAndIdOrSortByUnitPriceAndUnitsPriceInStock(null, txtFrom.Text, txtTo.Text, check));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            LoadProduct(null);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            OrderDTO order = new OrderDTO()
            {
                Freight = null,
                MemberId = this.memberId,
                OrderDate = DateTime.Now,
                RequiredDate = null,
                ShippedDate = null,

            };

            order = orderRepository.Add(order);
            OrderDetailDTO orderDetail = new OrderDetailDTO()
            {
                OrderId = order.OrderId,
                ProductId = Int32.Parse(txtProductId.Text),
                UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                Quantity = 1,
                Discount = 0,


            };

            orderDetailRepository.Add(orderDetail);
            ProductDTO product = productRepository.GetOneById(Int32.Parse(txtProductId.Text));
            product.UnitsInStock = product.UnitsInStock - 1;
            productRepository.Update(product);
            MessageBox.Show("Buy Successfully");
            LoadProduct(productRepository.GetAll());



        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add to cart successfully!!");
            CartItemDTO cartItem = new CartItemDTO()
            {
                ShoppingSessionId = shoppingSession.ShoppingId,
                ProductId = Int32.Parse(txtProductId.Text),
                Quantity = 1,
            };

            CartItemDAO.Instance.Add(cartItem);

            shoppingSession.Total = shoppingSession.Total + Decimal.Parse(txtUnitPrice.Text);
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            frmCart frmCart = new frmCart()
            {
                memberId = memberId,
                shoppingSession = shoppingSession
            };

            frmCart.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedProduct = (ProductDTO)dataGridView1.SelectedRows[0].DataBoundItem;
                try
                {
                    DiscountDTO discountDTO = DiscountDAO.Instance.GetDiscountId(Int32.Parse(selectedProduct.DiscountId.ToString()));
                    if(discountDTO != null)
                        txtDiscount.Text = discountDTO.DiscountPercent.ToString();


                }
                catch (Exception ex) {
                    txtDiscount.Text = "0";
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
