namespace SARC.WForm.Forms
{
    partial class FormMantUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblUsuario = new MetroFramework.Controls.MetroLabel();
            this.TxtNombreUsuario = new MetroFramework.Controls.MetroTextBox();
            this.LblPassword = new MetroFramework.Controls.MetroLabel();
            this.TxtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.LblRol = new MetroFramework.Controls.MetroLabel();
            this.CbRolUsuario = new System.Windows.Forms.ComboBox();
            this.LblEstado = new MetroFramework.Controls.MetroLabel();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.Aceptar = new MetroFramework.Controls.MetroButton();
            this.GridUsuarioSistemas = new MetroFramework.Controls.MetroGrid();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarioSistemas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(23, 69);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(53, 19);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // TxtNombreUsuario
            // 
            // 
            // 
            // 
            this.TxtNombreUsuario.CustomButton.Image = null;
            this.TxtNombreUsuario.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.TxtNombreUsuario.CustomButton.Name = "";
            this.TxtNombreUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNombreUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNombreUsuario.CustomButton.TabIndex = 1;
            this.TxtNombreUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNombreUsuario.CustomButton.UseSelectable = true;
            this.TxtNombreUsuario.CustomButton.Visible = false;
            this.TxtNombreUsuario.Lines = new string[0];
            this.TxtNombreUsuario.Location = new System.Drawing.Point(23, 91);
            this.TxtNombreUsuario.MaxLength = 32767;
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.PasswordChar = '\0';
            this.TxtNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNombreUsuario.SelectedText = "";
            this.TxtNombreUsuario.SelectionLength = 0;
            this.TxtNombreUsuario.SelectionStart = 0;
            this.TxtNombreUsuario.ShortcutsEnabled = true;
            this.TxtNombreUsuario.Size = new System.Drawing.Size(127, 23);
            this.TxtNombreUsuario.TabIndex = 1;
            this.TxtNombreUsuario.UseSelectable = true;
            this.TxtNombreUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNombreUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(22, 127);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(64, 19);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password";
            // 
            // TxtContrasena
            // 
            // 
            // 
            // 
            this.TxtContrasena.CustomButton.Image = null;
            this.TxtContrasena.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.TxtContrasena.CustomButton.Name = "";
            this.TxtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContrasena.CustomButton.TabIndex = 1;
            this.TxtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContrasena.CustomButton.UseSelectable = true;
            this.TxtContrasena.CustomButton.Visible = false;
            this.TxtContrasena.Lines = new string[0];
            this.TxtContrasena.Location = new System.Drawing.Point(23, 149);
            this.TxtContrasena.MaxLength = 32767;
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContrasena.SelectedText = "";
            this.TxtContrasena.SelectionLength = 0;
            this.TxtContrasena.SelectionStart = 0;
            this.TxtContrasena.ShortcutsEnabled = true;
            this.TxtContrasena.Size = new System.Drawing.Size(127, 23);
            this.TxtContrasena.TabIndex = 3;
            this.TxtContrasena.UseSelectable = true;
            this.TxtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Location = new System.Drawing.Point(192, 68);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(28, 19);
            this.LblRol.TabIndex = 4;
            this.LblRol.Text = "Rol";
            // 
            // CbRolUsuario
            // 
            this.CbRolUsuario.FormattingEnabled = true;
            this.CbRolUsuario.Items.AddRange(new object[] {
            "Cocinero",
            "Camarero",
            "Cajero",
            "Administrador"});
            this.CbRolUsuario.Location = new System.Drawing.Point(192, 91);
            this.CbRolUsuario.Name = "CbRolUsuario";
            this.CbRolUsuario.Size = new System.Drawing.Size(127, 21);
            this.CbRolUsuario.TabIndex = 5;
            this.CbRolUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbRolUsuario_KeyPress);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(192, 126);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(48, 19);
            this.LblEstado.TabIndex = 6;
            this.LblEstado.Text = "Estado";
            // 
            // CbEstado
            // 
            this.CbEstado.AllowDrop = true;
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.CbEstado.Location = new System.Drawing.Point(192, 148);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(127, 21);
            this.CbEstado.TabIndex = 7;
            this.CbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbEstado_KeyPress);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(350, 93);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(128, 23);
            this.Aceptar.TabIndex = 8;
            this.Aceptar.Text = "Guardar";
            this.Aceptar.UseSelectable = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // GridUsuarioSistemas
            // 
            this.GridUsuarioSistemas.AllowUserToResizeRows = false;
            this.GridUsuarioSistemas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridUsuarioSistemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridUsuarioSistemas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridUsuarioSistemas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsuarioSistemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUsuarioSistemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUsuarioSistemas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridUsuarioSistemas.EnableHeadersVisualStyles = false;
            this.GridUsuarioSistemas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridUsuarioSistemas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridUsuarioSistemas.Location = new System.Drawing.Point(23, 194);
            this.GridUsuarioSistemas.Name = "GridUsuarioSistemas";
            this.GridUsuarioSistemas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsuarioSistemas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridUsuarioSistemas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridUsuarioSistemas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsuarioSistemas.Size = new System.Drawing.Size(622, 150);
            this.GridUsuarioSistemas.TabIndex = 9;
            this.GridUsuarioSistemas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuarioSistemas_CellDoubleClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(350, 146);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(128, 23);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseSelectable = true;
            // 
            // FormMantUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 375);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.GridUsuarioSistemas);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.CbRolUsuario);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Name = "FormMantUsuarios";
            this.Text = "Usuarios del Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarioSistemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblUsuario;
        private MetroFramework.Controls.MetroTextBox TxtNombreUsuario;
        private MetroFramework.Controls.MetroLabel LblPassword;
        private MetroFramework.Controls.MetroTextBox TxtContrasena;
        private MetroFramework.Controls.MetroLabel LblRol;
        private System.Windows.Forms.ComboBox CbRolUsuario;
        private MetroFramework.Controls.MetroLabel LblEstado;
        private System.Windows.Forms.ComboBox CbEstado;
        private MetroFramework.Controls.MetroButton Aceptar;
        private MetroFramework.Controls.MetroGrid GridUsuarioSistemas;
        private MetroFramework.Controls.MetroButton BtnEditar;
    }
}