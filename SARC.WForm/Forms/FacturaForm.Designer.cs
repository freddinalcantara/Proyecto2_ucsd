namespace SARC.WForm
{
    partial class FacturaForm : MetroFramework.Forms.MetroForm
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
            this.lblCompaniaName = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblSubtotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSubTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtTOTAL = new MetroFramework.Controls.MetroTextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompaniaName
            // 
            this.lblCompaniaName.AutoSize = true;
            this.lblCompaniaName.Location = new System.Drawing.Point(97, 69);
            this.lblCompaniaName.Name = "lblCompaniaName";
            this.lblCompaniaName.Size = new System.Drawing.Size(127, 19);
            this.lblCompaniaName.TabIndex = 2;
            this.lblCompaniaName.Text = "La tipica Domnicana";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(247, 54);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "AV. ROMULO BETANCOURT ESQ. ANGEL MARIA LIZ PLAZA DAVIANA # 1449 TEL.: (809)-482=6" +
    "009";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 182);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(243, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "---------------------------------------";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDescripcion,
            this.clmITBIS,
            this.clmValor});
            this.dgvFactura.Location = new System.Drawing.Point(23, 204);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(247, 150);
            this.dgvFactura.TabIndex = 6;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripcion";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            // 
            // clmITBIS
            // 
            this.clmITBIS.HeaderText = "ITBIS";
            this.clmITBIS.Name = "clmITBIS";
            this.clmITBIS.ReadOnly = true;
            this.clmITBIS.Width = 50;
            // 
            // clmValor
            // 
            this.clmValor.HeaderText = "Valor";
            this.clmValor.Name = "clmValor";
            this.clmValor.ReadOnly = true;
            this.clmValor.Width = 50;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 366);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(243, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "---------------------------------------";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(77, 392);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 19);
            this.lblSubtotal.TabIndex = 8;
            this.lblSubtotal.Text = "SUB TOTAL";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(77, 421);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "TOTAL";
            // 
            // txtSubTotal
            // 
            // 
            // 
            // 
            this.txtSubTotal.CustomButton.Image = null;
            this.txtSubTotal.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtSubTotal.CustomButton.Name = "";
            this.txtSubTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubTotal.CustomButton.TabIndex = 1;
            this.txtSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubTotal.CustomButton.UseSelectable = true;
            this.txtSubTotal.CustomButton.Visible = false;
            this.txtSubTotal.Lines = new string[0];
            this.txtSubTotal.Location = new System.Drawing.Point(173, 388);
            this.txtSubTotal.MaxLength = 32767;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.SelectionLength = 0;
            this.txtSubTotal.SelectionStart = 0;
            this.txtSubTotal.ShortcutsEnabled = true;
            this.txtSubTotal.Size = new System.Drawing.Size(97, 23);
            this.txtSubTotal.TabIndex = 10;
            this.txtSubTotal.UseSelectable = true;
            this.txtSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTOTAL
            // 
            // 
            // 
            // 
            this.txtTOTAL.CustomButton.Image = null;
            this.txtTOTAL.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtTOTAL.CustomButton.Name = "";
            this.txtTOTAL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTOTAL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTOTAL.CustomButton.TabIndex = 1;
            this.txtTOTAL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTOTAL.CustomButton.UseSelectable = true;
            this.txtTOTAL.CustomButton.Visible = false;
            this.txtTOTAL.Lines = new string[0];
            this.txtTOTAL.Location = new System.Drawing.Point(173, 417);
            this.txtTOTAL.MaxLength = 32767;
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.PasswordChar = '\0';
            this.txtTOTAL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTOTAL.SelectedText = "";
            this.txtTOTAL.SelectionLength = 0;
            this.txtTOTAL.SelectionStart = 0;
            this.txtTOTAL.ShortcutsEnabled = true;
            this.txtTOTAL.Size = new System.Drawing.Size(97, 23);
            this.txtTOTAL.TabIndex = 11;
            this.txtTOTAL.UseSelectable = true;
            this.txtTOTAL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTOTAL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(108, 480);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(202, 443);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "ITBIS 18%";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // FacturaForm
            // 
            this.ClientSize = new System.Drawing.Size(309, 526);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCompaniaName);
            this.Name = "FacturaForm";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCompaniaName;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITBIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblSubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSubTotal;
        private MetroFramework.Controls.MetroTextBox txtTOTAL;
        private System.Windows.Forms.Button btnImprimir;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}