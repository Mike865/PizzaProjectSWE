
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
            this.otherDebitRadio = new System.Windows.Forms.RadioButton();
            this.orderTotalDescription = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.carryOutRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryRadio = new System.Windows.Forms.RadioButton();
            this.theOrderType = new System.Windows.Forms.GroupBox();
            this.paymentGroupBox.SuspendLayout();
            this.theOrderType.SuspendLayout();
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
            this.confirmCheckoutButton.Location = new System.Drawing.Point(53, 463);
            this.confirmCheckoutButton.Name = "confirmCheckoutButton";
            this.confirmCheckoutButton.Size = new System.Drawing.Size(108, 23);
            this.confirmCheckoutButton.TabIndex = 1;
            this.confirmCheckoutButton.Text = "Confirm Checkout";
            this.confirmCheckoutButton.UseVisualStyleBackColor = true;
            this.confirmCheckoutButton.Click += new System.EventHandler(this.confirmCheckoutButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(177, 463);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(6, 30);
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
            this.checkRadioButton.Location = new System.Drawing.Point(98, 30);
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
            this.existingCardButton.Enabled = false;
            this.existingCardButton.Location = new System.Drawing.Point(6, 77);
            this.existingCardButton.Name = "existingCardButton";
            this.existingCardButton.Size = new System.Drawing.Size(81, 17);
            this.existingCardButton.TabIndex = 5;
            this.existingCardButton.TabStop = true;
            this.existingCardButton.Text = "Saved Card";
            this.existingCardButton.UseVisualStyleBackColor = true;
            // 
            // otherDebitRadio
            // 
            this.otherDebitRadio.AutoSize = true;
            this.otherDebitRadio.Location = new System.Drawing.Point(98, 77);
            this.otherDebitRadio.Name = "otherDebitRadio";
            this.otherDebitRadio.Size = new System.Drawing.Size(111, 17);
            this.otherDebitRadio.TabIndex = 6;
            this.otherDebitRadio.TabStop = true;
            this.otherDebitRadio.Text = "Other Debit/Credit";
            this.otherDebitRadio.UseVisualStyleBackColor = true;
            // 
            // orderTotalDescription
            // 
            this.orderTotalDescription.AutoSize = true;
            this.orderTotalDescription.Location = new System.Drawing.Point(50, 237);
            this.orderTotalDescription.Name = "orderTotalDescription";
            this.orderTotalDescription.Size = new System.Drawing.Size(72, 13);
            this.orderTotalDescription.TabIndex = 9;
            this.orderTotalDescription.Text = "Order Total: $";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(128, 237);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(13, 13);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "0";
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.existingCardButton);
            this.paymentGroupBox.Controls.Add(this.otherDebitRadio);
            this.paymentGroupBox.Controls.Add(this.checkRadioButton);
            this.paymentGroupBox.Controls.Add(this.cashRadioButton);
            this.paymentGroupBox.Location = new System.Drawing.Point(53, 263);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(221, 100);
            this.paymentGroupBox.TabIndex = 11;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Type";
            // 
            // carryOutRadioButton
            // 
            this.carryOutRadioButton.AutoSize = true;
            this.carryOutRadioButton.Location = new System.Drawing.Point(6, 19);
            this.carryOutRadioButton.Name = "carryOutRadioButton";
            this.carryOutRadioButton.Size = new System.Drawing.Size(69, 17);
            this.carryOutRadioButton.TabIndex = 7;
            this.carryOutRadioButton.TabStop = true;
            this.carryOutRadioButton.Text = "Carry Out";
            this.carryOutRadioButton.UseVisualStyleBackColor = true;
            // 
            // deliveryRadio
            // 
            this.deliveryRadio.AutoSize = true;
            this.deliveryRadio.Location = new System.Drawing.Point(124, 19);
            this.deliveryRadio.Name = "deliveryRadio";
            this.deliveryRadio.Size = new System.Drawing.Size(63, 17);
            this.deliveryRadio.TabIndex = 12;
            this.deliveryRadio.TabStop = true;
            this.deliveryRadio.Text = "Delivery";
            this.deliveryRadio.UseVisualStyleBackColor = true;
            // 
            // theOrderType
            // 
            this.theOrderType.Controls.Add(this.carryOutRadioButton);
            this.theOrderType.Controls.Add(this.deliveryRadio);
            this.theOrderType.Location = new System.Drawing.Point(53, 386);
            this.theOrderType.Name = "theOrderType";
            this.theOrderType.Size = new System.Drawing.Size(221, 44);
            this.theOrderType.TabIndex = 13;
            this.theOrderType.TabStop = false;
            this.theOrderType.Text = "Choose Delivery or Carry Out";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 487);
            this.Controls.Add(this.theOrderType);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.orderTotalDescription);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmCheckoutButton);
            this.Controls.Add(this.checkoutBox);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.theOrderType.ResumeLayout(false);
            this.theOrderType.PerformLayout();
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
        private System.Windows.Forms.RadioButton otherDebitRadio;
        private System.Windows.Forms.Label orderTotalDescription;
        private System.Windows.Forms.Label orderTotal;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.RadioButton carryOutRadioButton;
        private System.Windows.Forms.RadioButton deliveryRadio;
        private System.Windows.Forms.GroupBox theOrderType;
    }
}