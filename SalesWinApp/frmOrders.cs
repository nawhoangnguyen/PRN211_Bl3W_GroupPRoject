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
    public partial class frmOrders : Form
    {


        IOrderRepository orderRepository = new OrderRepository();
        public bool isAdmin { get; set; }
        public int memberId { get; set; }

        BindingSource source;
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        public frmOrders()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<OrderDTO> orderList = new List<OrderDTO>();
            if (memberId > 0)
            {
                orderList = orderRepository.FilterOrder(dtpFrom.Value, dtpTo.Value, memberId);

            }
            else
            {
                orderList = orderRepository.FilterOrder(dtpFrom.Value, dtpTo.Value, 0);
            }



            source = new BindingSource();
            source.DataSource = orderList;
            txtMemberId.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtOrderId.DataBindings.Clear();
            txtRequriedDate.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtFreight.DataBindings.Clear();


            txtFreight.DataBindings.Add("Text", source, "Freight");
            txtMemberId.DataBindings.Add("Text", source, "MemberId");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtOrderId.DataBindings.Add("Text", source, "OrderId");
            txtRequriedDate.DataBindings.Add("Text", source, "RequiredDate");
            txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
            if (orderList.Count() == 0)
            {
                ClearText();
                btnView.Enabled = false;
            }
            else
            {
                btnView.Enabled = true;
            }





            txtOrderId.Enabled = false;
            txtMemberId.Enabled = false;
            txtOrderDate.Enabled = false;
            txtRequriedDate.Enabled = false;
            txtShippedDate.Enabled = false;
            txtFreight.Enabled = false;
        }

        private void ClearText()
        {
            txtFreight.Text = string.Empty;
            txtMemberId.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtOrderId.Text = string.Empty;
            txtRequriedDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;

        }
        public void LoadOrder()
        {
            try
            {
                List<OrderDTO> orders = new List<OrderDTO>();
                if (isAdmin)
                {
                    orders = orderRepository.GetAll();

                }
                else
                {
                    orders = orderRepository.GetOrdersByUserId(memberId);
                }

                source = new BindingSource();
                source.DataSource = orders;
                txtMemberId.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtOrderId.DataBindings.Clear();
                txtRequriedDate.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();


                txtFreight.DataBindings.Add("Text", source, "Freight");
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtOrderId.DataBindings.Add("Text", source, "OrderId");
                txtRequriedDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;

                dataGridView1.Columns["RequiredDate"].Visible = false;
                dataGridView1.Columns["ShippedDate"].Visible = false;
                dataGridView1.Columns["Freight"].Visible = false;
                dataGridView1.Columns["Member"].Visible = false;
                dataGridView1.Columns["OrderDetails"].Visible = false;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            OrderDetailDTO orderDetail = orderDetailRepository.FindOrderDetailByOrderId(Int32.Parse(txtOrderId.Text));
            source = new BindingSource();
            source.DataSource = orderDetail;

            txtOrderIdDe.DataBindings.Clear();
            txtProductIdDe.DataBindings.Clear();
            txtDiscountDe.DataBindings.Clear();
            txtUnitPriceDe.DataBindings.Clear();
            txtQuantityDe.DataBindings.Clear();

            txtOrderIdDe.DataBindings.Add("Text", source, "OrderId");
            txtProductIdDe.DataBindings.Add("Text", source, "ProductId");
            txtDiscountDe.DataBindings.Add("Text", source, "Discount");
            txtUnitPriceDe.DataBindings.Add("Text", source, "UnitPrice");
            txtQuantityDe.DataBindings.Add("Text", source, "Quantity");

            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = source;

            if (orderDetail == null)
            {
                ClearText();
            }

            txtOrderIdDe.Enabled = false;
            txtProductIdDe.Enabled = false;
            txtDiscountDe.Enabled = false;
            txtUnitPriceDe.Enabled = false;
            txtQuantityDe.Enabled = false;
        }
    }
}
