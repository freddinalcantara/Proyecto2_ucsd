namespace SARC.WForm
{
    partial class ComboForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtComboName = new MetroFramework.Controls.MetroTextBox();
            this.LbAlimentos = new System.Windows.Forms.ListBox();
            this.BtnRemoveFCombo = new MetroFramework.Controls.MetroButton();
            this.BtnAddToCombo = new MetroFramework.Controls.MetroButton();
            this.LbCombos = new System.Windows.Forms.ListBox();
            this.LblListadoAlimentos = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtComboName
            // 
            // 
            // 
            // 
            this.TxtComboName.CustomButton.Image = null;
            this.TxtComboName.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.TxtComboName.CustomButton.Name = "";
            this.TxtComboName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtComboName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtComboName.CustomButton.TabIndex = 1;
            this.TxtComboName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtComboName.CustomButton.UseSelectable = true;
            this.TxtComboName.CustomButton.Visible = false;
            this.TxtComboName.Lines = new string[0];
            this.TxtComboName.Location = new System.Drawing.Point(37, 96);
            this.TxtComboName.MaxLength = 32767;
            this.TxtComboName.Name = "TxtComboName";
            this.TxtComboName.PasswordChar = '\0';
            this.TxtComboName.ReadOnly = true;
            this.TxtComboName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtComboName.SelectedText = "";
            this.TxtComboName.SelectionLength = 0;
            this.TxtComboName.SelectionStart = 0;
            this.TxtComboName.ShortcutsEnabled = true;
            this.TxtComboName.Size = new System.Drawing.Size(223, 23);
            this.TxtComboName.TabIndex = 0;
            this.TxtComboName.UseSelectable = true;
            this.TxtComboName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtComboName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LbAlimentos
            // 
            this.LbAlimentos.FormattingEnabled = true;
            this.LbAlimentos.Location = new System.Drawing.Point(37, 144);
            this.LbAlimentos.Name = "LbAlimentos";
            this.LbAlimentos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbAlimentos.Size = new System.Drawing.Size(223, 147);
            this.LbAlimentos.TabIndex = 2;
            // 
            // BtnRemoveFCombo
            // 
            this.BtnRemoveFCombo.Location = new System.Drawing.Point(266, 228);
            this.BtnRemoveFCombo.Name = "BtnRemoveFCombo";
            this.BtnRemoveFCombo.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveFCombo.TabIndex = 3;
            this.BtnRemoveFCombo.Text = "<";
            this.BtnRemoveFCombo.UseSelectable = true;
            this.BtnRemoveFCombo.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BtnAddToCombo
            // 
            this.BtnAddToCombo.Location = new System.Drawing.Point(266, 190);
            this.BtnAddToCombo.Name = "BtnAddToCombo";
            this.BtnAddToCombo.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToCombo.TabIndex = 4;
            this.BtnAddToCombo.Text = ">";
            this.BtnAddToCombo.UseSelectable = true;
            this.BtnAddToCombo.Click += new System.EventHandler(this.BtnAddToCombo_Click);
            // 
            // LbCombos
            // 
            this.LbCombos.FormattingEnabled = true;
            this.LbCombos.Location = new System.Drawing.Point(347, 144);
            this.LbCombos.Name = "LbCombos";
            this.LbCombos.Size = new System.Drawing.Size(223, 147);
            this.LbCombos.TabIndex = 5;
            // 
            // LblListadoAlimentos
            // 
            this.LblListadoAlimentos.AutoSize = true;
            this.LblListadoAlimentos.Location = new System.Drawing.Point(35, 122);
            this.LblListadoAlimentos.Name = "LblListadoAlimentos";
            this.LblListadoAlimentos.Size = new System.Drawing.Size(131, 19);
            this.LblListadoAlimentos.TabIndex = 6;
            this.LblListadoAlimentos.Text = "Listado de Alimentos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(345, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Combo";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(347, 482);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(105, 23);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "Cancelar";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(35, 67);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(535, 23);
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "Combos ";
            this.metroTile1.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(467, 482);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(105, 23);
            this.metroButton5.TabIndex = 13;
            this.metroButton5.Text = "Guardar";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(236, 482);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(105, 23);
            this.metroButton6.TabIndex = 12;
            this.metroButton6.Text = "Eliminar";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(467, 454);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(103, 23);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(406, 454);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Precio";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(37, 315);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(533, 136);
            this.metroGrid1.TabIndex = 16;
            // 
            // ComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 527);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.LblListadoAlimentos);
            this.Controls.Add(this.LbCombos);
            this.Controls.Add(this.BtnAddToCombo);
            this.Controls.Add(this.BtnRemoveFCombo);
            this.Controls.Add(this.LbAlimentos);
            this.Controls.Add(this.TxtComboName);
            this.Name = "ComboForm";
            this.Resizable = false;
            this.Text = "Manejo de Combos";
            this.Load += new System.EventHandler(this.ComboForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtComboName;
        private System.Windows.Forms.ListBox LbAlimentos;
        private MetroFramework.Controls.MetroButton BtnRemoveFCombo;
        private MetroFramework.Controls.MetroButton BtnAddToCombo;
        private System.Windows.Forms.ListBox LbCombos;
        private MetroFramework.Controls.MetroLabel LblListadoAlimentos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}