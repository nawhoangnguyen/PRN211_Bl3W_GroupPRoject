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
    public partial class frmDiscount : Form
    {
        IDiscountRepository discountRepository = new DiscountRepository();
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public bool isAdmin { get; set; }

        public int memberId { get; set; }

        public frmDiscount()
        {
            InitializeComponent();
        }

        public void LoadDiscount(List<DiscountDTO> discountDTOs)
        {
            try
            {
                txtID.Enabled = false;
                txtName.Enabled = false;
                txtDescript.Enabled = false;
                txtPercent.Enabled = false;
                List<DiscountDTO> discounts = new List<DiscountDTO>();
                if (discountDTOs.IsNullOrEmpty())
                {
                    discounts = discountRepository.GetAll();

                }
                else
                {
                    discounts = discountDTOs;
                }

                source = new BindingSource();
                source.DataSource = discounts;
                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescript.DataBindings.Clear();
                txtPercent.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "DiscountId");
                txtName.DataBindings.Add("Text", source, "DiscountName");
                txtDescript.DataBindings.Add("Text", source, "Description");
                txtPercent.DataBindings.Add("Text", source, "DiscountPercent");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;

                dataGridView1.Columns["Products"].Visible = false;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtDescript.Enabled = false;
            txtPercent.Enabled = false;

            LoadDiscount(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDiscountDetail frm = new frmDiscountDetail()
            {
                action = false,
                idToUpdate = Int32.Parse(txtID.Text)

            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDiscount(null);
                source.Position = source.Count - 1;
            }
            LoadDiscount(null);
            source.Position = source.Count - 1;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDiscountDetail frm = new frmDiscountDetail()
            {
                action = true

            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDiscount(null);
                source.Position = source.Count - 1;
            }
            LoadDiscount(null);
            source.Position = source.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you sure you want to delete this discount ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                discountRepository.Delete(Int32.Parse(txtID.Text));
                LoadDiscount(null);
            }
        }
    }
}
