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
    public partial class ExtraFoodForm : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext;
        private IGridEventListener gridEventListener;
        public ExtraFoodForm(IGridEventListener gridEventListener)
        {
            InitializeComponent();
            _dbContext = new EFContext();
            RefreshTable();
            this.gridEventListener = gridEventListener;
        }

        public void RefreshTable()
        {
            dGridExtraFood.DataSource =  _dbContext.Foods.Where(f => f.NumberInStock > 0).ToList();
        }

        private void dGridClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dGridExtraFood.SelectedCells[0].Value.ToString());
            Food food = _dbContext.Foods.Where(c => c.Id == ID).First();
            if (gridEventListener != null)
            {
                gridEventListener.OnRowSelectedExtraFood(food);
            }
            this.Hide();
        }
    }
}
