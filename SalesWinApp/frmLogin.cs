using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private bool IsValidGmailAddress(string email)
        {
            // Gmail address pattern
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Test the email against the pattern
            return regex.IsMatch(email);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = IsValidGmailAddress(txtEmail.Text);

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
                    if (!isValid)
                    {
                        MessageBox.Show("Invalid Gmail !!");
                        return;
                    }
                    ShoppingSessionDTO shoppingSession = ShoppingSessionDAO.Instance.GetShoppingSessionByUserId(memberRepositor.Login(txtEmail.Text, txtPassword.Text).MemberId);
                    if (shoppingSession == null)
                    {
                        shoppingSession = new ShoppingSessionDTO()
                        {
                            MemberId = memberRepositor.Login(txtEmail.Text, txtPassword.Text).MemberId,
                            Total = 0,
                        };
                        ShoppingSessionDAO.Instance.Add(shoppingSession);

                    }

                    frmMain frmMain = new frmMain()
                    {
                        isAdmin = false,
                        memberId = memberRepositor.Login(txtEmail.Text, txtPassword.Text).MemberId,
                        shoppingSession = shoppingSession
                    };
                    frmMain.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Login Failed!");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        bool isAuthenticated(string email, string password)
        {
            IConfiguration config = getDefaultEmailAndPassConfig();
            string defaultEmail = config["DefaultAccount:Email"];
            string defaultPass = config["DefaultAccount:Password"];
 

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
