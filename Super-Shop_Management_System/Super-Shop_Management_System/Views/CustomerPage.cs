﻿using Super_Shop_Management_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management_System.Views
{
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
            var ds = ProductController.GetAllProducts();
            dataGridViewProduct.DataSource = ds;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClickThisButton_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }
    }
}
