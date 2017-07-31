﻿using SARC.WForm.Domain.EFRepository;
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
    public partial class OrderForm : MetroFramework.Forms.MetroForm
    {
        //inicianlizando variables privadas
        private EFContext _dbContext = new EFContext();
        public OrderForm()
        {
            InitializeComponent();
            BuscarCliente form = new BuscarCliente();
            form.Show();
            metroComboBox1.DataSource = _dbContext
                .Stands
                .Where(s=>s.Status == true)
                .AsEnumerable()
                .Select(stand => stand.StandNumber)
                .ToList();
            listBox1.DataSource = _dbContext
                    .Combos
                    .Select(c=>c.Id)
                    .ToList();
            //llenamos la lista de comidas que son extra
            listBox3.DataSource = _dbContext.Foods.Where(f => f.NumberInStock > 0).Select(f => f.Name).ToList();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboNumber = Int32.Parse(listBox1.SelectedItem.ToString());
            var FoodList = _dbContext.Combos.Where(c => c.Id == comboNumber).FirstOrDefault();
            var query = (from f in _dbContext.Foods where f.Combos.Any(c => c.Id == FoodList.Id) select f.Name).ToList();
            listBox2.DataSource = query;
        }
    }
}
