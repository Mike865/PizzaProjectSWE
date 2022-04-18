using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjectSWE
{
    public class Food
    {
        
        //List for toppings
        private List<Food> listOfToppings = new List<Food>();
        //Food attributes
        public string description;
        public MenuCategory category;
        public double cost;
        //Food constructor.
        public Food(string theDescription, MenuCategory theCategory, double theCost)
        {
            description = theDescription;
            category = theCategory;
            cost = theCost;
        }
        //method to add food to list
        public override string ToString()
        {
            if(category == MenuCategory.PizzaTopping)
            {
                return "    $" + cost + " " + description;
            }
            else if(category == MenuCategory.WingSide)
            {
                return "    $" + cost + " " + description;
            }
            return "$"+ cost + " " + description;
        }
        

    }
}
