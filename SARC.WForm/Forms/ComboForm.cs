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
                _comida.Add(food.Name);
            }
            LbAlimentos.DataSource = _comida;
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
    }
}
