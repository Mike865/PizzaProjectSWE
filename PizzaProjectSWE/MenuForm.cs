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
            menuList.Add(new Food("Pepperoni", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Sausage", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Mushroom", MenuCategory.PizzaTopping, 0.99));
            menuList.Add(new Food("Buffalo Wing 6 Piece", MenuCategory.Wing, 7.99));
            menuList.Add(new Food("Blue Cheese Dressing", MenuCategory.WingSide, 1.50));
            menuList.Add(new Food("2 Liter Coke", MenuCategory.Drink, 2.99));

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
                    case MenuCategory.Wing:
                        wingListBox.Items.Add(c.ToString());
                        break;
                    case MenuCategory.WingSide:
                        wingToppings.Items.Add(c.ToString());
                        break;
                    case MenuCategory.Drink:
                        drinkListBox.Items.Add(c.ToString());
                        break;
                }
            }
        }
        public MenuForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Log_In logInForm = new Log_In();
            logInForm.ShowDialog();
            if(logInForm.DialogResult == DialogResult.OK)
            {
                customerLabel.Text = customerManagerObject.currentCustomer.Name;
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
            
        }

        private void addWingButton_Click(object sender, EventArgs e)
        {
            //adds items to cart
            cartBox.Items.Add(wingListBox.SelectedItem.ToString());
            Food currentFood = new Food();
            currentFood.category = MenuCategory.Wing;
            foreach (int i in wingToppings.SelectedIndices)
            {
                Food currentTopping = new Food();
                currentTopping.category = MenuCategory.WingSide;
                cartBox.Items.Add(wingToppings.Items[i].ToString());
                currentCartItems.Add(currentTopping);
            }
            wingListBox.ClearSelected();
            wingToppings.ClearSelected();
        }

        private void addDrinkButton_Click(object sender, EventArgs e)
        {
            //adds items to cart
            foreach (int i in drinkListBox.SelectedIndices)
            {
                cartBox.Items.Add(drinkListBox.Items[i].ToString());
            }
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
            else if (currentCartItems[cartBox.SelectedIndex].category == MenuCategory.Wing)
            {
                currentCartItems.RemoveAt(cartBox.SelectedIndex);
                cartBox.Items.Remove(cartBox.SelectedItem);
                for (int i = 0; i < currentCartItems.Count; i++)
                {
                    if (currentCartItems[i].category == MenuCategory.WingSide)
                    {
                        cartBox.Items.RemoveAt(i);
                        currentCartItems.RemoveAt(i);
                        i--;
                    }
                }
            }
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
            if (wingListBox.SelectedItems.Count > 0)
            {
                wingToppings.Enabled = true;
            }
            else
            {
                wingToppings.Enabled = false;
            }
        }
    }
}
