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
        public int StandId { get; set; }
        public string Details { get; set; }
        public DateTime InitDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
