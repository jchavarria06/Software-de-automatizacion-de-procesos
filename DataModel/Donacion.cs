using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Donacion
    {
        public int idDonacion { get; set; }
        public decimal monto { get; set; }
        public DateTime fecha { get; set; }
        public string codigoAnimal { get; set; }
        public int idUsuario { get; set; }
    }
}
