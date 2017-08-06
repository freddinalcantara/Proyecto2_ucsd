using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARC.WForm.Domain.Models
{
    public class ErrorMessages
    {
        public static string STAND_IS_RESERVED
        {
            get
            {
                return "Ya hay una reserva para esta mesa";
            }
        }
    }
}
