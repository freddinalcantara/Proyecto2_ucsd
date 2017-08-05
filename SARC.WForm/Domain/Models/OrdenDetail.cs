using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SARC.WForm.Domain.Models
{
    public class OrdenDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Item { get; set; }
        public decimal ItemPrice { get; set; }
        public virtual Order Order { get; set; }
    }
}