using System;
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
            //FacturaForm formulario = new FacturaForm();
            //formulario.MdiParent = this;
            //formulario.Show();
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
            Forms.Mesas formulario = new Forms.Mesas();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Forms.FormMantUsuarios formulario = new Forms.FormMantUsuarios();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void reporteDeVentaDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FormReporteAlimentos formulario = new Forms.FormReporteAlimentos();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void reporteMensualDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ReporteMensualDeVentas formulario = new Forms.ReporteMensualDeVentas();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void reporteUltimos7DiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Reporteultimo7Dias formulario = new Forms.Reporteultimo7Dias();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
