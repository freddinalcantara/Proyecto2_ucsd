using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARC.WForm.Domain
{
    public interface IGridEventListener
    {
        void OnRowSelected(Object row);
    }
}
