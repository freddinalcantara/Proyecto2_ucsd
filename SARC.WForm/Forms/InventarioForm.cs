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
    public partial class InventarioForm : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext;
        public InventarioForm()
        {
            InitializeComponent();
            _dbContext = new EFContext();
            metroGrid1.DataSource = _dbContext.Foods.ToList();
        }

        private void BtnAceptarAlimento_Click(object sender, EventArgs e)
        {
            var food = new Food()
            {
                Name = TxtNombreAlimento.Text,
                NumberInStock = Int32.Parse(NudCantAlimentos.Value.ToString())
            };
            _dbContext.Foods.Add(food);
            _dbContext.SaveChanges();
        }
    }
}
