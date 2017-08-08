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
        List<int> StandsSelected;
        public ReservationForm()
        {
            InitializeComponent();
            _dbContext = new EFContext();
            StandsSelected = new List<int>();
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



        private void dgvStands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //TODO: Change Name
        /// <summary>
        /// find all stands and fill the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton2_Click(object sender, EventArgs e)
        {
            dgvStands.Rows.Clear();
            var Stands = _dbContext.Stands.Where(s => s.Status == true);
            foreach (var Stand in Stands)

            {
                Reservation reservation = ReservationForStand(Stand, dtpReservationDate.Value);


                int index = dgvStands.Rows.Add(Stand.StandNumber, Stand.Location, Stand.seats);
                DataGridViewRow newRow = dgvStands.Rows[index];
                if (reservation != null)
                {
                    newRow.Cells[3].Value = reservation.Status;
                    newRow.Cells[4].Value = reservation.ReservationDate;
                }
                else
                {
                    newRow.Cells[3].Value = "Libre";
                    newRow.Cells[4].Value = "-";
                }


            }
            dgvStands.Refresh();
        }
        /// <summary>
        /// Find the reservation for an stand for a specific Date
        /// </summary>
        /// <param name="stand"></param>
        /// <param name="reservationDate"></param>
        /// <returns>Reservation for the stand passed as parameter</returns>
        private Reservation ReservationForStand(Stand stand, DateTime reservationDate)
        {
            var reservation = _dbContext.Reservations.Where(
                                  r => r.Stand.Id == stand.Id
                                  && r.Status == "RESERVADA"
                                  && r.ReservationDate.Year == reservationDate.Year
                                  && r.ReservationDate.Month == reservationDate.Month
                                  && r.ReservationDate.Day == reservationDate.Day
                                  )
                                                                .FirstOrDefault();

            return reservation;
        }

        /// <summary>
        /// Event when the user Click on the Agregar Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ignore all clicks that are not in our button
            if (e.ColumnIndex == dgvStands.Columns[5].Index && e.RowIndex != -1)
            {
                var StandLocation = dgvStands.Rows[e.RowIndex].Cells[1].Value.ToString();
                var StandSeats = Int32.Parse(dgvStands.Rows[e.RowIndex].Cells[2].Value.ToString());

                var StandNumber = Int32.Parse(dgvStands.Rows[e.RowIndex].Cells[0].Value.ToString());
                string cellReservationDate = dgvStands.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (cellReservationDate != "-")
                {
                    DateTime reservationDate = DateTime.Parse(cellReservationDate);
                    if (OverLapReservation(reservationDate, dtpReservationDate.Value))
                    {
                        MessageBox.Show(ErrorMessages.STAND_IS_RESERVED);
                        return;
                    }
                }
                if (StandsSelected.Contains(StandNumber))
                {
                    MessageBox.Show("Esta Mesa Ya se encuentra seleccionada");
                    return;
                }

                dgvStandsToReserve.Rows.Add(StandNumber, StandLocation, StandSeats);
                StandsSelected.Add(StandNumber);
            }

            dgvStandsToReserve.Refresh();
        }
        /// <summary>
        /// Returns true if the DateToReserver is higher than the reservation Date
        /// </summary>
        /// <param name="reservation"></param>
        /// <param name="dateToReserve"></param>
        /// <returns></returns>
        private bool OverLapReservation(DateTime reservation, DateTime dateToReserve)
        {
            return dateToReserve >= reservation;
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
            //if (txtCliente.Text == "")
            //{
            //    MessageBox.Show("Se necesita un cliente para Reservar");
            //    return;
            //}

            if (StandsSelected.Count() == 0)
            {
                MessageBox.Show("No mesas selecionadas");
                return;
            }
            if(nudSillas.Value == 0)
            {
                MessageBox.Show("Elegir la cantidad de sillas a reservar");
                return;
            }
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
            if (TotalChair < nudSillas.Value)
            {
                MessageBox.Show("Numero de sillas menor a la que solicita el cliente");
                return;
            }
            if (dtpReservationDate.Value == null)
            {
                MessageBox.Show("Se necesesita una fecha");
                return;
            }
            //Cliente client = _dbContext.Clients.First(c=> c.Id ==9);
              for (int i = 0; i < StandsSelected.Count(); i++)
            {
                ReservacionFinal = new Reservation();
                ///ReservacionFinal.Client = SelectedClient;
                ReservacionFinal.Details = txtDetalle.Text;
                int StandNumber = Int32.Parse(dgvStands.Rows[i].Cells[0].Value.ToString());
                Stand stand = _dbContext.Stands.First(s => s.StandNumber == StandNumber);
                ReservacionFinal.Chairs = int.Parse(nudSillas.Value.ToString());
                ReservacionFinal.ReservationDate = dtpReservationDate.Value;
                ReservacionFinal.Status = StandStatus.RESERVADA;
                ReservacionFinal.Stand = stand;
                ReservacionFinal.CreatedAt = DateTime.Now;
                ReservacionFinal.Client = _dbContext.Clients.FirstOrDefault(c => c.Cedula == SelectedClient.Cedula);
                //SelectedClient.Reservations.Add(ReservacionFinal);
                _dbContext.Reservations.Add(ReservacionFinal);
            
            }
            //_dbContext.Clients.Attach(SelectedClient);
            //_dbContext.Entry(SelectedClient).State = EntityState.Modified;

            _dbContext.SaveChanges();
            LimpiarPantalla();
       
            

        }

        private void LimpiarPantalla()
        {
            dgvStands.Rows.Clear();
            dgvStandsToReserve.Rows.Clear();
            nudSillas.Value = 0;
            txtCliente.Clear();
            txtDetalle.Clear();
        }

        private void dtpReservationDate_ValueChanged(object sender, EventArgs e)
        {
            dgvStandsToReserve.Rows.Clear();
            dgvStands.Rows.Clear();
        }
        /// <summary>
        /// Cell Click Event when the user remove a selected stand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStandsToReserve_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvStandsToReserve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStandsToReserve.Columns[3].Index && e.RowIndex != -1)
            {
                var StandNumber = Int32.Parse(dgvStandsToReserve.Rows[e.RowIndex].Cells[0].Value.ToString());
                StandsSelected.Remove(StandNumber);
                dgvStandsToReserve.Rows.Remove(this.dgvStandsToReserve.Rows[e.RowIndex]);
            }
        }
    }
}
