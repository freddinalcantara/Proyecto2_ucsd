﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARC.WForm
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }



        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationForm formulario = new ReservationForm();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formulario = new FormCliente();
            formulario.MdiParent = this;
            formulario.Show();
                }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaForm formulario = new FacturaForm();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.OrderForm formulario = new Forms.OrderForm();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ComboForm formulario = new ComboForm();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void alimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.InventarioForm formulario = new Forms.InventarioForm();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void mantenimientoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Forms.FormMantMesas formulario = new Forms.FormMantMesas();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Forms.FormMantUsuarios formulario = new Forms.FormMantUsuarios();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
