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
    public partial class FormMantUsuarios : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext;
        public FormMantUsuarios()
        {
            InitializeComponent();
            _dbContext = new EFContext();
            GridUsuarioSistemas.DataSource = _dbContext.Usuarios.ToList();
            GridUsuarioSistemas.Columns[0].Visible = false;
            BtnEditar.Enabled = false;


        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            bool hola = Convert.ToBoolean(CbEstado.SelectedValue);
            //Verifica si el usuario existe llamando al methodo ExisteUsuario y se le pasa el valor 
            //del textbox a donde se introduce el usuario como valor
            if (ExisteUsuario(TxtNombreUsuario.Text))
            {
                MessageBox.Show("Ya existe el usuario");
            }
            else if(CbRolUsuario.SelectedIndex < 0)
                {
                MessageBox.Show("Favor elegir rol de usuario");
                }
            else if(CbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Favor elegir un Estado");
            }
            else
            {
                    var Usuario = new Usuarios
                    {

                        codigo_usuario = TxtNombreUsuario.Text,
                        password = TxtContrasena.Text,
                        estatus = hola,
                        Rol = CbRolUsuario.SelectedIndex,
                        Fecha_creacion = DateTime.Today
                    };
                    _dbContext.Usuarios.Add(Usuario);
                    _dbContext.SaveChanges();
                    GridUsuarioSistemas.DataSource = _dbContext.Usuarios.ToList();
                MessageBox.Show("El usuario " + Usuario.codigo_usuario + " ha sido creado exitosamente");

            }

        }
        //Retorna un booleano, esto quiere decir que, si al momento de que el codigo de usuario es igual al nombre
        //va a devolver un 1, de lo contrario va a traer 0
        private bool ExisteUsuario (string nombreusuario)
        {
            return _dbContext.Usuarios.FirstOrDefault(c => c.codigo_usuario == nombreusuario) != null;

        }

        //Este metodo trae los valores seleccionados del grid a los textbox
        private void GridUsuarioSistemas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aceptar.Enabled = false;
            BtnEditar.Enabled = true;
            TxtNombreUsuario.Text = GridUsuarioSistemas.SelectedCells[1].Value.ToString();
            //CbEstado.Text = GridUsuarioSistemas.SelectedCells[3].Value.ToString();
            //CbRolUsuario.Text = GridUsuarioSistemas.SelectedCells[4].Value.ToString();
            TxtContrasena.Text = GridUsuarioSistemas.SelectedCells[2].Value.ToString();
        }
        
        private void ActualizarUsuario(string usuario)
        {
            Usuarios ActualizarUsuario = _dbContext.Usuarios.FirstOrDefault(c => c.codigo_usuario == usuario);

        }
        //para que el combobox no acepte ningun valor
        private void CbRolUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //para que el combobox no acepte ningun valor
        private void CbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
