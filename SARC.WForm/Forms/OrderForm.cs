using SARC.WForm.Domain;
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

namespace SARC.WForm.Forms
{
    public partial class OrderForm : MetroFramework.Forms.MetroForm, IGridEventListener
    {
        Cliente SelectedClient;
        Food SelectedFood;
        Order Orden;
        List<Food> ExtraFood;
        Combo ExtraComboItem;
        decimal ITBIS;
        decimal Total = 0;
        List<OrdenDetail> DetalleOrden;
        //inicianlizando variables privadas
        private EFContext _dbContext = new EFContext();
        public OrderForm()
        {
            InitializeComponent();
            
            metroComboBox1.DataSource = _dbContext
                .Stands
                .Where(s=>s.Status == true)
                .AsEnumerable()
                .Select(stand => stand.StandNumber)
                .ToList();
            listBox1.DataSource = _dbContext
                    .Combos
                    .Select(c=>c.Id)
                    .ToList();
            //llenamos la lista de comidas que son extra
            Orden = new Order();
            Orden.TipoOrden = "Aqui";
            DetalleOrden = new List<OrdenDetail>();


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            BuscarCliente form = new BuscarCliente(this);
            form.Show();
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboNumber = Int32.Parse(listBox1.SelectedItem.ToString());
            var FoodList = _dbContext.Combos.Where(c => c.Id == comboNumber).FirstOrDefault();
            var query = (from f in _dbContext.Foods where f.Combos.Any(c => c.Id == FoodList.Id) select f.Name).ToList();
            listBox2.DataSource = query;
        }
        public void OnRowSelected(object row)
        {
            SelectedClient = ((Cliente)row);
            txtClientName.Text = SelectedClient.FullName;
        }

        public void OnRowSelectedExtraFood(object row)
        {
            SelectedFood = ((Food)row);
            //DataGridViewRow newRow = (DataGridViewRow)metroGrid1.Rows[0].Clone();
            //newRow.Cells[0].Value = 1;
            //newRow.Cells[1].Value = SelectedFood.Name;
            //newRow.Cells[2].Value = SelectedFood.Price;
            metroGrid1.Rows.Add(1, SelectedFood.Name, SelectedFood.Price);
            metroGrid1.Refresh();


        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(!metroRadioButton1.Checked)
            {
                metroComboBox1.Show();
                metroLabel2.Show();
                Orden.TipoOrden = "Llevar";


            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!metroRadioButton2.Checked)
            {
                metroComboBox1.Hide();
                metroLabel2.Hide();
                Orden.TipoOrden = "Aqui";
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ExtraFoodForm form = new ExtraFoodForm(this);
            form.Show();
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ComboSelectedId = Int32.Parse(listBox1.SelectedItem.ToString());
            var Combo = _dbContext.Combos.FirstOrDefault(c => c.Id == ComboSelectedId);
            //DataGridViewRow newRow = (DataGridViewRow)metroGrid1.Rows[0].Clone();
            //DataGridViewRow newRow = new DataGridViewRow();
            //newRow.Cells[0].Value = 1;
            //newRow.Cells[1].Value = string.Format("Combo #{0}",Combo.Id);
            //newRow.Cells[2].Value = Combo.Price;
            metroGrid1.Rows.Add(1, string.Format("Combo #{0}", Combo.Id), Combo.Price);
            //metroGrid1.Refresh();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if(txtClientName.Text == "")
            {
                MessageBox.Show("Se necesita un cliente para ordenrar");
                return;
            }

            
            
             var example  = metroGrid1.Rows
                       .OfType<DataGridViewRow>()
                       .Where(x => x.Cells[2].Value != null)
                       .Select(x => x.Cells[2].Value)
                       .ToList();

            if(example.Count() == 0)
            {
                MessageBox.Show("Se necesita un articulo en la orden");
                return;
            }

            foreach (decimal price in example)
            {
                Total += price;
            }
            ITBIS = Total * 0.18M;
            txtSubTotal.Text = string.Format("{0:0.00}", Total);
            Total = Total + ITBIS;
            txtTotal.Text = string.Format("{0:0.00}", Total);

            Orden.Cliente = _dbContext.Clients.FirstOrDefault(c => c.Cedula == SelectedClient.Cedula);
            if (Orden.TipoOrden == "Aqui")
            {
                int standId = Int32.Parse(metroComboBox1.SelectedItem.ToString());
                Orden.Stand = _dbContext.Stands.First(s=>s.Id==standId);
                
            }
            var CombosList = metroGrid1.Rows
                       .OfType<DataGridViewRow>()
                       .Where(x => x.Cells[1].Value != null)
                       .Select(x => x.Cells[1].Value.ToString())
                       .ToList();


            for (int i = 0; i < metroGrid1.RowCount; i++)
            {
                OrdenDetail ordenDetail = new OrdenDetail
                {
                    Item = metroGrid1.Rows[i].Cells[1].Value.ToString(),
                    ItemPrice = decimal.Parse(metroGrid1.Rows[i].Cells[2].Value.ToString()),
                };
                DetalleOrden.Add(ordenDetail);
            }
            Orden.OrderDetails = DetalleOrden;
            Orden.CreatedAt = DateTime.Now;
            Orden.Status = "Proceso";

            BtnProcesarFactura.Enabled = true;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == metroGrid1.Columns[3].Index && e.RowIndex != -1)
            {
                var StandNumber = Int32.Parse(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                metroGrid1.Rows.Remove(this.metroGrid1.Rows[e.RowIndex]);
            }
        }

        

        private void BtnProcesarFactura_Click(object sender, EventArgs e)
        {
            _dbContext.Orders.Add(Orden);
            _dbContext.SaveChanges();
            MessageBox.Show("Orden facturada");
            FacturaForm form = new FacturaForm(Orden,ITBIS, Total);
            form.Show();
            this.Hide();
        }
    }
}
