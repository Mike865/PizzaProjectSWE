using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjectSWE
{
    /// <summary>
    ///  This class is an enum class. We are using it for constants for the menu items so we can easily identify what type of food object
    ///   We are dealing with. 
    /// </summary>

    public enum MenuCategory
    {
        Pizza, 
        PizzaTopping,
        side, 
        sideTopping,
        Drink
    }
}
