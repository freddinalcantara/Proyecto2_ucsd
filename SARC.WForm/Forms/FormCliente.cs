using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            var Cliente = new Cliente
            {
                Id = txtIdentificacion.Text,
                Name = txtNombres.Text,
                LastName = txtApellidos.Text,
                PhoneNumber = txtNumeroTelf.Text,
                Celphone = txtCelular.Text
            };
            RegistrarPersona(Cliente);
        }

        public bool EditarPersona(Cliente cliente)
        {
            _dbContext.Clients.Attach(cliente);
            _dbContext.Entry(cliente).State = EntityState.Modified;

            _dbContext.SaveChanges();

            return true;
        }

        public bool RegistrarPersona(Cliente cliente)
        {

            _dbContext.Clients.Add(cliente);
            _dbContext.SaveChanges();

            return true;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            var ClientId = metroGrid1.SelectedCells[0].Value.ToString();
            var Client = _dbContext.Clients.FirstOrDefault(c => c.Id == ClientId);
            _dbContext.Clients.Remove(Client);
            _dbContext.SaveChanges();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ClientId = metroGrid1.SelectedCells[0].Value.ToString();
            var Client = _dbContext.Clients.FirstOrDefault(c => c.Id == ClientId);
            txtIdentificacion.Text = Client.Id;
            txtNombres.Text = Client.Name;
            txtApellidos.Text = Client.LastName;
            txtNumeroTelf.Text = Client.PhoneNumber;
            txtCelular.Text = Client.Celphone;
        }
    }
}
