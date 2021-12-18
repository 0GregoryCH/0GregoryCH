using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductosEntity
    {
        public string MsgError;
        public ProductosEntity()
        {
            Pedidos = Pedidos ?? new PedidosEntity();
        }

        public int? IdProductos { get; set; }
        public int? IdCodigo { get; set; }
        public virtual PedidosEntity Pedidos { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public int? CantidadDisponible { get; set; }
        public string Caracteristicas { get; set; }
        public bool Estado { get; set; }
        public int CodeError { get; set; }
    }
}