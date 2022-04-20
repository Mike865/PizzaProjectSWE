
namespace PizzaProjectSWE
{
    partial class Log_In
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
            this.logInButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passWordBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.forgotPassword = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(88, 143);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 0;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.Location = new System.Drawing.Point(88, 233);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(156, 23);
            this.guestButton.TabIndex = 1;
            this.guestButton.Text = "Checkout As Guest";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(88, 52);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(156, 20);
            this.userNameBox.TabIndex = 2;
            // 
            // passWordBox
            // 
            this.passWordBox.Location = new System.Drawing.Point(88, 101);
            this.passWordBox.Name = "passWordBox";
            this.passWordBox.PasswordChar = '*';
            this.passWordBox.Size = new System.Drawing.Size(156, 20);
            this.passWordBox.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(169, 143);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // forgotPassword
            // 
            this.forgotPassword.Location = new System.Drawing.Point(88, 204);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(156, 23);
            this.forgotPassword.TabIndex = 5;
            this.forgotPassword.Text = "Forgot Password";
            this.forgotPassword.UseVisualStyleBackColor = true;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(12, 59);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome please log in or select checkout as guest!";
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(88, 180);
            this.createAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(156, 19);
            this.createAccount.TabIndex = 9;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 268);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.passWordBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.logInButton);
            this.MaximizeBox = false;
            this.Name = "Log_In";
            this.Text = "Log_In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button guestButton;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passWordBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button forgotPassword;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createAccount;
    }
}