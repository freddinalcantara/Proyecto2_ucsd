namespace SARC.WForm.Forms
{
    partial class FormInicioSesion
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtLoginUsuario = new MetroFramework.Controls.MetroTextBox();
            this.TxtLoginPassword = new MetroFramework.Controls.MetroTextBox();
            this.LblPassword = new MetroFramework.Controls.MetroLabel();
            this.BtnConectarse = new MetroFramework.Controls.MetroButton();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(148, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuario";
            // 
            // TxtLoginUsuario
            // 
            // 
            // 
            // 
            this.TxtLoginUsuario.CustomButton.Image = null;
            this.TxtLoginUsuario.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.TxtLoginUsuario.CustomButton.Name = "";
            this.TxtLoginUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLoginUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLoginUsuario.CustomButton.TabIndex = 1;
            this.TxtLoginUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLoginUsuario.CustomButton.UseSelectable = true;
            this.TxtLoginUsuario.CustomButton.Visible = false;
            this.TxtLoginUsuario.Lines = new string[0];
            this.TxtLoginUsuario.Location = new System.Drawing.Point(148, 105);
            this.TxtLoginUsuario.MaxLength = 32767;
            this.TxtLoginUsuario.Name = "TxtLoginUsuario";
            this.TxtLoginUsuario.PasswordChar = '\0';
            this.TxtLoginUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLoginUsuario.SelectedText = "";
            this.TxtLoginUsuario.SelectionLength = 0;
            this.TxtLoginUsuario.SelectionStart = 0;
            this.TxtLoginUsuario.ShortcutsEnabled = true;
            this.TxtLoginUsuario.Size = new System.Drawing.Size(162, 23);
            this.TxtLoginUsuario.TabIndex = 1;
            this.TxtLoginUsuario.UseSelectable = true;
            this.TxtLoginUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLoginUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtLoginPassword
            // 
            // 
            // 
            // 
            this.TxtLoginPassword.CustomButton.Image = null;
            this.TxtLoginPassword.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.TxtLoginPassword.CustomButton.Name = "";
            this.TxtLoginPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLoginPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLoginPassword.CustomButton.TabIndex = 1;
            this.TxtLoginPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLoginPassword.CustomButton.UseSelectable = true;
            this.TxtLoginPassword.CustomButton.Visible = false;
            this.TxtLoginPassword.Lines = new string[0];
            this.TxtLoginPassword.Location = new System.Drawing.Point(148, 165);
            this.TxtLoginPassword.MaxLength = 32767;
            this.TxtLoginPassword.Name = "TxtLoginPassword";
            this.TxtLoginPassword.PasswordChar = '\0';
            this.TxtLoginPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLoginPassword.SelectedText = "";
            this.TxtLoginPassword.SelectionLength = 0;
            this.TxtLoginPassword.SelectionStart = 0;
            this.TxtLoginPassword.ShortcutsEnabled = true;
            this.TxtLoginPassword.Size = new System.Drawing.Size(162, 23);
            this.TxtLoginPassword.TabIndex = 3;
            this.TxtLoginPassword.UseSelectable = true;
            this.TxtLoginPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLoginPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(148, 142);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(64, 19);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password";
            // 
            // BtnConectarse
            // 
            this.BtnConectarse.Location = new System.Drawing.Point(148, 211);
            this.BtnConectarse.Name = "BtnConectarse";
            this.BtnConectarse.Size = new System.Drawing.Size(162, 23);
            this.BtnConectarse.TabIndex = 4;
            this.BtnConectarse.Text = "Conectarse";
            this.BtnConectarse.UseSelectable = true;
            this.BtnConectarse.Click += new System.EventHandler(this.BtnConectarse_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(148, 250);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(162, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 357);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnConectarse);
            this.Controls.Add(this.TxtLoginPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtLoginUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormInicioSesion";
            this.Text = "Iniciar sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtLoginUsuario;
        private MetroFramework.Controls.MetroTextBox TxtLoginPassword;
        private MetroFramework.Controls.MetroLabel LblPassword;
        private MetroFramework.Controls.MetroButton BtnConectarse;
        private MetroFramework.Controls.MetroButton BtnSalir;
    }
}