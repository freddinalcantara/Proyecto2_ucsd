using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARC.WForm.Domain.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public Order Orden { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public int ComboCount { get; set; }
    }
}
