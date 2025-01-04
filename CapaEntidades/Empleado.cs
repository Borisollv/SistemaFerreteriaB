using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int dni { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public string puesto { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public bool estado { get; set; }
    }
}
