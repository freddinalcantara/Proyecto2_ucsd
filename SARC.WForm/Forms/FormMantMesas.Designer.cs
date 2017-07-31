namespace SARC.WForm.Forms
{
    partial class Mesas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSeatsNumber = new System.Windows.Forms.NumericUpDown();
            this.btnCreateStand = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEditSTand = new MetroFramework.Controls.MetroButton();
            this.nudStandNumber = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgridStands = new MetroFramework.Controls.MetroGrid();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStandNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridStands)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ubicacion";
            // 
            // cmbLocations
            // 
            this.cmbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "C3"});
            this.cmbLocations.Location = new System.Drawing.Point(116, 104);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(100, 21);
            this.cmbLocations.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero de sillas";
            // 
            // nudSeatsNumber
            // 
            this.nudSeatsNumber.Location = new System.Drawing.Point(116, 144);
            this.nudSeatsNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSeatsNumber.Name = "nudSeatsNumber";
            this.nudSeatsNumber.Size = new System.Drawing.Size(100, 20);
            this.nudSeatsNumber.TabIndex = 6;
            // 
            // btnCreateStand
            // 
            this.btnCreateStand.Location = new System.Drawing.Point(26, 201);
            this.btnCreateStand.Name = "btnCreateStand";
            this.btnCreateStand.Size = new System.Drawing.Size(75, 23);
            this.btnCreateStand.TabIndex = 31;
            this.btnCreateStand.Text = "Crear Mesa";
            this.btnCreateStand.UseSelectable = true;
            this.btnCreateStand.Click += new System.EventHandler(this.btnCreateStand_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(232, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Cancelar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditSTand
            // 
            this.btnEditSTand.Enabled = false;
            this.btnEditSTand.Location = new System.Drawing.Point(116, 201);
            this.btnEditSTand.Name = "btnEditSTand";
            this.btnEditSTand.Size = new System.Drawing.Size(100, 23);
            this.btnEditSTand.TabIndex = 32;
            this.btnEditSTand.Text = "Editar";
            this.btnEditSTand.UseSelectable = true;
            this.btnEditSTand.Click += new System.EventHandler(this.btnEditSTand_Click);
            // 
            // nudStandNumber
            // 
            this.nudStandNumber.Location = new System.Drawing.Point(116, 68);
            this.nudStandNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStandNumber.Name = "nudStandNumber";
            this.nudStandNumber.Size = new System.Drawing.Size(100, 20);
            this.nudStandNumber.TabIndex = 35;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // dgridStands
            // 
            this.dgridStands.AllowUserToResizeRows = false;
            this.dgridStands.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgridStands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridStands.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgridStands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridStands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridStands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridStands.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgridStands.EnableHeadersVisualStyles = false;
            this.dgridStands.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgridStands.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgridStands.Location = new System.Drawing.Point(23, 230);
            this.dgridStands.MultiSelect = false;
            this.dgridStands.Name = "dgridStands";
            this.dgridStands.ReadOnly = true;
            this.dgridStands.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridStands.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgridStands.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgridStands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridStands.Size = new System.Drawing.Size(432, 170);
            this.dgridStands.TabIndex = 36;
            this.dgridStands.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridStands_CellDoubleClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(232, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 37;
            this.txtID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Estatus";
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Location = new System.Drawing.Point(3, 8);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(67, 17);
            this.rbtnActive.TabIndex = 39;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Activada";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnInactive);
            this.panel1.Controls.Add(this.rbtnActive);
            this.panel1.Location = new System.Drawing.Point(116, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 25);
            this.panel1.TabIndex = 41;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(76, 8);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(85, 17);
            this.rbtnInactive.TabIndex = 40;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Desactivada";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgridStands);
            this.Controls.Add(this.nudStandNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditSTand);
            this.Controls.Add(this.btnCreateStand);
            this.Controls.Add(this.nudSeatsNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLocations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.Mesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStandNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridStands)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSeatsNumber;
        private MetroFramework.Controls.MetroButton btnCreateStand;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEditSTand;
        private System.Windows.Forms.NumericUpDown nudStandNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroGrid dgridStands;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}