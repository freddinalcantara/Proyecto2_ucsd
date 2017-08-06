namespace SARC.WForm
{
    partial class ReservationForm
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
            this.txtDetalle = new MetroFramework.Controls.MetroTextBox();
            this.btnReservar = new MetroFramework.Controls.MetroButton();
            this.dtpReservationDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.nudSillas = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BtnBuscarCliente = new MetroFramework.Controls.MetroButton();
            this.dgvStandsToReserve = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvStands = new System.Windows.Forms.DataGridView();
            this.clmStand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChairs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddStand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarMesas = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.clmMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSillas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudSillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandsToReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStands)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetalle
            // 
            // 
            // 
            // 
            this.txtDetalle.CustomButton.Image = null;
            this.txtDetalle.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.txtDetalle.CustomButton.Name = "";
            this.txtDetalle.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.txtDetalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetalle.CustomButton.TabIndex = 1;
            this.txtDetalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetalle.CustomButton.UseSelectable = true;
            this.txtDetalle.CustomButton.Visible = false;
            this.txtDetalle.Lines = new string[] {
        "Detalle..."};
            this.txtDetalle.Location = new System.Drawing.Point(143, 617);
            this.txtDetalle.MaxLength = 32767;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.PasswordChar = '\0';
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetalle.SelectedText = "";
            this.txtDetalle.SelectionLength = 0;
            this.txtDetalle.SelectionStart = 0;
            this.txtDetalle.ShortcutsEnabled = true;
            this.txtDetalle.Size = new System.Drawing.Size(379, 65);
            this.txtDetalle.TabIndex = 10;
            this.txtDetalle.Text = "Detalle...";
            this.txtDetalle.UseSelectable = true;
            this.txtDetalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(22, 688);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(500, 36);
            this.btnReservar.TabIndex = 11;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReservar.UseSelectable = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReservationDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpReservationDate.Location = new System.Drawing.Point(142, 114);
            this.dtpReservationDate.MinDate = new System.DateTime(2017, 8, 5, 0, 0, 0, 0);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(381, 20);
            this.dtpReservationDate.TabIndex = 13;
            this.dtpReservationDate.ValueChanged += new System.EventHandler(this.dtpReservationDate_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Fecha Reservacion";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 588);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Cliente";
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(23, 68);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(501, 23);
            this.metroTile5.TabIndex = 18;
            this.metroTile5.Text = "Mesas";
            this.metroTile5.UseSelectable = true;
            // 
            // nudSillas
            // 
            this.nudSillas.Location = new System.Drawing.Point(144, 552);
            this.nudSillas.Name = "nudSillas";
            this.nudSillas.Size = new System.Drawing.Size(41, 20);
            this.nudSillas.TabIndex = 22;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 553);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(111, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Cantidad de sillas";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Location = new System.Drawing.Point(429, 578);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(93, 29);
            this.BtnBuscarCliente.TabIndex = 24;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseSelectable = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dgvStandsToReserve
            // 
            this.dgvStandsToReserve.AllowUserToAddRows = false;
            this.dgvStandsToReserve.AllowUserToDeleteRows = false;
            this.dgvStandsToReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandsToReserve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMesa,
            this.clmUbicacion,
            this.clmSillas,
            this.Eliminar});
            this.dgvStandsToReserve.Location = new System.Drawing.Point(27, 379);
            this.dgvStandsToReserve.Name = "dgvStandsToReserve";
            this.dgvStandsToReserve.ReadOnly = true;
            this.dgvStandsToReserve.Size = new System.Drawing.Size(713, 131);
            this.dgvStandsToReserve.TabIndex = 25;
            this.dgvStandsToReserve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStandsToReserve_CellClick);
            this.dgvStandsToReserve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStandsToReserve_CellContentClick);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(142, 587);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(281, 20);
            this.txtCliente.TabIndex = 26;
            // 
            // dgvStands
            // 
            this.dgvStands.AllowUserToAddRows = false;
            this.dgvStands.AllowUserToDeleteRows = false;
            this.dgvStands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStand,
            this.clmLocation,
            this.clmChairs,
            this.clmStatus,
            this.clmReservationDate,
            this.clmAddStand});
            this.dgvStands.Location = new System.Drawing.Point(25, 178);
            this.dgvStands.Name = "dgvStands";
            this.dgvStands.ReadOnly = true;
            this.dgvStands.Size = new System.Drawing.Size(714, 146);
            this.dgvStands.TabIndex = 27;
            this.dgvStands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStands_CellClick);
            this.dgvStands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStands_CellContentClick);
            // 
            // clmStand
            // 
            this.clmStand.HeaderText = "Mesa #";
            this.clmStand.Name = "clmStand";
            this.clmStand.ReadOnly = true;
            // 
            // clmLocation
            // 
            this.clmLocation.HeaderText = "Ubicacion";
            this.clmLocation.Name = "clmLocation";
            this.clmLocation.ReadOnly = true;
            // 
            // clmChairs
            // 
            this.clmChairs.HeaderText = "Cantidad Sillas";
            this.clmChairs.Name = "clmChairs";
            this.clmChairs.ReadOnly = true;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estatus";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmReservationDate
            // 
            this.clmReservationDate.HeaderText = "Fecha Reservacion";
            this.clmReservationDate.Name = "clmReservationDate";
            this.clmReservationDate.ReadOnly = true;
            // 
            // clmAddStand
            // 
            this.clmAddStand.HeaderText = "Agregar";
            this.clmAddStand.Name = "clmAddStand";
            this.clmAddStand.ReadOnly = true;
            this.clmAddStand.Text = "Agregar";
            this.clmAddStand.UseColumnTextForButtonValue = true;
            // 
            // btnBuscarMesas
            // 
            this.btnBuscarMesas.Location = new System.Drawing.Point(23, 149);
            this.btnBuscarMesas.Name = "btnBuscarMesas";
            this.btnBuscarMesas.Size = new System.Drawing.Size(133, 23);
            this.btnBuscarMesas.TabIndex = 28;
            this.btnBuscarMesas.Text = "Buscar Mesas";
            this.btnBuscarMesas.UseSelectable = true;
            this.btnBuscarMesas.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mesas a Reservar";
            // 
            // clmMesa
            // 
            this.clmMesa.HeaderText = "Mesa #";
            this.clmMesa.Name = "clmMesa";
            this.clmMesa.ReadOnly = true;
            // 
            // clmUbicacion
            // 
            this.clmUbicacion.HeaderText = "Ubicacion";
            this.clmUbicacion.Name = "clmUbicacion";
            this.clmUbicacion.ReadOnly = true;
            // 
            // clmSillas
            // 
            this.clmSillas.HeaderText = "Cantidad Sillas";
            this.clmSillas.Name = "clmSillas";
            this.clmSillas.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 755);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarMesas);
            this.Controls.Add(this.dgvStands);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dgvStandsToReserve);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.nudSillas);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtpReservationDate);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.txtDetalle);
            this.Name = "ReservationForm";
            this.Resizable = false;
            this.Text = "Reservacion";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandsToReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtDetalle;
        private MetroFramework.Controls.MetroButton btnReservar;
        private System.Windows.Forms.DateTimePicker dtpReservationDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.NumericUpDown nudSillas;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton BtnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvStandsToReserve;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvStands;
        private MetroFramework.Controls.MetroButton btnBuscarMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReservationDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmAddStand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSillas;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}