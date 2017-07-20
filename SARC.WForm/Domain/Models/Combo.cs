using System.Collections.Generic;

namespace SARC.WForm.Domain.Models
{
    public class Combo
    {
        public int Id { get; set; }
        public List<Food> Foods { get; set; }
        public decimal Price { get; set; }
    }
}