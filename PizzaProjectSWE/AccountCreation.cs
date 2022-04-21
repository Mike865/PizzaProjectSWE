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
    public partial class AccountCreation : Form
    {
        public AccountCreation()
        {
            InitializeComponent();
        }
        /// <createAccountButton_Click>
        /// This method collects the information needed to create the customers account.
        /// Once finished it reports dialogresult is ok and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            MenuForm.customerManagerObject.addCustomer(nameTextBox.Text, addressTextBox.Text, phoneNumberTextBox.Text, PasswordTextBox.Text, usernameTextBox.Text);
            DialogResult = DialogResult.OK;
        }
        /// <cancelButton_Click>
        /// This method is used if the cancel button is clicked.
        /// This allows the user to stop creating an account and go back to the log in screen to make another choice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
