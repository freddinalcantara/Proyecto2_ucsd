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
            DataGridViewRow newRow = (DataGridViewRow)metroGrid1.Rows[0].Clone();
            newRow.Cells[0].Value = 1;
            newRow.Cells[1].Value = SelectedFood.Name;
            metroGrid1.Rows.Add(newRow);
            metroGrid1.Refresh();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(!metroRadioButton1.Checked)
            {
                metroComboBox1.Show();
                metroLabel2.Show();
               
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!metroRadioButton2.Checked)
            {
                metroComboBox1.Hide();
                metroLabel2.Hide();

            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ExtraFoodForm form = new ExtraFoodForm(this);
            form.Show();
           
        }
    }
}
