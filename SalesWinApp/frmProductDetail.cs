using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using System.Data;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public bool isAdmin { get; set; }


        IProductRepository productRepository = new ProductRepository();
        IDiscountRepository discountRepository = new DiscountRepository();
        public bool action { get; set; }
        public int idToUpdate { get; set; }
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private CategoryDTO GetCategory(string name)
        {

            List<CategoryDTO> categories = CategoryDAO.Instance.GetCategories();
            CategoryDTO category = categories.Where(p => p.CategoryName.Equals(name)).SingleOrDefault();
            return category;

        }
        private DiscountDTO GetDiscount(Decimal discount)
        {
            List<DiscountDTO> discountDTOs = discountRepository.GetAll();
            DiscountDTO discountDTO = discountDTOs.Where(p => p.DiscountPercent == discount).SingleOrDefault();
            return discountDTO;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            ProductDTO product = new ProductDTO()
            {
                CategoryId = GetCategory(cboCategoryId.SelectedItem.ToString()).CategoryId,
                DiscountId = GetDiscount(Decimal.Parse(cboDiscount.SelectedItem.ToString())).DiscountId,
                Weight = txtWeight.Text,
                ProductName = txtProductName.Text,
                UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                UnitsInStock = Int32.Parse(txtUnitsInStock.Text),
            };


            product.UnitPrice = product.UnitPrice - product.UnitPrice * (Decimal.Parse(cboDiscount.SelectedItem.ToString()) / 100);
            if (action == true)
            {


                productRepository.Add(product);
            }
            else
            {
                product.ProductId = idToUpdate;
                productRepository.Update(product);
            }
            /*  this.Hide();
              frmProducts frmProducts = new frmProducts();*/
            this.Hide();
            this.DialogResult = DialogResult.OK;





        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = false;

            if (!action)
            {
                ProductDTO product = productRepository.GetOneById(idToUpdate);
                var Categories = CategoryDAO.Instance.GetCategories();
                var Discounts = discountRepository.GetAll();



                var Category = Categories.Where(p => p.CategoryId == product.CategoryId).SingleOrDefault();
                var Discount = Discounts.Where(P => P.DiscountId == product.DiscountId);

                int count = 0;
                int count2 = 0;
                foreach (var category in Categories)
                {
                    if (category.CategoryName.Equals(Category.CategoryName))
                    {

                        break;
                    }
                    count++;
                }
                foreach (var discount in Discounts)
                {
                    if (discount.DiscountId.Equals(discount.DiscountId))
                    {

                        break;
                    }
                    count2++;
                }


                foreach (var category in Categories)
                {

                    cboCategoryId.Items.Add(category.CategoryName);

                }
                foreach (var discounts in Discounts)
                {

                    cboDiscount.Items.Add(discounts.DiscountPercent);

                }


                txtProductId.Text = product.ProductId.ToString();
                cboCategoryId.SelectedIndex = count;
                cboDiscount.SelectedIndex = count2;
                txtProductName.Text = product.ProductName;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtUnitsInStock.Text = product.UnitsInStock.ToString();
                txtWeight.Text = product.Weight;



            }
            else
            {
                var Discounts = discountRepository.GetAll();
                var Categories = CategoryDAO.Instance.GetCategories();

                foreach (var category in Categories)
                {

                    cboCategoryId.Items.Add(category.CategoryName);

                }
                foreach (var discounts in Discounts)
                {

                    cboDiscount.Items.Add(discounts.DiscountPercent);

                }

            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtUnitsInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
