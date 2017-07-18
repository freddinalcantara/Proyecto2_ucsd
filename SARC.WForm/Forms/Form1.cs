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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ReservationForm form = new ReservationForm();
            form.Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ComboForm form = new ComboForm();
            form.Show();
            this.Hide();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.Show();
            this.Hide();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
