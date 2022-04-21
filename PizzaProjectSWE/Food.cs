using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjectSWE
{
    public class Food
    {
        
        /// <listOfToppings>
        /// listOfToppings is used to hold the toppings the user selects.
        /// </summary>
        private List<Food> listOfToppings = new List<Food>();
        /// <description>
        /// description holds the string for the description of the food.
        /// </summary>
        public string description;
        /// <Category>
        /// Holds the type of menu category for the object.
        /// </summary>
        public MenuCategory category;
        /// <cost>
        /// Holds the cost of the food object.
        /// </summary>
        public double cost;
        /// <Food>
        /// Allows us to create an empty food object.
        /// </summary>
        public Food()
        {

        }
        /// <Food overidden>
        /// Allows us to create a food object with inputted variables.
        /// </summary>
        /// <param name="theDescription"></param>
        /// <param name="theCategory"></param>
        /// <param name="theCost"></param>
        public Food(string theDescription, MenuCategory theCategory, double theCost)
        {
            description = theDescription;
            category = theCategory;
            cost = theCost;
        }
        /// <toString overridden>
        /// Allows us to display the cost and description of the food object in a listbox.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(category == MenuCategory.PizzaTopping)
            {
                return "    $" + cost + " " + description;
            }
            else if(category == MenuCategory.sideTopping)
            {
                return "    $" + cost + " " + description;
            }
            return "$"+ cost + " "+ description;
        }
        

    }
}
