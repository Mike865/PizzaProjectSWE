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
        /// <Log_In>
        /// This method initializes the form.
        /// </summary>
        public Log_In()
        {
            InitializeComponent();
        }
        /// <createAccount_Click>
        /// This method is used when the user clicks create account.
        /// It creates the createAccountForm and the shows the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAccount_Click(object sender, EventArgs e)
        {
            AccountCreation createAccountForm = new AccountCreation();
            createAccountForm.ShowDialog();
        }
        /// <guestButton_Click>
        /// This method is used if the user wants to checkout as a guest.
        /// Sets the guestCheckout bool to true in the main form.
        /// Then the form closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guestButton_Click(object sender, EventArgs e)
        {
            MenuForm.guestCheckout = true;
            DialogResult = DialogResult.Cancel;
        }
        /// <LogInButton_Click>
        /// This method is used when the user clicks the log in button.
        /// It gets the input from the userNamebox text box and the passWordBox text box. 
        /// It calls the log in method in the customerManager class and if the user exists it closes the form.
        /// If the user does not exist it shows a message saying Incorrect Input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Incorrect Input");
            }
            
        }

        
    }
}
