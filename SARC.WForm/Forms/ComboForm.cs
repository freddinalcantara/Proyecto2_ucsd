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
        
        public ComboForm()
        {
            InitializeComponent();
            _dbContext = new EFContext();
            foreach (var food in _dbContext.Foods.Where(f=>f.NumberInStock > 0))
            {
                LbAlimentos.Items.Add(food.Name);
            }
            
        }

        private void ComboForm_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void BtnAddToCombo_Click(object sender, EventArgs e)
        {
            //Obtenemos los nombre de los alimentos a agregar
            var AgregarCombo = LbAlimentos.SelectedItems;

            foreach(var itemToCombo in AgregarCombo)
            {
                LbCombos.Items.Add(itemToCombo.ToString());
                LbAlimentos.Items.Remove(itemToCombo.ToString());
            }
            
        }
    }
}
