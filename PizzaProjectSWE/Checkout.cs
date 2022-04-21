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
    public partial class Checkout : Form
    {
        /// <Total>
        /// The total Attribute holds the current total of the order.
        /// </summary>
        public double total { get; set; }
        /// <theListOfCurrentFoodItems>
        /// This list is used to hold the values from the cartBox and later put them into the checkout listbox
        /// </summary>
        public List<string> theListOfCurrentFoodItems = new List<string>();
        /// <Checkout>
        /// This initializes the form. 
        /// </summary>
        public Checkout()
        {
            InitializeComponent();
        }
        /// <Checkout_Load>
        /// This method checks if the user is a guest or a logged in user and enables the existing card button if they are an existing customer.
        /// It also sets the totalLabel to the value of the total variable.
        /// It then uses the listofCurrentFoodItems to populate the checkoutBox list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkout_Load(object sender, EventArgs e)
        {
            if (MenuForm.guestCheckout == false)
            {
                existingCardButton.Enabled = true;
            }
            totalLabel.Text = total.ToString();
            foreach (string c in theListOfCurrentFoodItems)
            {
                checkoutBox.Items.Add(c);
            }

        }
        /// <cancelButton_Click>
        /// This method closes the form if the user decides not to checkout.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        /// <carryOutOrder>
        /// This method is used to check if the user wants to carry out the order.
        /// </summary>
        /// <returns></returns>
        public bool carryOutOrder()
        {
            if (carryOutRadioButton.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <deliveryOrder>
        /// This method is used if the customer wants to have the order delivered.
        /// </summary>
        /// <returns></returns>
        public bool deliveryOrder()
        {
            if (deliveryRadio.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <cashPayment>
        /// This method checks if the user wants to pay with cash
        /// </summary>
        /// <returns></returns>
        public bool cashPayment()
        {
            if (cashRadioButton.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <checkPayment>
        /// This method checks if the user wants to pay wih check.
        /// </summary>
        /// <returns></returns>
        public bool checkPayment()
        {
            if (checkRadioButton.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <CardOnFile>
        /// This method checks if the user wants to pay with an existing card.
        /// </summary>
        /// <returns></returns>
        public bool cardOnFile()
        {
            if (existingCardButton.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <otherCard>
        /// This method checks if the user wants to pay with a card not on file.
        /// </summary>
        /// <returns></returns>
        public bool otherCard()
        {
            if (otherDebitRadio.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <orderType>
        /// This method confirms which order type the user selected and returns which type of payment they selected.
        /// </summary>
        /// <returns></returns>
        public string orderType()
        {
            if (cashRadioButton.Checked == true)
            {
                return "Cash";
            }
            else if (checkRadioButton.Checked == true)
            {
                return "Check";
            }
            else if (otherDebitRadio.Checked == true)
            {
                return "Other Card";
            }
            else if (existingCardButton.Checked == true)
            {
                return "Existing Card";
            }
            else
            {
                return "NOT SELECTED";
            }
        }
        /// <confirmCheckoutButton_Click>
        /// This method finalized the order.
        /// It checks if they want carryout or delivery.
        /// Then depending on if they are logged in or a guest
        /// it gives shows a message box if the order was successfully placed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmCheckoutButton_Click(object sender, EventArgs e)
        {
            bool delivery = deliveryOrder();
            bool carryOut = carryOutOrder();

            if (MenuForm.guestCheckout == true)
            {
                if (delivery == true)
                {
                    if (orderType() == "NOT SELECTED")
                    {
                        MessageBox.Show("You must select orderType");
                    }
                    else
                    {
                        string selection = orderType();
                        MessageBox.Show("Thank you guest the order has been successfully placed with payment type, " + orderType() + " the order total is: " + totalLabel.Text + " you selected delivery");
                        DialogResult = DialogResult.OK;
                    }
                }
                else if (carryOut == true)
                {
                    if (orderType() == "NOT SELECTED")
                    {
                        MessageBox.Show("You must select orderType");
                    }
                    else
                    {
                        string selection = orderType();
                        MessageBox.Show("Thank you guest the order has been successfully placed with payment type, " + orderType() + " the order total is: " + totalLabel.Text + " you selected carry out");
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("You must choose a delivery type");
                }
            }
            else if (MenuForm.guestCheckout == false)
            {
                if (delivery == true)
                {
                    if (orderType() == "NOT SELECTED")
                    {
                        MessageBox.Show("You must select orderType");
                    }
                    else
                    {
                        string selection = orderType();
                        MessageBox.Show("Thank you " + MenuForm.customerManagerObject.currentCustomer.Name + ", the order has been successfully placed with payment type," + orderType() + " the order total is: " + totalLabel.Text + " you selected carry out");
                        DialogResult = DialogResult.OK;
                    }
                }
                else if (carryOut == true)
                {
                    if (orderType() == "NOT SELECTED")
                    {
                        MessageBox.Show("You must select orderType");
                    }
                    else
                    {
                        string selection = orderType();
                        MessageBox.Show("Thank you " + MenuForm.customerManagerObject.currentCustomer.Name + ", the order has been successfully placed with payment type," + orderType() + " the order total is: " + totalLabel.Text + " you selected delivery");
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox.Show("You must choose a delivery type");
            }
        }
    }
}
       

            



           
       
       
