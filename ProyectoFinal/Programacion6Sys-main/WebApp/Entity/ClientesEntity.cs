using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClientesEntity
    {
        public string MsgError;

        public ClientesEntity()
        {
            Pedidos = Pedidos ?? new PedidosEntity();
        }

        public int? IdClientes { get; set; }
        public int? IdCodigo { get; set; }
        public virtual PedidosEntity Pedidos { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public int CodeError { get; set; }
    }
}
