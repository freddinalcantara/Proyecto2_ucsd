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
    public partial class ComboForm : MetroFramework.Forms.MetroForm
    {
        public List<String> _comida = new List<String>();
        private EFContext _dbContext;
        private Combo CurrentCombo;
        
        public ComboForm()
        {
            //TODO: Show next combo number to create
            //TODO: Load combos in the table
            //TODO: Edit Combo
            //TODO: Delete Combo

            InitializeComponent();
            _dbContext = new EFContext();
            foreach (var food in _dbContext.Foods.Where(f=>f.NumberInStock > 0))
            {
                LbAlimentos.Items.Add(food);
            }
            CurrentCombo = _dbContext.Combos.OrderByDescending(c => c.Id).FirstOrDefault();
            TxtComboName.Text = (CurrentCombo.Id + 1).ToString();
            metroGrid1.DataSource = _dbContext.Combos.ToList();
        }

        private void ComboForm_Load(object sender, EventArgs e)
        {
            
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            SwapItemsList(LbCombos, LbAlimentos);
        }

        private void SwapItemsList(ListBox from, ListBox to)
        {
            Object[] items = new Object[from.SelectedItems.Count];
            from.SelectedItems.CopyTo(items, 0);

            foreach (var item in items)
            {
                to.Items.Add(item);
                from.Items.Remove(item);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void BtnAddToCombo_Click(object sender, EventArgs e)
        {
            SwapItemsList(LbAlimentos, LbCombos);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            //TODO: Validate price is not blank
            //TODO: Validate price is a numeric value
            Combo combo = new Combo();
            combo.Price = Int32.Parse(txtPrice.Text);
            foreach (Food food in LbCombos.Items)
            {
                combo.Foods.Add(food);
            }
            _dbContext.Combos.Add(combo);
            _dbContext.SaveChanges();
            //combo.Foods.Add

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            var ComboId = Int32.Parse(metroGrid1.SelectedCells[0].Value.ToString());
            var Combo = _dbContext.Combos.FirstOrDefault(c => c.Id == ComboId);
            _dbContext.Combos.Remove(Combo);
            _dbContext.SaveChanges();
        }
    }
}
