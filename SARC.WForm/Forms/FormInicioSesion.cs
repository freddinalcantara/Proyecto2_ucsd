using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SARC.WForm.Domain.EFRepository;

namespace SARC.WForm.Forms
{
    public partial class FormInicioSesion : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext;
        public FormInicioSesion()
        {

            InitializeComponent();
            _dbContext = new EFContext();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConectarse_Click(object sender, EventArgs e)
        {


            ValidacionSesion(TxtLoginUsuario.Text, TxtLoginPassword.Text);

        }

        private void ValidacionSesion(string Usuario, string Contrasena)
        {
            bool status = _dbContext.Usuarios.Where(c => c.codigo_usuario == Usuario && c.password == Contrasena).Any(c=>c.estatus);
            var validacion = _dbContext.Usuarios.Count(c=>c.codigo_usuario==Usuario && c.password==Contrasena);
            if (status == true)
            {
                if (validacion == 0)
                {
                    MessageBox.Show("Usuario o contrasena incorrectos");
                    TxtLoginUsuario.Clear();
                    TxtLoginPassword.Clear();
                }
                else
                {
                    this.Hide();
                    Form1 formulario = new Form1();
                    formulario.Show();
                }
            }
            else
            {
                MessageBox.Show("Cuenta inactiva o no existe");
            }
            
        }
    }
}
