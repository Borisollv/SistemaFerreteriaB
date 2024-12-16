using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class Usuario
    {
        public int idUsuario { get; set; }
        public string nombres { get; set; } = string.Empty;
        public string contrasena { get; set; } = string.Empty;
        public string nombrecompleto { get; set; } = string.Empty;
        public string correoelectronico { get; set; } = string.Empty;
        public bool estado { get; set; }

    }
}
