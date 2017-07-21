using System;
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
    public partial class BuscarCliente : MetroFramework.Forms.MetroForm
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FormCliente formulario = new FormCliente();
            formulario.Show();
        }
    }
}
