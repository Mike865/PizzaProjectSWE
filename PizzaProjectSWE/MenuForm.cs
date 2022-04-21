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
        List<Food> menuList = new List<Food>();
        private List<Food> currentCartItems = new List<Food>();
        public static CustomerManager customerManagerObject = new CustomerManager();
        public static bool guestCheckout { get; set; }
        
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
            menuList.Add(new Food("Pepperoni", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Sausage", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Mushroom", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Bannana Peppers", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Sardines", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Black Olives", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Pineapple", MenuCategory.PizzaTopping, 0.99));
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
        public void populateMenuGUI()
        {
            foreach (Food c in menuList)
            {
                switch(c.category)
                {
                    case MenuCategory.Pizza:
                        pizzaListBox.Items.Add(c.ToString());
                        break;
                    case MenuCategory.PizzaTopping:
                        pizzaToppingListBox.Items.Add(c.ToString());
                        break;
                    case MenuCategory.side:
                        sideListBox.Items.Add(c.ToString());
                        break;
                    case MenuCategory.sideTopping:
                        sideToppings.Items.Add(c.ToString());
                        break;
                    case MenuCategory.Drink:
                        drinkListBox.Items.Add(c.ToString());
                        break;
                }
            }
        }
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
        public MenuForm()
        {
            InitializeComponent();
        }
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

        

        private void addPizzaButton_Click(object sender, EventArgs e)
        {
            //adds items to cart
            cartBox.Items.Add(pizzaListBox.SelectedItem.ToString());
            Food currentFood = new Food();
            currentFood.category = MenuCategory.Pizza;
            currentCartItems.Add(currentFood);
            foreach(int i in pizzaToppingListBox.SelectedIndices)
            {
                Food currentTopping = new Food();
                currentTopping.category = MenuCategory.PizzaTopping;
                cartBox.Items.Add(pizzaToppingListBox.Items[i].ToString());
                currentCartItems.Add(currentTopping);
            }
            pizzaListBox.ClearSelected();
            pizzaToppingListBox.ClearSelected();
            computeTotal(cartBox);

        }

        private void addWingButton_Click(object sender, EventArgs e)
        {
            //adds items to cart
            cartBox.Items.Add(sideListBox.SelectedItem.ToString());
            Food currentFood = new Food();
            currentFood.category = MenuCategory.side;
            currentCartItems.Add(currentFood);
            foreach (int i in sideToppings.SelectedIndices)
            {
                Food currentTopping = new Food();
                currentTopping.category = MenuCategory.sideTopping;
                cartBox.Items.Add(sideToppings.Items[i].ToString());
                currentCartItems.Add(currentTopping);
            }
            computeTotal(cartBox);
            sideListBox.ClearSelected();
            sideToppings.ClearSelected();
        }

        private void addDrinkButton_Click(object sender, EventArgs e)
        {
            Food currentFood = new Food();
            currentFood.category = MenuCategory.Drink;
            currentCartItems.Add(currentFood);
            foreach (int i in drinkListBox.SelectedIndices)
            {
                cartBox.Items.Add(drinkListBox.Items[i].ToString());
            }
            computeTotal(cartBox);
            drinkListBox.ClearSelected();
        }
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

        private void pizzaToppingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

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

        private void cartBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void customerLabel_Click(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            initiateLogIn();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            Checkout checkoutForm = new Checkout();
            checkoutForm.total = computeTotal(cartBox);
            foreach(string c in cartBox.Items)
            {
                checkoutForm.theList.Add(c);
            }
            checkoutForm.ShowDialog();
        }
    }
}
