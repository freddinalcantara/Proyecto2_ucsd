﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARC.WForm.Forms
{
    public partial class OrderForm : MetroFramework.Forms.MetroForm
    {
        public OrderForm()
        {
            InitializeComponent();
            BuscarCliente form = new BuscarCliente();
            form.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
