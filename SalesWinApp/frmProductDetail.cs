using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            ProductDTO product = new ProductDTO()
            {
                CategoryId = Int32.Parse(txtCategoryId.Text),
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
            this.Close();
              




        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = false;

            if (!action)
            {
                ProductDTO product = productRepository.GetOneById(idToUpdate);

                txtProductId.Text = product.ProductId.ToString();
                txtCategoryId.Text = product.CategoryId.ToString();
                txtProductName.Text = product.ProductName;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtUnitsInStock.Text = product.UnitsInStock.ToString();
                txtWeight.Text = product.Weight;

            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
