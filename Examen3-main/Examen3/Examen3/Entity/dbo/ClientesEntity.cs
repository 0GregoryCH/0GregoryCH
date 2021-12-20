using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClientesEntity : EN
    {
        public ClientesEntity()
        {
            Compra = Compra ?? new CompraEntity();
        }
        public int? IdCompra { get; set; }
        public virtual CompraEntity Compra { get; set; }
        public int? ClientesId { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}

