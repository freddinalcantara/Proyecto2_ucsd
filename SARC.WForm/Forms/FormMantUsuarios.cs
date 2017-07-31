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

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            bool hola = Convert.ToBoolean(CbEstado.SelectedValue);
            var Usuario = new Usuarios
            {
            
                codigo_usuario = TxtNombreUsuario.Text,
                password = TxtContrasena.Text,
                estatus = hola,
                Rol = Int32.Parse(CbEstado.SelectedItem.ToString()),
                Fecha_creacion = DateTime.Today

            };

            _dbContext.Usuarios.Add(Usuario);
            _dbContext.SaveChanges();
            GridUsuarioSistemas.DataSource = _dbContext.Usuarios.ToList();
        }
    }
}
