using DataAccess;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class DLDonacion
    {
        DADonacion _dn = new DADonacion();
        public int AgregarDonacion(Donacion donacion)
        {
            return _dn.AgregarDonacion(donacion);
        }
        public List<Donacion> ConsultarDonacionesID(string id)
        {
            return _dn.ConsultarDonacionesID(id);
        }
    }
}
