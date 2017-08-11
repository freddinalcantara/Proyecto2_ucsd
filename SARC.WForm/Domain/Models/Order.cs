﻿using System;
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
        public String Status { get; set; }//PENDIENTE, PROCESADA
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrdenDetail> OrderDetails { get; set; }

        public Order()
        {
            this.OrderDetails = new HashSet<OrdenDetail>();
        }

        public decimal SubTotal()
        {
            decimal subtotal = 0;
            foreach (var orderDetail in OrderDetails)
            {
                subtotal += orderDetail.ItemPrice;
            }
            return subtotal;
        }

        public decimal Total()
        {
            return SubTotal() + SubTotal() * 0.18m;
        }
    }
}
