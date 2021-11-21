using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IProductoService
    {
        Task<IEnumerable<ProductoEntity>> GetLista();
    }

    public class ProductoService : IProductoService
    {
        private readonly IDataAccess sql;

        public ProductoService(IDataAccess _sql)
        {
            sql = _sql;
        }


        public async Task<IEnumerable<ProductoEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<ProductoEntity>("ProductoLista");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }
    }
}
