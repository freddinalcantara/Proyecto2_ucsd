using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;
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
    public partial class FacturaForm : MetroFramework.Forms.MetroForm
    {
        Order OrdenToFaturar;
        decimal _subTotal;
        decimal Total;
        public FacturaForm(Order orden, decimal subTotal,decimal total)
        {
            InitializeComponent();
            OrdenToFaturar = orden;
      
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            txtSubTotal.Text = string.Format("{0:0.00}", OrdenToFaturar.SubTotal());
            txtTOTAL.Text = string.Format("{0:0.00}", OrdenToFaturar.Total());
            foreach (var detail in OrdenToFaturar.OrderDetails)
            {
                decimal itbis = Math.Round(detail.ItemPrice * 0.18m,2);
              dgvFactura.Rows.Add(detail.Item, string.Format("{0:1M}",itbis.ToString()), detail.ItemPrice);

            }
            dgvFactura.Refresh();

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
