
namespace PizzaProjectSWE
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pizzaListBox = new System.Windows.Forms.ListBox();
            this.pizzaBox = new System.Windows.Forms.GroupBox();
            this.addPizzaButton = new System.Windows.Forms.Button();
            this.pizzaToppingListBox = new System.Windows.Forms.ListBox();
            this.wingBox = new System.Windows.Forms.GroupBox();
            this.addSideButton = new System.Windows.Forms.Button();
            this.sideToppings = new System.Windows.Forms.ListBox();
            this.sideListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cartBox = new System.Windows.Forms.ListBox();
            this.drinkBox = new System.Windows.Forms.GroupBox();
            this.addDrinkButton = new System.Windows.Forms.Button();
            this.drinkListBox = new System.Windows.Forms.ListBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.pizzaBox.SuspendLayout();
            this.wingBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.drinkBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaListBox
            // 
            this.pizzaListBox.FormattingEnabled = true;
            this.pizzaListBox.ItemHeight = 16;
            this.pizzaListBox.Location = new System.Drawing.Point(8, 62);
            this.pizzaListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pizzaListBox.Name = "pizzaListBox";
            this.pizzaListBox.Size = new System.Drawing.Size(254, 196);
            this.pizzaListBox.TabIndex = 0;
            this.pizzaListBox.SelectedIndexChanged += new System.EventHandler(this.pizzaListBox_SelectedIndexChanged);
            // 
            // pizzaBox
            // 
            this.pizzaBox.Controls.Add(this.addPizzaButton);
            this.pizzaBox.Controls.Add(this.pizzaToppingListBox);
            this.pizzaBox.Controls.Add(this.pizzaListBox);
            this.pizzaBox.Location = new System.Drawing.Point(16, 15);
            this.pizzaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pizzaBox.Name = "pizzaBox";
            this.pizzaBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pizzaBox.Size = new System.Drawing.Size(619, 318);
            this.pizzaBox.TabIndex = 1;
            this.pizzaBox.TabStop = false;
            this.pizzaBox.Text = "Pizza Selection";
            // 
            // addPizzaButton
            // 
            this.addPizzaButton.Location = new System.Drawing.Point(8, 268);
            this.addPizzaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPizzaButton.Name = "addPizzaButton";
            this.addPizzaButton.Size = new System.Drawing.Size(100, 28);
            this.addPizzaButton.TabIndex = 2;
            this.addPizzaButton.Text = "Add To Cart";
            this.addPizzaButton.UseVisualStyleBackColor = true;
            this.addPizzaButton.Click += new System.EventHandler(this.addPizzaButton_Click);
            // 
            // pizzaToppingListBox
            // 
            this.pizzaToppingListBox.Enabled = false;
            this.pizzaToppingListBox.FormattingEnabled = true;
            this.pizzaToppingListBox.ItemHeight = 16;
            this.pizzaToppingListBox.Location = new System.Drawing.Point(299, 64);
            this.pizzaToppingListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pizzaToppingListBox.Name = "pizzaToppingListBox";
            this.pizzaToppingListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pizzaToppingListBox.Size = new System.Drawing.Size(243, 196);
            this.pizzaToppingListBox.TabIndex = 1;
            this.pizzaToppingListBox.SelectedIndexChanged += new System.EventHandler(this.pizzaToppingListBox_SelectedIndexChanged);
            // 
            // wingBox
            // 
            this.wingBox.Controls.Add(this.addSideButton);
            this.wingBox.Controls.Add(this.sideToppings);
            this.wingBox.Controls.Add(this.sideListBox);
            this.wingBox.Location = new System.Drawing.Point(16, 340);
            this.wingBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wingBox.Name = "wingBox";
            this.wingBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wingBox.Size = new System.Drawing.Size(619, 228);
            this.wingBox.TabIndex = 2;
            this.wingBox.TabStop = false;
            this.wingBox.Text = "Side Selection";
            // 
            // addSideButton
            // 
            this.addSideButton.Location = new System.Drawing.Point(8, 192);
            this.addSideButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSideButton.Name = "addSideButton";
            this.addSideButton.Size = new System.Drawing.Size(100, 28);
            this.addSideButton.TabIndex = 2;
            this.addSideButton.Text = "Add To Cart";
            this.addSideButton.UseVisualStyleBackColor = true;
            this.addSideButton.Click += new System.EventHandler(this.addWingButton_Click);
            // 
            // sideToppings
            // 
            this.sideToppings.Enabled = false;
            this.sideToppings.FormattingEnabled = true;
            this.sideToppings.ItemHeight = 16;
            this.sideToppings.Location = new System.Drawing.Point(299, 53);
            this.sideToppings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideToppings.Name = "sideToppings";
            this.sideToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sideToppings.Size = new System.Drawing.Size(243, 116);
            this.sideToppings.TabIndex = 1;
            // 
            // sideListBox
            // 
            this.sideListBox.FormattingEnabled = true;
            this.sideListBox.ItemHeight = 16;
            this.sideListBox.Location = new System.Drawing.Point(8, 53);
            this.sideListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideListBox.Name = "sideListBox";
            this.sideListBox.Size = new System.Drawing.Size(254, 116);
            this.sideListBox.TabIndex = 0;
            this.sideListBox.SelectedIndexChanged += new System.EventHandler(this.wingListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkoutButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.cartBox);
            this.groupBox1.Location = new System.Drawing.Point(704, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(621, 279);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(292, 228);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(151, 28);
            this.checkoutButton.TabIndex = 2;
            this.checkoutButton.Text = "Confirm Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 228);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cartBox
            // 
            this.cartBox.FormattingEnabled = true;
            this.cartBox.ItemHeight = 16;
            this.cartBox.Location = new System.Drawing.Point(168, 23);
            this.cartBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cartBox.Name = "cartBox";
            this.cartBox.Size = new System.Drawing.Size(273, 196);
            this.cartBox.TabIndex = 0;
            this.cartBox.SelectedIndexChanged += new System.EventHandler(this.cartBox_SelectedIndexChanged);
            // 
            // drinkBox
            // 
            this.drinkBox.Controls.Add(this.addDrinkButton);
            this.drinkBox.Controls.Add(this.drinkListBox);
            this.drinkBox.Location = new System.Drawing.Point(704, 340);
            this.drinkBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drinkBox.Size = new System.Drawing.Size(640, 228);
            this.drinkBox.TabIndex = 4;
            this.drinkBox.TabStop = false;
            this.drinkBox.Text = "Drink Selection";
            // 
            // addDrinkButton
            // 
            this.addDrinkButton.Location = new System.Drawing.Point(8, 192);
            this.addDrinkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDrinkButton.Name = "addDrinkButton";
            this.addDrinkButton.Size = new System.Drawing.Size(100, 28);
            this.addDrinkButton.TabIndex = 1;
            this.addDrinkButton.Text = "Add To Cart";
            this.addDrinkButton.UseVisualStyleBackColor = true;
            this.addDrinkButton.Click += new System.EventHandler(this.addDrinkButton_Click);
            // 
            // drinkListBox
            // 
            this.drinkListBox.FormattingEnabled = true;
            this.drinkListBox.ItemHeight = 16;
            this.drinkListBox.Location = new System.Drawing.Point(168, 53);
            this.drinkListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drinkListBox.Name = "drinkListBox";
            this.drinkListBox.Size = new System.Drawing.Size(273, 132);
            this.drinkListBox.TabIndex = 0;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(1100, 9);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(46, 17);
            this.customerLabel.TabIndex = 5;
            this.customerLabel.Text = "Guest";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(1273, 9);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(100, 28);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 638);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wingBox);
            this.Controls.Add(this.pizzaBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pizzaBox.ResumeLayout(false);
            this.wingBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.drinkBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pizzaListBox;
        private System.Windows.Forms.GroupBox pizzaBox;
        private System.Windows.Forms.Button addPizzaButton;
        private System.Windows.Forms.ListBox pizzaToppingListBox;
        private System.Windows.Forms.GroupBox wingBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox drinkBox;
        private System.Windows.Forms.ListBox sideToppings;
        private System.Windows.Forms.ListBox sideListBox;
        private System.Windows.Forms.ListBox cartBox;
        private System.Windows.Forms.ListBox drinkListBox;
        private System.Windows.Forms.Button addSideButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addDrinkButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button logInButton;
    }
}

