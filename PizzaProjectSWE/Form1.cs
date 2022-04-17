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
    
    public partial class Form1 : Form
    {
        List<Food> menuList = new List<Food>();
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
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Log_In logInForm = new Log_In();
            logInForm.ShowDialog();
            loadMenu();
            populateMenuGUI();
        }

        private void baseFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPizzaButton_Click(object sender, EventArgs e)
        {
            //adds items to cart
            cartBox.Items.Add(pizzaListBox.SelectedItem.ToString());
            foreach(int i in pizzaToppingListBox.SelectedIndices)
            {
                cartBox.Items.Add(pizzaToppingListBox.Items[i].ToString());
            }
            pizzaListBox.ClearSelected();
            pizzaToppingListBox.ClearSelected();
            
        }

        private void addWingButton_Click(object sender, EventArgs e)
        {
            //adds items to cart
            cartBox.Items.Add(wingListBox.SelectedItem.ToString());
            foreach(int i in wingToppings.SelectedIndices)
            {
                cartBox.Items.Add(pizzaToppingListBox.Items[i].ToString());
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
            cartBox.Items.Remove(cartBox.SelectedItem);
        }
    }
}
