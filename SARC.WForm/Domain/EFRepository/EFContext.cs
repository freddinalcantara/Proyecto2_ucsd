using SARC.WForm.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARC.WForm.Domain.EFRepository
{
    class EFContext : DbContext
    {

        
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cliente> Clients { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Stand> Stands { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
