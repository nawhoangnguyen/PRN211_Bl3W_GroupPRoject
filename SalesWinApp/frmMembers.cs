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
    public partial class frmMembers : Form
    {

        IMemberRepository memberRepository = new MemberRepository();
        public bool isAdmin { get; set; }
        BindingSource source;

        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMember();
        }
        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
        }
        public void LoadMember()
        {
            try
            {
                List<MemberDTO> members = memberRepository.GetAll();

                source = new BindingSource();
                source.DataSource = members;
                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;

                if (isAdmin == false)
                {
                    if (members.Count() == 0)
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
                    if (members.Count() == 0)
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                isAdmin = this.isAdmin,
                action = true,
            };
            this.Hide();
            frmMemberDetail.ShowDialog();
            this.Close();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                isAdmin = this.isAdmin,

                action = false,
                idToUpdate = Int32.Parse(txtMemberId.Text),
            };
            this.Hide();
            frmMemberDetail.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you sure you want to delete this member ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Int32.Parse(txtMemberId.Text);
                memberRepository.Delete(id);
                LoadMember();
            }

        }

        private void frmMembers_Load_1(object sender, EventArgs e)
        {
            LoadMember();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
