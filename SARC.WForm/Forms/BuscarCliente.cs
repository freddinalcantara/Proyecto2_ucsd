﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;

namespace SARC.WForm.Forms
{
    public partial class BuscarCliente : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext;

        public BuscarCliente()
        {
            InitializeComponent();
            _dbContext = new EFContext();
            metroGrid1.DataSource = _dbContext.Clients.ToList();
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FormCliente formulario = new FormCliente();
            formulario.Show();
        }

    }
}
