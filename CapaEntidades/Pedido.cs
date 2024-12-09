using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public DateTime fechaPedido { get; set; }
        public int idCliente { get; set; }
    }
}
