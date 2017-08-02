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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if(txtIdentificacion.Text != "" && txtNombres.Text != "")
            {
                var cliente = new Cliente
                {
                    Cedula = txtIdentificacion.Text,
                    Name = txtNombres.Text,
                    LastName = txtApellidos.Text,
                    PhoneNumber = txtNumeroTelf.Text,
                    Celphone = txtCelular.Text
                };

                EditarPersona(cliente);
            }
            else
            {
                MessageBox.Show("Se necesita almenos un nombre e identificacion");
                Clean();
            }


        }

        public bool EditarPersona(Cliente cliente)
        {
            var clienteToUpdate = _dbContext.Clients.FirstOrDefault(c => c.Cedula == cliente.Cedula);

            if (clienteToUpdate == null)
            {
                _dbContext.Clients.Add(cliente);
            }
            else
            {
                clienteToUpdate.Cedula = cliente.Cedula;
                clienteToUpdate.LastName = cliente.LastName;
                clienteToUpdate.PhoneNumber = cliente.PhoneNumber;
                clienteToUpdate.Celphone = cliente.Celphone;
                clienteToUpdate.Name = cliente.Name;

                _dbContext.Entry(clienteToUpdate).State = EntityState.Modified;
            }

            _dbContext.SaveChanges();
            metroGrid1.DataSource = _dbContext.Clients.ToList();

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
            var ClientId = Int32.Parse(metroGrid1.SelectedCells[0].Value.ToString());
            var Client = _dbContext.Clients.FirstOrDefault(c => c.Id == ClientId);
            _dbContext.Clients.Remove(Client);
            _dbContext.SaveChanges();
            metroGrid1.DataSource = _dbContext.Clients.ToList();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ClientId = Int32.Parse(metroGrid1.SelectedCells[0].Value.ToString());
            var Client = _dbContext.Clients.FirstOrDefault(c => c.Id == ClientId);
            txtIdentificacion.Text = Client.Cedula;
            txtNombres.Text = Client.Name;
            txtApellidos.Text = Client.LastName;
            txtNumeroTelf.Text = Client.PhoneNumber;
            txtCelular.Text = Client.Celphone;
        }

        //Metodo para no permitir numeros en un textbox
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Favor digite un caracter correcto");
                e.Handled = true;
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Favor digite un caracter correcto");
                e.Handled = true;
            }
        }

        public void Clean()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtIdentificacion.Text = "";
            txtNumeroTelf.Text = "";
            txtCelular.Text = "";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void metroTextBox6_KeyUp(object sender, KeyEventArgs e)
        {
            string clientName = metroTextBox6.Text;
            metroGrid1.DataSource = _dbContext
                .Clients.Where(c => c.Name.Contains(clientName) || c.Cedula.Contains(clientName)).ToList();
        }
    }
}
