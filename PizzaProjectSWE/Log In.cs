using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectSWE
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }
        private void createAccount_Click(object sender, EventArgs e)
        {
            AccountCreation createAccountForm = new AccountCreation();
            createAccountForm.ShowDialog();
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            MenuForm.guestCheckout = true;
            DialogResult = DialogResult.Cancel;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text;
            string passWord = passWordBox.Text;
            if(MenuForm.customerManagerObject.LogInUserName(userName, passWord) == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect input");
            }
            
        }
    }
}
