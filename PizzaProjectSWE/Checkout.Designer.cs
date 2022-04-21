
namespace PizzaProjectSWE
{
    partial class Checkout
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
            this.checkoutBox = new System.Windows.Forms.ListBox();
            this.confirmCheckoutButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.existingCardButton = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.carryOutCheckBox = new System.Windows.Forms.CheckBox();
            this.pickUpCheckBox = new System.Windows.Forms.CheckBox();
            this.orderTotalDescription = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkoutBox
            // 
            this.checkoutBox.FormattingEnabled = true;
            this.checkoutBox.Location = new System.Drawing.Point(46, 12);
            this.checkoutBox.Name = "checkoutBox";
            this.checkoutBox.Size = new System.Drawing.Size(256, 212);
            this.checkoutBox.TabIndex = 0;
            // 
            // confirmCheckoutButton
            // 
            this.confirmCheckoutButton.Location = new System.Drawing.Point(46, 366);
            this.confirmCheckoutButton.Name = "confirmCheckoutButton";
            this.confirmCheckoutButton.Size = new System.Drawing.Size(110, 23);
            this.confirmCheckoutButton.TabIndex = 1;
            this.confirmCheckoutButton.Text = "Confirm Checkout";
            this.confirmCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(194, 366);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(46, 262);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(49, 17);
            this.cashRadioButton.TabIndex = 3;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(151, 262);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(56, 17);
            this.checkRadioButton.TabIndex = 4;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // existingCardButton
            // 
            this.existingCardButton.AutoSize = true;
            this.existingCardButton.Location = new System.Drawing.Point(46, 299);
            this.existingCardButton.Name = "existingCardButton";
            this.existingCardButton.Size = new System.Drawing.Size(81, 17);
            this.existingCardButton.TabIndex = 5;
            this.existingCardButton.TabStop = true;
            this.existingCardButton.Text = "Saved Card";
            this.existingCardButton.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(151, 299);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(111, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Other Debit/Credit";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // carryOutCheckBox
            // 
            this.carryOutCheckBox.AutoSize = true;
            this.carryOutCheckBox.Location = new System.Drawing.Point(46, 330);
            this.carryOutCheckBox.Name = "carryOutCheckBox";
            this.carryOutCheckBox.Size = new System.Drawing.Size(67, 17);
            this.carryOutCheckBox.TabIndex = 7;
            this.carryOutCheckBox.Text = "CarryOut";
            this.carryOutCheckBox.UseVisualStyleBackColor = true;
            // 
            // pickUpCheckBox
            // 
            this.pickUpCheckBox.AutoSize = true;
            this.pickUpCheckBox.Location = new System.Drawing.Point(151, 330);
            this.pickUpCheckBox.Name = "pickUpCheckBox";
            this.pickUpCheckBox.Size = new System.Drawing.Size(61, 17);
            this.pickUpCheckBox.TabIndex = 8;
            this.pickUpCheckBox.Text = "PickUp";
            this.pickUpCheckBox.UseVisualStyleBackColor = true;
            // 
            // orderTotalDescription
            // 
            this.orderTotalDescription.AutoSize = true;
            this.orderTotalDescription.Location = new System.Drawing.Point(50, 237);
            this.orderTotalDescription.Name = "orderTotalDescription";
            this.orderTotalDescription.Size = new System.Drawing.Size(63, 13);
            this.orderTotalDescription.TabIndex = 9;
            this.orderTotalDescription.Text = "Order Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(148, 237);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(13, 13);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "0";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 395);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.orderTotalDescription);
            this.Controls.Add(this.pickUpCheckBox);
            this.Controls.Add(this.carryOutCheckBox);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.existingCardButton);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmCheckoutButton);
            this.Controls.Add(this.checkoutBox);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox checkoutBox;
        private System.Windows.Forms.Button confirmCheckoutButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.RadioButton existingCardButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox carryOutCheckBox;
        private System.Windows.Forms.CheckBox pickUpCheckBox;
        private System.Windows.Forms.Label orderTotalDescription;
        private System.Windows.Forms.Label orderTotal;
        private System.Windows.Forms.Label totalLabel;
    }
}