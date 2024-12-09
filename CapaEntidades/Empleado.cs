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
            public String nombres { get; set; }
            public String apellidos { get; set; }
            public int dni { get; set; }
            public String correo { get; set; }
            public String celular { get; set; }
            public String puesto { get; set; }
            public String usuario { get; set; }
            public String contrasena { get; set; }
            public Boolean estado { get; set; }
        }
    }
