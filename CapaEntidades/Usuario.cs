namespace CapaEntidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombres { get; set; } = string.Empty;
        public string contrasena { get; set; } = string.Empty;
        public string nombrecompleto { get; set; } = string.Empty;
        public string correoelectronico { get; set; } = string.Empty;
        public bool estado { get; set; }
    }

}