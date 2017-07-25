using System.Collections.Generic;

namespace SARC.WForm.Domain.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberInStock { get; set; }

        public virtual ICollection<Combo> Combos { get; set; }
        public Food()
        {
            this.Combos = new HashSet<Combo>();
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}