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
            BtnEditar.Enabled = false;
            _dbContext = new EFContext();
            metroGrid1.DataSource = _dbContext.Foods.ToList();
        }

        private void BtnAceptarAlimento_Click(object sender, EventArgs e)
        {
            if (ExistsAlimento(TxtNombreAlimento.Text))
            {
                MessageBox.Show(TxtNombreAlimento, "El alimento ya existe");

            }
            else
            {
                var food = new Food()
                {
                    Name = TxtNombreAlimento.Text,
                    NumberInStock = Int32.Parse(NudCantAlimentos.Value.ToString()),
                    Price = nupPrecioVenta.Value,
                    PriceImport = nudPrecioImportacion.Value
                };
                _dbContext.Foods.Add(food);
                _dbContext.SaveChanges();
                ActualizarListado();
            }
        }
        private bool ExistsAlimento(string alimento)
        {
            return _dbContext.Foods.FirstOrDefault(c => c.Name == alimento) != null;

        }
        private void ActualizarListado()
        {
            metroGrid1.DataSource = _dbContext.Foods.ToList();
        }

        private void ActualizarAlimento(string alimento, int nuevaCantidad)
        {
            //TODO: SI SE EDITA EL NOMBRE DEL ALIMENTO EXPLOTA VERIFICAR QUE HAGA EL CAMBIO  TANTO EN EL NOMBRE COMO CANTIDAD

            Food ActualizarAlimento = _dbContext.Foods.FirstOrDefault(c => c.Name == alimento);
            int ActualenStock = _dbContext.Foods.Where(c => c.Name == alimento).Sum(a => a.NumberInStock) + nuevaCantidad;
            var NombreAliment = TxtNombreAlimento.Text;
            ActualizarAlimento.NumberInStock = ActualenStock;
            ActualizarAlimento.Name = NombreAliment;
            ActualizarAlimento.Price = nupPrecioVenta.Value;
            ActualizarAlimento.PriceImport = nudPrecioImportacion.Value;

            if (ActualizarAlimento == null)
            {
                _dbContext.Foods.Add(ActualizarAlimento);
            }
            else
            {
                _dbContext.Entry(ActualizarAlimento).CurrentValues.SetValues(alimento);
            }
            _dbContext.SaveChanges();
            ActualizarListado();
        }
        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnAceptarAlimento.Enabled = false;
            NudCantAlimentos.Value = 0;
            TxtNombreAlimento.Text = metroGrid1.SelectedCells[1].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var alimentos = _dbContext.Foods.Where(a => a.Name == TxtNombreAlimento.Text);

            ActualizarAlimento(TxtNombreAlimento.Text, Convert.ToInt32(NudCantAlimentos.Value));
        }
    }
}
