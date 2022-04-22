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
    
    public partial class MenuForm : Form
    {
        //menuList is a list of every food item on our menu.
        List<Food> menuList = new List<Food>();
        /// <summary>
        ///currentCartItems is a list of Food that is parallel to what is inside of the cartBox list box.
        /// We have to use this because when we put items into a list box they become strings. 
        ///The currentCartItems list allows us to identify if we need to delete the toppings are sides assosiacted with that Food object.
        /// </summary>

        internal List<Food> currentCartItems = new List<Food>();
        private bool DEBUG_CHECKOUT = false;
        /// <summary>
        /// This static customerManagerObject allows us to access all the methods inside of the class from any form. 
        /// </summary>
        public static CustomerManager customerManagerObject = new CustomerManager();
        /// <summary>
        /// guestCheckout is a static bool that allows us to check if the user selected to checkout as a guest instead of.
        /// Creating an account or logging into a current account.
        /// </summary>
        public static bool guestCheckout { get; set; }
        
        /// <summary>
        /// The region below hides the loadMenu method.
        /// This menu hard codes each item into the menuList so we can display it to the users.
        /// </summary>

        #region
        public void loadMenu()
        {
            menuList.Add(new Food("Small Cheese", MenuCategory.Pizza, 8.99));
            menuList.Add(new Food("Small Pepporoni", MenuCategory.Pizza, 9.99));
            menuList.Add(new Food("Small Supreme", MenuCategory.Pizza, 12.99));
            menuList.Add(new Food("Medium Cheese", MenuCategory.Pizza, 12.99));
            menuList.Add(new Food("Medium Pepporoni", MenuCategory.Pizza, 13.99));
            menuList.Add(new Food("Medium Supreme", MenuCategory.Pizza, 14.99));
            menuList.Add(new Food("Large Cheese", MenuCategory.Pizza, 16.99));
            menuList.Add(new Food("Large Pepporoni", MenuCategory.Pizza, 17.99));
            menuList.Add(new Food("Large Supreme", MenuCategory.Pizza, 19.99));
            menuList.Add(new Food("Extra Large Cheese", MenuCategory.Pizza, 21.99));
            menuList.Add(new Food("Extra Large Pepporoni", MenuCategory.Pizza, 22.99));
            menuList.Add(new Food("Extra Large Supreme", MenuCategory.Pizza, 25.99));
            menuList.Add(new Food("Brooklyn Style Crust", MenuCategory.PizzaTopping, 2.50));
            menuList.Add(new Food("Hand Tossed Crust", MenuCategory.PizzaTopping, 1.50));
            menuList.Add(new Food("Thin Crust", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Pan Pizza Crust", MenuCategory.PizzaTopping, 3.50));
            menuList.Add(new Food("Pepperoni", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Sausage", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Mushroom", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Bannana Peppers", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Sardines", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Black Olives", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Pineapple", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Extra Cheese", MenuCategory.PizzaTopping, 2.99));
            menuList.Add(new Food("Philly Steak", MenuCategory.PizzaTopping, 1.99));
            menuList.Add(new Food("Salami", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Beef", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Italian Sausage", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Buffalo Wing 6 Piece", MenuCategory.side, 7.99));
            menuList.Add(new Food("Lemon Pepper Wing 6 Piece", MenuCategory.side, 7.99));
            menuList.Add(new Food("Barbecue Wing 6 Piece", MenuCategory.side, 7.99));
            menuList.Add(new Food("Buffalo Wing 12 Piece", MenuCategory.side, 12.99));
            menuList.Add(new Food("Lemon Pepper Wing 12 Piece", MenuCategory.side, 12.99));
            menuList.Add(new Food("Barbecue Wing 12 Piece", MenuCategory.side, 7.99));
            menuList.Add(new Food("Buffalo Wing 25 Piece", MenuCategory.side, 21.99));
            menuList.Add(new Food("Lemon Pepper Wing 25 Piece", MenuCategory.side, 21.99));
            menuList.Add(new Food("Barbecue Wing 25 Piece", MenuCategory.side, 21.99));
            menuList.Add(new Food("Garlic Knots 4 Peice", MenuCategory.sideTopping, 6.99));
            menuList.Add(new Food("Bread Sticks", MenuCategory.sideTopping, 6.99));
            menuList.Add(new Food("Pretzel Twists", MenuCategory.sideTopping, 3.50));
            menuList.Add(new Food("Blue Cheese Dressing", MenuCategory.sideTopping, 1.50));
            menuList.Add(new Food("Ranch Dressing", MenuCategory.sideTopping, 1.50));
            menuList.Add(new Food("Honey Mustard", MenuCategory.sideTopping, 1.50));
            menuList.Add(new Food("Ceasar Salad Dressing", MenuCategory.sideTopping, 2.50));
            menuList.Add(new Food("Marinara Sauce", MenuCategory.sideTopping, 1.50));
            menuList.Add(new Food("Garlic Sauce", MenuCategory.sideTopping, 1.50));
            menuList.Add(new Food("16oz Coke", MenuCategory.Drink, 0.99));
            menuList.Add(new Food("16oz Dr.Pepper", MenuCategory.Drink, 0.99));
            menuList.Add(new Food("16oz Moutian Dew", MenuCategory.Drink, 0.99));
            menuList.Add(new Food("16oz Sprite", MenuCategory.Drink, 0.99));
            menuList.Add(new Food("16oz Coke Zero", MenuCategory.Drink, 0.99));
            menuList.Add(new Food("16oz Diet Coke", MenuCategory.Drink, 0.99));
            menuList.Add(new Food("16oz Root Beer", MenuCategory.Drink, 0.99));
            menuList.Add(new Food("16oz Sweet Tea", MenuCategory.Drink, 0.99));
            menuList.Add(new Food("32oz Coke", MenuCategory.Drink, 1.99));
            menuList.Add(new Food("32oz Dr.Pepper", MenuCategory.Drink, 1.99));
            menuList.Add(new Food("32oz Sprite", MenuCategory.Drink, 1.99));
            menuList.Add(new Food("32oz Coke Zero", MenuCategory.Drink, 1.99));
            menuList.Add(new Food("32oz Diet Coke", MenuCategory.Drink, 1.99));
            menuList.Add(new Food("32oz Root Beer", MenuCategory.Drink, 1.99));
            menuList.Add(new Food("32oz Sweet Tea", MenuCategory.Drink, 1.99));
            menuList.Add(new Food("2 Liter Coke", MenuCategory.Drink, 2.99));
            menuList.Add(new Food("2 Liter Dr.Pepper", MenuCategory.Drink, 2.99));
            menuList.Add(new Food("2 Liter Moutian Dew", MenuCategory.Drink, 2.99));
            menuList.Add(new Food("2 Liter Sprite", MenuCategory.Drink, 2.99));
            menuList.Add(new Food("2 Liter Coke Zero", MenuCategory.Drink, 2.99));
            menuList.Add(new Food("2 Liter Diet Coke", MenuCategory.Drink, 2.99));
            menuList.Add(new Food("2 Liter Root Beer", MenuCategory.Drink, 2.99));
            menuList.Add(new Food("Gallon Sweet Tea", MenuCategory.Drink, 3.99));
        }
        #endregion
        /// <Populate Menu>
        /// This method is used to put the Food object's toString's into the list boxes
        /// </summary>
        public void populateMenuGUI()
        {
            if (DEBUG_CHECKOUT)
            {
                customerManagerObject.addCustomer("name", "1", "2", "p", "u");
                customerManagerObject.currentCustomer = customerManagerObject.GetCustomerObj(1);
            }
            pizzaListBox.DisplayMember = "displayMember";
            pizzaToppingListBox.DisplayMember = "displayMember";
            sideListBox.DisplayMember = "displayMember";
            sideToppings.DisplayMember = "displayMember";
            foreach (Food c in menuList)
            {
                switch(c.category)
                {
                    case MenuCategory.Pizza:
                        pizzaListBox.Items.Add(c);
                        break;
                    case MenuCategory.PizzaTopping:
                        pizzaToppingListBox.Items.Add(c);
                        break;
                    case MenuCategory.side:
                        sideListBox.Items.Add(c);
                        break;
                    case MenuCategory.sideTopping:
                        sideToppings.Items.Add(c);
                        break;
                    case MenuCategory.Drink:
                        drinkListBox.Items.Add(c);
                        break;
                }
            }
        }
       /// <computePrice>
       /// compute price takes in a string from the cartBox and then uses the list of currentCartItems 
       /// to compare and confirm the price of the item.
       /// This method is a helper method and it helps computeTotal.
       /// </summary>
       /// <param name="theItem"></param>
       /// <returns></returns>
        public double computePrice(string theItem)
        {
            double total = 0;
            foreach(Food c in menuList)
            {
                if(theItem == "    $" + c.cost + " " + c.description)
                {
                    total = c.cost;
                }
                else if(theItem == "    $" + c.cost + " " + c.description)
                {
                    total = c.cost;
                }
                else if(theItem == "$" + c.cost + " " + c.description)
                {
                    total = c.cost;
                }
            }
            return total;
        }

        public double computeTotal(List<Food> cart)
        {
            double total = 0;
            foreach(Food f in cart)
            {
                total += f.cost;
            }
            return total;
        }
        /// <computeTotal>
        /// This method computes the total for all items in the theCart listbox.
        /// It takes in the theCart listbox and calls the helper method compute price to compute the total price of each item in the cart.
        /// </summary>
        /// <param name="theCart"></param>
        /// <returns></returns>
        public double computeTotal(ListBox theCart)
        {
            double orderTotal = 0;
            foreach(string c in theCart.Items)
            {
                orderTotal += computePrice(c);
            }
            totalLabel.Text = orderTotal.ToString();
            return orderTotal;
        }
        /// <menuForm>
        /// This initializes the form.
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
        }
        /// <initiateLogIn>
        /// This method is used to create the log in form so that the user can choose to
        /// checkout as a guest, create an account, or log in to an existing account.
        /// </summary>
        public void initiateLogIn()
        {
            Log_In logInForm = new Log_In();
            logInForm.ShowDialog();
            if (logInForm.DialogResult == DialogResult.OK)
            {
                customerLabel.Text = customerManagerObject.currentCustomer.Name;
                logInButton.Enabled = false;
            }
        }
        /// <form1_load>
        /// This was the original name of the MenuForm.
        /// This event loads the form and creates the logInForm so the user can log in etc.
        /// This method also sets the customerLabel to the name of the logged in user.
        /// This method also calls loadMenu and populateMenuGUI to load the menu and display it to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Log_In logInForm = new Log_In();
            logInForm.ShowDialog();
            if(logInForm.DialogResult == DialogResult.OK)
            {
                customerLabel.Text = customerManagerObject.currentCustomer.Name;
                logInButton.Enabled = false;
            }
            loadMenu();
            populateMenuGUI();
        }
        /// <addPizzaButton_Click>
        /// This method is used when the add pizza button is clicked.
        /// This is where we use currentCartItems list to add items as well as adding them to the cart box.
        /// after adding it clears the options for the pizzaListBox and the pizzaToppingListBox
        /// Then it computes the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPizzaButton_Click(object sender, EventArgs e)
        {
            cartBox.Items.Add(pizzaListBox.SelectedItem.ToString());
            currentCartItems.Add((Food)pizzaListBox.SelectedItem);
            foreach(int i in pizzaToppingListBox.SelectedIndices)
            {
                cartBox.Items.Add(pizzaToppingListBox.Items[i].ToString());
                currentCartItems.Add((Food)pizzaToppingListBox.Items[i]);
            }
            pizzaListBox.ClearSelected();
            pizzaToppingListBox.ClearSelected();
            computeTotal(cartBox);

        }
        /// <addWingButton_Click>
        /// This method is used when the add side button is clicked.
        /// This method was originally for wings but we changed it to sides.
        /// This is where we use currentCartItems list to add items as well as adding them to the cart box.
        /// after adding it clears the options for the sideListBox and the sideToppingListBox
        /// Then it computes the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addWingButton_Click(object sender, EventArgs e)
        {
            cartBox.Items.Add(sideListBox.SelectedItem.ToString());
            currentCartItems.Add((Food) sideListBox.SelectedItem);
            foreach (int i in sideToppings.SelectedIndices)
            {
                cartBox.Items.Add(sideToppings.Items[i].ToString());
                currentCartItems.Add((Food)sideToppings.Items[i]);
            }
            computeTotal(cartBox);
            sideListBox.ClearSelected();
            sideToppings.ClearSelected();
        }
        /// <addDrinkButton_Click>
        /// This method is used when the add drink button is clicked.
        /// This is where we use currentCartItems list to add items as well as adding them to the cart box.
        /// after adding it clears the options for the drinkListBox
        /// Then it computes the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDrinkButton_Click(object sender, EventArgs e)
        {

            //currentCartItems.Add(currentFood);
            foreach (int i in drinkListBox.SelectedIndices)
            {
                cartBox.Items.Add(drinkListBox.Items[i].ToString());
                currentCartItems.Add((Food) drinkListBox.Items[i]);
            }
            computeTotal(cartBox);
            drinkListBox.ClearSelected();
        }
        /// <deleteButton_Click>
        /// This method is used to delete items out of the cartBox list box.
        /// It removes the item at the selected index in the cartBox and in the currentCartItems list to keep them in sync.
        /// After deleteing the base item it foreach's through and deletes all the toppings assoicated with the original base item.
        /// It also updates the currentCartList to keep them in sync.
        /// At the end it calls compute total to keep the total accurate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentCartItems[cartBox.SelectedIndex].category == MenuCategory.Pizza)
            {
                currentCartItems.RemoveAt(cartBox.SelectedIndex);
                cartBox.Items.Remove(cartBox.SelectedItem);
                for (int i = 0; i < currentCartItems.Count; i++)
                {
                    if (currentCartItems[i].category == MenuCategory.PizzaTopping)
                    {
                        cartBox.Items.RemoveAt(i);
                        currentCartItems.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (currentCartItems[cartBox.SelectedIndex].category == MenuCategory.side)
            {
                currentCartItems.RemoveAt(cartBox.SelectedIndex);
                cartBox.Items.Remove(cartBox.SelectedItem);
                for (int i = 0; i < currentCartItems.Count; i++)
                {
                    if (currentCartItems[i].category == MenuCategory.sideTopping)
                    {
                        cartBox.Items.RemoveAt(i);
                        currentCartItems.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (currentCartItems[cartBox.SelectedIndex].category == MenuCategory.Drink)
            {
                currentCartItems.RemoveAt(cartBox.SelectedIndex);
                cartBox.Items.Remove(cartBox.SelectedItem);
            }
            computeTotal(cartBox);
        }
        /// <pizzaListBox_SelectedIndexChanged>
        /// This event allows enables the topping list box if the customer selects a base pizza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pizzaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pizzaListBox.SelectedItems.Count > 0)
            {
                pizzaToppingListBox.Enabled = true;
            }
            else
            {
                pizzaToppingListBox.Enabled = false;
            }
        }
        /// <wingListBox_SelectedIndexChanged>
        /// This event allows enables the side toppings list box if the customer selects a base side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sideListBox.SelectedItems.Count > 0)
            {
                sideToppings.Enabled = true;
            }
            else
            {
                sideToppings.Enabled = false;
            }
        }
        /// <logInButton_Click>
        /// This method is used when logInButton is clicked.
        /// It allows the user to log in if they selected checkout as guest but changed their mind.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logInButton_Click(object sender, EventArgs e)
        {
            initiateLogIn();
        }
        /// <checkoutButton_Click>
        /// This method is used to create the checkoutForm when the customer is ready to check out. 
        /// It sets the attributes in the form, and then clears the cartbox and resets the total when the user confirms checkout. 
        /// If they cancel checkout it saves their current cart so they can continue to add or remove items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            customerManagerObject.currentCustomer.CheckOut(currentCartItems);
            if (DEBUG_CHECKOUT)
            {
                Console.Write(customerManagerObject.currentCustomer.GetJson());
            }
            Checkout checkoutForm = new Checkout();
            checkoutForm.total = computeTotal(currentCartItems);
            foreach (string c in cartBox.Items)
            {
                checkoutForm.theListOfCurrentFoodItems.Add(c);
            }
            checkoutForm.ShowDialog();
            if (checkoutForm.DialogResult == DialogResult.OK)
            {
                cartBox.Items.Clear();
            }

            computeTotal(currentCartItems);
        }
    }
}
