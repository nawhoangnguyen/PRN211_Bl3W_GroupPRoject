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

        public bool action { get; set; }
        public int idToUpdate { get; set; }
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private CategoryDTO GetCategory(string name)
        {

            var categories = CategoryDAO.Instance.GetCategories();
            CategoryDTO category = (CategoryDTO)categories.Where(p => p.CategoryName.Equals(name));
            return (CategoryDTO)category;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            ProductDTO product = new ProductDTO()
            {
                CategoryId = Int32.Parse(GetCategory(cboCategoryId.ValueMember.ToString()).CategoryId.ToString()),
                Weight = txtWeight.Text,
                ProductName = txtProductName.Text,
                UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                UnitsInStock = Int32.Parse(txtUnitsInStock.Text),


            };


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
                var Category = GetCategory(cboCategoryId.ValueMember.ToString());
                var Categories = CategoryDAO.Instance.GetCategories();
                int count = 0;
                foreach (var category in Categories)
                {
                    if (category.CategoryName.Equals(Category))
                    {
                        count++;
                        return;
                    }
                }

                ProductDTO product = productRepository.GetOneById(idToUpdate);

                txtProductId.Text = product.ProductId.ToString();
                cboCategoryId.SelectedIndex = count;
                txtProductName.Text = product.ProductName;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtUnitsInStock.Text = product.UnitsInStock.ToString();
                txtWeight.Text = product.Weight;


            }
            else
            {

                var Categories = CategoryDAO.Instance.GetCategories();

                foreach (var category in Categories)
                {
                    cboCategoryId.Items.Add(category.CategoryName);
                }
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
