﻿using System;
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
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }
        private void createAccount_Click(object sender, EventArgs e)
        {
            AccountCreation createAccountForm = new AccountCreation();
            createAccountForm.ShowDialog();
        }
    }
}
