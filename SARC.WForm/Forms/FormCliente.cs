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
    public partial class FormCliente : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext;
        
        public FormCliente()
        {
            InitializeComponent();
            _dbContext = new EFContext();
            metroGrid1.DataSource = _dbContext.Clients.ToList();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //TO-DO: agregar validaciones
            var Cliente = new Cliente {
                Id = txtIdentificacion.Text,
                Name = txtNombres.Text,
                LastName = txtApellidos.Text,
                PhoneNumber = txtNumeroTelf.Text,
                Celphone = txtCelular.Text
            };
            _dbContext.Clients.Add(Cliente);
            _dbContext.SaveChanges();
        }
    }
}
