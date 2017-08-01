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
            //TODO: EL ROL POR FIRSTORDEFAULT ES 1, HAY QUE ARREGLAR ESO
            bool status = _dbContext.Usuarios.Where(c => c.codigo_usuario == Usuario && c.password == Contrasena).Any(c=>c.estatus);
            var validacion = _dbContext.Usuarios.Count(c=>c.codigo_usuario==Usuario && c.password==Contrasena);
            Domain.Models.Usuarios todo = _dbContext.Usuarios.Where(c => c.codigo_usuario == Usuario && c.password == Contrasena).FirstOrDefault();
            int rol = todo.Rol;
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
                    Form1 formulario = new Form1();

                    switch (rol)
                    {
                        case 0: //cocinero
                            formulario.MainMenuStrip.Items["reservacionesToolStripMenuItem"].Visible = false; //reservaciones
                            formulario.MainMenuStrip.Items["clientewsToolStripMenuItem"].Visible = false; //Clientes
                            formulario.MainMenuStrip.Items["facturasToolStripMenuItem"].Visible = false; // facturas
                            formulario.MainMenuStrip.Items["reporteriaToolStripMenuItem"].Visible = false; // reporteria
                            formulario.MainMenuStrip.Items["combosToolStripMenuItem"].Visible = false;// combos
                            formulario.MainMenuStrip.Items["inventarioToolStripMenuItem"].Visible = false;//inventario
                            formulario.MainMenuStrip.Items["usuariosToolStripMenuItem"].Visible = false;//Usuarios
                            formulario.MainMenuStrip.Items["mesasToolStripMenuItem"].Visible = false;//Mesas
                            break;
                        case 1: //camarero
                            //formulario.MainMenuStrip.Items["reservacionesToolStripMenuItem"].Visible = false; //reservaciones
                            //formulario.MainMenuStrip.Items["clientewsToolStripMenuItem"].Visible = false; //Clientes
                            //formulario.MainMenuStrip.Items["facturasToolStripMenuItem"].Visible = false; // facturas
                            //formulario.MainMenuStrip.Items["reporteriaToolStripMenuItem"].Visible = false; // reporteria
                            //formulario.MainMenuStrip.Items["combosToolStripMenuItem"].Visible = false;// combos
                            //formulario.MainMenuStrip.Items["inventarioToolStripMenuItem"].Visible = false;//inventario
                            //formulario.MainMenuStrip.Items["usuariosToolStripMenuItem"].Visible = false;//Usuarios
                            //formulario.MainMenuStrip.Items["mesasToolStripMenuItem"].Visible = false;//Mesas
                            break;
                        case 2://cajero
                            formulario.MainMenuStrip.Items["reservacionesToolStripMenuItem"].Visible = false; //reservaciones
                            formulario.MainMenuStrip.Items["clientewsToolStripMenuItem"].Visible = false; //Clientes
                            formulario.MainMenuStrip.Items["facturasToolStripMenuItem"].Visible = false; // facturas
                            formulario.MainMenuStrip.Items["reporteriaToolStripMenuItem"].Visible = false; // reporteria
                            formulario.MainMenuStrip.Items["combosToolStripMenuItem"].Visible = false;// combos
                            formulario.MainMenuStrip.Items["inventarioToolStripMenuItem"].Visible = false;//inventario
                            formulario.MainMenuStrip.Items["usuariosToolStripMenuItem"].Visible = false;//Usuarios
                            formulario.MainMenuStrip.Items["mesasToolStripMenuItem"].Visible = false;//Mesas
                            break;
                        case 3://administrador

                            break;
                    }
                    this.Hide();
                    
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
