using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARC.WForm.Forms
{
    public partial class Mesas : MetroFramework.Forms.MetroForm
    {
        private EFContext _dbContext;
        public Mesas()
        {
            InitializeComponent();
            _dbContext = new EFContext();
            RefreshList();
            //hide ID field
            dgridStands.Columns[0].Visible = false;
            rbtnActive.Checked = true;

        }

        private void RefreshList()
        {
            dgridStands.DataSource = _dbContext.Stands.ToList();
        }
        private void btnCreateStand_Click(object sender, EventArgs e)
        {
            if (ExistsStandNumber(decimal.ToInt32(nudStandNumber.Value)))
            {
                errorProvider1.SetError(nudStandNumber, "Numero de silla ya se encuentra registrado");
                return;
            }
            
            if (cmbLocations.SelectedItem != null && ExistsStandForLocation(cmbLocations.SelectedItem.ToString()))
            {
                errorProvider1.SetError(cmbLocations, String.Format("Ya existe una mesa en la ubicacion {0}.",cmbLocations.SelectedItem));
                return;
            }
            if(CreateOrUpdateStand())
                ClearForm();
        }
        /// <summary>
        ///  Returns true if a Stand already exists
        /// </summary>
        /// <param name="StandNumber">StandNumber</param>
        /// <returns></returns>
        private bool ExistsStandNumber(int StandNumber)
        {
            return _dbContext.Stands.FirstOrDefault(c => c.StandNumber == StandNumber) != null;
        }
        private bool ExistsStandForLocation(String location)
        {
            return _dbContext.Stands.FirstOrDefault(c => c.Location == location) != null;

        }
        private Boolean CreateOrUpdateStand()
        {
            errorProvider1.Clear();
            if (nudStandNumber.Value == 0)
            {
                errorProvider1.SetError(nudStandNumber, "Eliga el numero de mesa");
                return false;
            }
            if (nudSeatsNumber.Value == 0)
            {
                errorProvider1.SetError(nudSeatsNumber, "Eliga el numero de asientos");
                return false;
            }
            if(cmbLocations.SelectedIndex == -1 )
            {
                errorProvider1.SetError(cmbLocations, "Eliga la ubicacion de la mesa");
                return false;
            }
            Stand stand = BuildStandFromForm();
           
            UpdateStand(stand);
            RefreshList();
            return true;
        }
        
        private Stand BuildStandFromForm()
        {
            Stand stand = new Stand
            {
                Location = cmbLocations.SelectedItem.ToString(),
                StandNumber = Decimal.ToInt32(nudStandNumber.Value),
                seats = Decimal.ToInt32(nudSeatsNumber.Value),
                Status = rbtnActive.Checked
        };
            if(txtID.Text != "")
            {
                stand.Id = int.Parse(txtID.Text);
            }
            return stand;
        }

        /// <summary>
        /// Reset all values of the form to default
        /// </summary>
        private void ClearForm()
        {
            errorProvider1.Clear();
            nudStandNumber.Value = 0;
            nudSeatsNumber.Value = 0;
            cmbLocations.SelectedIndex = -1;
            btnEditSTand.Enabled = false;
            btnCreateStand.Enabled = true;
            rbtnActive.Checked = true;
        }

      

        private void UpdateStand(Stand stand)
        {
            var standToUpdate = _dbContext.Stands.FirstOrDefault(c => c.Id == stand.Id);

            if (standToUpdate == null)
            {
                _dbContext.Stands.Add(stand);
            }else
            {
                _dbContext.Entry(standToUpdate).CurrentValues.SetValues(stand);
            }
            _dbContext.SaveChanges();
        }

        private void dgridStands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditSTand.Enabled = true;
            btnCreateStand.Enabled = false;
            txtID.Text = dgridStands.SelectedCells[0].Value.ToString();
            nudStandNumber.Value = decimal.Parse(dgridStands.SelectedCells[1].Value.ToString());
            nudSeatsNumber.Value = decimal.Parse(dgridStands.SelectedCells[3].Value.ToString());
            cmbLocations.SelectedItem = dgridStands.SelectedCells[2].Value.ToString();
            bool status =(bool) dgridStands.SelectedCells[4].Value;
            if (status)
            {
                rbtnActive.Checked = true;
            } else
            {
                rbtnInactive.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnEditSTand_Click(object sender, EventArgs e)
        {
            //TODO: If the user edited the location of the stand it must validate that that location is not in use
           CreateOrUpdateStand();
            MessageBox.Show("Mesa actualizada correctamente");
        }

        private void Mesas_Load(object sender, EventArgs e)
        {

        }
    }
}
