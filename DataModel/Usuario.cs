using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Username { get; set; }
        public string Correo { get; set; }
        public string Cedula { get; set; }
        public string Pass { get; set; }
    }
}
