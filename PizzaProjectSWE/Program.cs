using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectSWE
{
    //Hello from comment
    static class Program
    {
        /*
         * 4 Distinct pizzas
         * 8 distinct toppings with combinations of up to 4 items
         * 3 crust options
         * 5 beverages
         * 3 distinct beverage sizes
         * Displaying the pricing of various itmes
         * A display screen for the completed order showing items ordered the prices and totals
         */
        // Saving file
         /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
