using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
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
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepositor = new MemberRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isAuthenticated(txtEmail.Text, txtPassword.Text))
            {
                this.Hide();
                frmMain frmMain = new frmMain()
                {
                    isAdmin = true,

                };

                frmMain.ShowDialog();
                this.Close();
            }
            else if (memberRepositor.Login(txtEmail.Text, txtPassword.Text) != null)
            {
                this.Hide();
                frmMain frmMain = new frmMain()
                {
                    isAdmin = false,
                    memberId = memberRepositor.Login(txtEmail.Text, txtPassword.Text).MemberId
                };
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

        }

        bool isAuthenticated(string email, string password)
        {
            IConfiguration config = getDefaultEmailAndPassConfig();
            string defaultEmail = config["DefaultAccount:Email"];
            string defaultPass = config["DefaultAccount:Password"];
            Console.WriteLine(defaultEmail);
            Console.WriteLine(defaultPass);

            return string.Equals(email, defaultEmail, StringComparison.OrdinalIgnoreCase) && string.Equals(password, defaultPass, StringComparison.OrdinalIgnoreCase)
                 ? true : false;
        }

        private IConfiguration getDefaultEmailAndPassConfig()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return config;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
