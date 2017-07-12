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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(37, 96);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(354, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "Numero de Combo";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 147);
            this.listBox1.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(278, 200);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "<";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(278, 158);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = ">";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(366, 125);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(223, 147);
            this.listBox2.TabIndex = 5;
            // 
            // ComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 458);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "ComboForm";
            this.Text = "Combos";
            this.Load += new System.EventHandler(this.ComboForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ListBox listBox2;
    }
}