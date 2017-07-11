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
    }
}
