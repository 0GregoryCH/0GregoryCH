using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class PedidosEntity
    {
        public string MsgError;
        public PedidosEntity()
        {
            Productos = Productos ?? new ProductosEntity();
            Clientes = Clientes ?? new ClientesEntity();

        }


        public int? IdCodigo { get; set; }
        public int? IdProductos { get; set; }
        public virtual ProductosEntity Productos { get; set; }
        public int? IdClientes { get; set; }
        public virtual ClientesEntity Clientes { get; set; }
        public DateTime FechaPedido { get; set; }
        public int? Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Envio { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public int CodeError { get; set; }

    }
}