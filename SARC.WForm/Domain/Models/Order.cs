using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARC.WForm.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string TipoOrden { get; set; }
        public Stand Stand { get; set; }
        public List<Combo> Combo { get; set; }
    }
}
