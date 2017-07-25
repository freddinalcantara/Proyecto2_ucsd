using System.Collections.Generic;

namespace SARC.WForm.Domain.Models
{
    public class Combo
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public Combo()
        {
            this.Foods = new HashSet<Food>();
        }
    }
}