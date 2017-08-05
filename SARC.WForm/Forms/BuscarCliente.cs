using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;
using SARC.WForm.Domain;

namespace SARC.WForm.Forms
{
    public partial class BuscarCliente : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext;
        private IGridEventListener gridEventListener;
        public BuscarCliente(IGridEventListener gridEventListener)
        {
            InitializeComponent();
            _dbContext = new EFContext();
            RefreshTable();
            this.gridEventListener = gridEventListener;
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FormCliente formulario = new FormCliente();
            formulario.Show();
        }
        
        //Para refrescar la tabla en caso de que un cliente se haya anadido
        private void RefreshTable()
        {
            dGridClientes.DataSource = _dbContext.Clients.ToList();
        }

        //Para seleccionar el cliente con un doble click en el Metro Grid
        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dGridClientes.SelectedCells[0].Value.ToString());
            Cliente cliente = _dbContext.Clients.Where(c => c.Id == ID).First();
            if (gridEventListener != null)
            {
                gridEventListener.OnRowSelected(cliente);
            }
            this.Hide();
        }

        private void metroTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string clientName = txtClientSearch.Text;
            dGridClientes.DataSource = _dbContext
                .Clients.Where(c => c.Name.Contains(clientName) || c.Cedula.Contains(clientName)).ToList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
