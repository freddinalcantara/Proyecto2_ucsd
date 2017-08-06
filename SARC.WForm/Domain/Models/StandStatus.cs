using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARC.WForm.Domain.Models
{
    public class StandStatus
    {
        public static string RESERVADA { get { return "RESERVADA"; } }
        public static string COMPLETADO { get { return "COMPLETADO"; } }
        public static string CANCELADO { get { return "CANCELADO"; } }

    }
}
