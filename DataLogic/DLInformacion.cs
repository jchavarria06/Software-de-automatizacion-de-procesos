using DataAccess;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class DLInformacion
    {
        DAInformacion _dai = new DAInformacion();
        public int AgregarArchivo(Archivo archivo) {
            return _dai.AgregarArchivo(archivo);
        }

        public List<Archivo> ConsultarArchivos() {
            return _dai.ConsultarArchivos();
        }

        public Archivo ObtenerArchivo(string nombre)
        {
            return _dai.ObtenerArchivo(nombre);
        }
    }
}
