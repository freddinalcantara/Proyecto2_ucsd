using SARC.WForm.Domain;
using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;
using SARC.WForm.Forms;
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
    public partial class ReservationForm : MetroFramework.Forms.MetroForm, IGridEventListener
    {

        private EFContext _dbContext;
        Cliente SelectedClient;
        Reservation ReservacionFinal;
        //List<Stand> StandList;
        public ReservationForm()
        {
            InitializeComponent();
            _dbContext = new EFContext();
            //StandList = new List<Stand>();
        }
        /// <summary>
        ///     Buscar el cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente form = new BuscarCliente(this);
            form.Show();
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
                if(reservation!= null)
                {
                    newRow.Cells[3].Value = reservation.Status;
                    newRow.Cells[4].Value = reservation.ReservationDate;
                }
                else
                {
                    newRow.Cells[3].Value = "Libre";
                    newRow.Cells[4].Value = "-";
                }
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
                //dgvStands.Rows[e.RowIndex].Cells[5].DataGridView.Enabled = false;

                var StandNumber = Int32.Parse(dgvStands.Rows[e.RowIndex].Cells[0].Value.ToString());
                var Stand = _dbContext.Stands.FirstOrDefault(s=>s.StandNumber == StandNumber);
                DataGridViewRow newRow = (DataGridViewRow)dgvStandsToReserve.Rows[0].Clone();
                newRow.Cells[0].Value = Stand.StandNumber;
                newRow.Cells[1].Value = Stand.Location;
                newRow.Cells[2].Value = Stand.seats;
                //StandList.Add(Stand);
                dgvStandsToReserve.Rows.Add(newRow);
            }

            dgvStandsToReserve.Refresh();
        }

        public void OnRowSelected(object row)
        {
            SelectedClient = ((Cliente)row);
            txtCliente.Text = SelectedClient.FullName;
        }

        public void OnRowSelectedExtraFood(object row)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Realizacion de una reserva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservar_Click(object sender, EventArgs e)
        {
            var CountOfStand = dgvStandsToReserve.RowCount;
            for (int i = 0; i < CountOfStand-1; i++)
            {
                if (txtCliente.Text == "")
                {
                    MessageBox.Show("Se necesita un cliente para Reservar");
                }
                else
                {
                    ReservacionFinal = new Reservation();
                    ReservacionFinal.Client = SelectedClient;
                    ReservacionFinal.Details = txtDetalle.Text;
                    


                   //Obtener la cantidad total de sillas de las mesas que se tomaron para la reservacion
                   int TotalChair = 0;
                    var CountOfChairs = dgvStandsToReserve.Rows
                              .OfType<DataGridViewRow>()
                              .Where(x => x.Cells[2].Value != null)
                              .Select(x => x.Cells[2].Value)
                              .ToList();
                    foreach (int chair in CountOfChairs)
                    {
                        TotalChair += chair;
                    }
                    if (nudSillas.Value > TotalChair)
                    {
                        MessageBox.Show("Numero de sillas menor a la que solicita el cliente");
                    }
                    else
                    {
                        ReservacionFinal.Chairs = int.Parse(nudSillas.Value.ToString());
                    }
                    if (dtpReservationDate.Value == null)
                    {
                        MessageBox.Show("Se necesesita una fecha");
                    }
                    else
                    {
                        ReservacionFinal.ReservationDate = dtpReservationDate.Value;
                    }
                    ReservacionFinal.Status = "OCUPADA";
                }
                ReservacionFinal.CreatedAt = DateTime.Now;
               

                _dbContext.Reservations.Add(ReservacionFinal);
                _dbContext.SaveChanges();
            }



        }
    }
}
