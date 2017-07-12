namespace SARC.WForm
{
    partial class Form1
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(11, 65);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(617, 82);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Orden";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(11, 153);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(617, 82);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Reservaciones";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(11, 241);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(617, 82);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Clientes";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(11, 329);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(617, 82);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Facturas";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(11, 417);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(617, 82);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = "Combos";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 519);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form1";
            this.Text = "SARC";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}

