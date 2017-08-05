using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARC.WForm
{
    public partial class ReservationForm : MetroFramework.Forms.MetroForm
    {

        private EFContext _dbContext;

        public ReservationForm()
        {
            InitializeComponent();
            _dbContext = new EFContext();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvStands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var Stands = _dbContext.Stands.Where(s => s.Status == true);
            foreach (var Stand in Stands)

            {
                Reservation reservation = ReservationForStand(Stand, dtpReservationDate.Value);
                DataGridViewRow newRow = (DataGridViewRow)dgvStands.Rows[0].Clone();
                newRow.Cells[0].Value = Stand.StandNumber;
                newRow.Cells[1].Value = Stand.Location;
                newRow.Cells[2].Value = Stand.seats;

                dgvStands.Rows.Add(newRow);

            }
            dgvStands.Refresh();
        }

        private Reservation ReservationForStand(Stand stand, DateTime reservationDate)
        {
            //var reservation = _dbContext.Reservations.Where(r => r.Stand.Id == stand.Id
            //                              && r.Status == "PENDIENTE"
            //                              && DbFunctions.CreateDateTime(r.ReservationDate.Year, r.ReservationDate.Date.Month, r.ReservationDate.Day, 0, 0, 0) == reservationDate.Date
            //                               ).FirstOrDefault();
            //                              //&& r--eservationDate.Hour > r.ReservationDate.Hour).FirstOrDefault();
            
              var reservation =   _dbContext.Reservations.Where(r => r.Stand.Id == stand.Id
            && DbFunctions.CreateDateTime(r.ReservationDate.Year, r.ReservationDate.Month, r.ReservationDate.Day, r.ReservationDate.Hour, r.ReservationDate.Minute, r.ReservationDate.Second) <= reservationDate.Date).FirstOrDefault();

            return reservation;

        }

        private void dgvStands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(string.Format("{0}::{1}::{2}", e.ColumnIndex,dgvStands.Columns[5].Index,e.RowIndex));
            //ignore all clicks that are not in our button
            if (e.ColumnIndex == dgvStands.Columns[5].Index)
            {
                //MessageBox.Show(string.Format("{0}",dgvStands.Rows[e.RowIndex].));

                //var StandNumber = dgvStands.Rows[e.RowIndex].Cells[0].Value;


            }
        }
    }
}
