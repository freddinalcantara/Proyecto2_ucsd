using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARC.WForm.Domain.Models
{
    public class Usuarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string codigo_usuario { get; set; }
        public string password { get; set; }
        public bool estatus { get; set; }
        public int Rol { get; set; }
        public DateTime Fecha_creacion{ get; set; }
    }
}
