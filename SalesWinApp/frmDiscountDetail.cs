using BusinessObject.Models;
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
    public partial class frmDiscountDetail : Form
    {
        public bool action { get; set; }
        IDiscountRepository discountRepository = new DiscountRepository();
        public int idToUpdate { get; set; }

        public frmDiscountDetail()
        {
            InitializeComponent();
            txtDiscountId.Enabled= false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DiscountDTO discount = new DiscountDTO()
            {
                DiscountId= idToUpdate,
                DiscountName = txtDiscountName.Text,
                Description = txtDescription.Text,
                DiscountPercent = Decimal.Parse(txtPercent.Value.ToString())
            };

            if (action == true)
            {


                discountRepository.Add(discount);
            }
            else
            {

                discountRepository.Update(discount);
            }

         
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DiscountDetail_Load(object sender, EventArgs e)
        {
            txtDiscountId.Enabled= false;
            if (!action)
            {
                DiscountDTO discount = discountRepository.GetDiscountDTO(idToUpdate);

                txtDiscountId.Text = discount.DiscountId.ToString();
                txtDiscountName.Text = discount.DiscountName;
                txtDescription.Text = discount.Description;
                if (discount.DiscountPercent.HasValue)
                {
                    txtPercent.Value = (decimal)discount.DiscountPercent;
                }
                else
                {
                    // Handle the case when DiscountPercent is null, e.g., assign a default value or show an error message.
                }
            }
        }
    }
}
