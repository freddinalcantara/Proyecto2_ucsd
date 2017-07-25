﻿using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARC.WForm
{
    public partial class ComboForm : MetroFramework.Forms.MetroForm
    {
        public List<String> _comida = new List<String>();
        private EFContext _dbContext;
        
        public ComboForm()
        {
            //TODO: Show next combo number to create
            //TODO: Load combos in the table
            //TODO: Edit Combo
            //TODO: Delete Combo

            InitializeComponent();
            _dbContext = new EFContext();
            foreach (var food in _dbContext.Foods.Where(f=>f.NumberInStock > 0))
            {
                LbAlimentos.Items.Add(food);
            }
            
        }

        private void ComboForm_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SwapItemsList(LbCombos, LbAlimentos);
        }

        private void SwapItemsList(ListBox from, ListBox to)
        {
            Object[] items = new Object[from.SelectedItems.Count];
            from.SelectedItems.CopyTo(items, 0);

            foreach (var item in items)
            {
                to.Items.Add(item);
                from.Items.Remove(item);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void BtnAddToCombo_Click(object sender, EventArgs e)
        {
            SwapItemsList(LbAlimentos, LbCombos);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            //TODO: Validate price is not blank
            //TODO: Validate price is a numeric value
            Combo combo = new Combo();
            combo.Price = Int32.Parse(txtPrice.Text);
            foreach (Food food in LbCombos.Items)
            {
                combo.Foods.Add(food);
            }
            _dbContext.Combos.Add(combo);
            _dbContext.SaveChanges();
            //combo.Foods.Add
        }
    }
}
