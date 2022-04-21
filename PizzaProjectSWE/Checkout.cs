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
        public double total { get; set; }
        public List<string> theList = new List<string>();
        
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            totalLabel.Text = total.ToString();
            foreach(string c in theList)
            {
                checkoutBox.Items.Add(c);
            }

        }
        

    }
}
