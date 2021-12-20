using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoEntity : EN
    {
       
        public ProductoEntity()
        {
            Compra = Compra ?? new CompraEntity();
        }
        public int? IdCompra { get; set; }
        public virtual CompraEntity Compra { get; set; }

        public int? ProductoId { get; set; }


        public string Descripcion { get; set; }

        

    }
}
