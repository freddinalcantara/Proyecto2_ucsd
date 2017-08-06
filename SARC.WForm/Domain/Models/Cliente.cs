using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SARC.WForm.Domain.Models
{
    public class Cliente
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Celphone { get; set; }
        public string FullName { get { return Name + " " + LastName; } }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public Cliente()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    }
}