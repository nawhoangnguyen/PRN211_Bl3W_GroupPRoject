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
    public partial class frmMemberDetail : Form
    {

        IMemberRepository memberRepository = new MemberRepository();
        public bool action { get; set; }
        public int idToUpdate { get; set; }
        public bool isAdmin { get; set; }

        public frmMemberDetail()
        {
            InitializeComponent();
        }

        /*   public bool isValidateEmail()
           {

           }
           public bool isValidateField() {


           }*/


        private void btnSave_Click(object sender, EventArgs e)
        {

            MemberDTO member = new MemberDTO()
            {
                Email = txtEmail.Text,
                City = txtCity.Text,
                CompanyName = txtCompanyName.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text,

            };


            if (action == true)
            {


                memberRepository.Add(member);
            }
            else
            {
                member.MemberId = idToUpdate;
                memberRepository.Update(member);
            }
            this.Hide();
            if (isAdmin)
            {
                frmMembers frmMembers = new frmMembers()
                {
                    isAdmin = this.isAdmin
                };
                this.Close();
                frmMembers.ShowDialog();
            }
            else
            {
                frmMain frmMain = new frmMain()
                {
                    memberId = idToUpdate,
                    isAdmin = this.isAdmin

                };
                this.Close();
                frmMain.ShowDialog();
            }




        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {

            txtMemberId.Enabled = false;

            if (!action)
            {
                MemberDTO member1 = memberRepository.GetOneById(idToUpdate) as MemberDTO;

                txtMemberId.Text = member1.MemberId.ToString();
                txtCompanyName.Text = member1.CompanyName;
                txtCity.Text = member1.City;
                txtCountry.Text = member1.Country;
                txtPassword.Text = member1.Password;
                txtEmail.Text = member1.Email;

            }




        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtMemberId_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
