
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
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.pizzaBox.SuspendLayout();
            this.wingBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.drinkBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaListBox
            // 
            this.pizzaListBox.FormattingEnabled = true;
            this.pizzaListBox.Location = new System.Drawing.Point(6, 50);
            this.pizzaListBox.Name = "pizzaListBox";
            this.pizzaListBox.Size = new System.Drawing.Size(192, 160);
            this.pizzaListBox.TabIndex = 0;
            this.pizzaListBox.SelectedIndexChanged += new System.EventHandler(this.pizzaListBox_SelectedIndexChanged);
            // 
            // pizzaBox
            // 
            this.pizzaBox.Controls.Add(this.addPizzaButton);
            this.pizzaBox.Controls.Add(this.pizzaToppingListBox);
            this.pizzaBox.Controls.Add(this.pizzaListBox);
            this.pizzaBox.Location = new System.Drawing.Point(12, 12);
            this.pizzaBox.Name = "pizzaBox";
            this.pizzaBox.Size = new System.Drawing.Size(464, 258);
            this.pizzaBox.TabIndex = 1;
            this.pizzaBox.TabStop = false;
            this.pizzaBox.Text = "Pizza Selection";
            // 
            // addPizzaButton
            // 
            this.addPizzaButton.Location = new System.Drawing.Point(6, 218);
            this.addPizzaButton.Name = "addPizzaButton";
            this.addPizzaButton.Size = new System.Drawing.Size(75, 23);
            this.addPizzaButton.TabIndex = 2;
            this.addPizzaButton.Text = "Add To Cart";
            this.addPizzaButton.UseVisualStyleBackColor = true;
            this.addPizzaButton.Click += new System.EventHandler(this.addPizzaButton_Click);
            // 
            // pizzaToppingListBox
            // 
            this.pizzaToppingListBox.Enabled = false;
            this.pizzaToppingListBox.FormattingEnabled = true;
            this.pizzaToppingListBox.Location = new System.Drawing.Point(224, 52);
            this.pizzaToppingListBox.Name = "pizzaToppingListBox";
            this.pizzaToppingListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pizzaToppingListBox.Size = new System.Drawing.Size(183, 160);
            this.pizzaToppingListBox.TabIndex = 1;
            this.pizzaToppingListBox.SelectedIndexChanged += new System.EventHandler(this.pizzaToppingListBox_SelectedIndexChanged);
            // 
            // wingBox
            // 
            this.wingBox.Controls.Add(this.addSideButton);
            this.wingBox.Controls.Add(this.sideToppings);
            this.wingBox.Controls.Add(this.sideListBox);
            this.wingBox.Location = new System.Drawing.Point(12, 276);
            this.wingBox.Name = "wingBox";
            this.wingBox.Size = new System.Drawing.Size(464, 185);
            this.wingBox.TabIndex = 2;
            this.wingBox.TabStop = false;
            this.wingBox.Text = "Side Selection";
            // 
            // addSideButton
            // 
            this.addSideButton.Location = new System.Drawing.Point(6, 156);
            this.addSideButton.Name = "addSideButton";
            this.addSideButton.Size = new System.Drawing.Size(75, 23);
            this.addSideButton.TabIndex = 2;
            this.addSideButton.Text = "Add To Cart";
            this.addSideButton.UseVisualStyleBackColor = true;
            this.addSideButton.Click += new System.EventHandler(this.addWingButton_Click);
            // 
            // sideToppings
            // 
            this.sideToppings.Enabled = false;
            this.sideToppings.FormattingEnabled = true;
            this.sideToppings.Location = new System.Drawing.Point(224, 43);
            this.sideToppings.Name = "sideToppings";
            this.sideToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sideToppings.Size = new System.Drawing.Size(183, 95);
            this.sideToppings.TabIndex = 1;
            // 
            // sideListBox
            // 
            this.sideListBox.FormattingEnabled = true;
            this.sideListBox.Location = new System.Drawing.Point(6, 43);
            this.sideListBox.Name = "sideListBox";
            this.sideListBox.Size = new System.Drawing.Size(192, 95);
            this.sideListBox.TabIndex = 0;
            this.sideListBox.SelectedIndexChanged += new System.EventHandler(this.wingListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkoutButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.cartBox);
            this.groupBox1.Location = new System.Drawing.Point(528, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 241);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(219, 212);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(113, 23);
            this.checkoutButton.TabIndex = 2;
            this.checkoutButton.Text = "Confirm Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(126, 212);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cartBox
            // 
            this.cartBox.FormattingEnabled = true;
            this.cartBox.Location = new System.Drawing.Point(126, 19);
            this.cartBox.Name = "cartBox";
            this.cartBox.Size = new System.Drawing.Size(206, 160);
            this.cartBox.TabIndex = 0;
            this.cartBox.SelectedIndexChanged += new System.EventHandler(this.cartBox_SelectedIndexChanged);
            // 
            // drinkBox
            // 
            this.drinkBox.Controls.Add(this.addDrinkButton);
            this.drinkBox.Controls.Add(this.drinkListBox);
            this.drinkBox.Location = new System.Drawing.Point(528, 290);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(480, 185);
            this.drinkBox.TabIndex = 4;
            this.drinkBox.TabStop = false;
            this.drinkBox.Text = "Drink Selection";
            // 
            // addDrinkButton
            // 
            this.addDrinkButton.Location = new System.Drawing.Point(6, 156);
            this.addDrinkButton.Name = "addDrinkButton";
            this.addDrinkButton.Size = new System.Drawing.Size(75, 23);
            this.addDrinkButton.TabIndex = 1;
            this.addDrinkButton.Text = "Add To Cart";
            this.addDrinkButton.UseVisualStyleBackColor = true;
            this.addDrinkButton.Click += new System.EventHandler(this.addDrinkButton_Click);
            // 
            // drinkListBox
            // 
            this.drinkListBox.FormattingEnabled = true;
            this.drinkListBox.Location = new System.Drawing.Point(126, 43);
            this.drinkListBox.Name = "drinkListBox";
            this.drinkListBox.Size = new System.Drawing.Size(206, 108);
            this.drinkListBox.TabIndex = 0;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(825, 7);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(35, 13);
            this.customerLabel.TabIndex = 5;
            this.customerLabel.Text = "Guest";
            this.customerLabel.Click += new System.EventHandler(this.customerLabel_Click);
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(955, 7);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(251, 187);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(28, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "0.00";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 518);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wingBox);
            this.Controls.Add(this.pizzaBox);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pizzaBox.ResumeLayout(false);
            this.wingBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label1;
    }
}

