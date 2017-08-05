using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARC.WForm.Domain.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Cliente Client { get; set; }
        public int Chairs { get; set; }
        public string Details { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public String Status { get; set; }
        public virtual Stand Stand { get; set; }
        

    }
}
