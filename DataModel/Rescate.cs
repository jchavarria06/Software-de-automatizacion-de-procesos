using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Rescate
    {
        public int IDRescate { get; set; }
        public string CodigoAnimal { get; set; }
        public string LugarRescate { get; set; }
        public DateTime FechaRescate { get; set; }
        public string EspecieAnimal { get; set; }
        public string NombreQuienReporta { get; set; }
        public string Descripcion { get; set; }
        public int IDUsuario { get; set; }
    }
}
