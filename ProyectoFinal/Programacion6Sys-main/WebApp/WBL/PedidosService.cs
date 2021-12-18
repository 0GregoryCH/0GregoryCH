using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WBL
{
    public interface IPedidosService
    {
        Task<DBEntity> Create(PedidosEntity entity);
        Task<DBEntity> Delete(PedidosEntity entity);
        Task<IEnumerable<PedidosEntity>> Get();
        Task<PedidosEntity> GetById(PedidosEntity entity);
        Task<DBEntity> Update(PedidosEntity entity);



        Task<IEnumerable<PedidosEntity>> GetLista();
    }



    public class PedidosService : IPedidosService
    {
        private readonly IDataAccess sql;



        public PedidosService(IDataAccess _sql)
        {
            sql = _sql;
        }



        public async Task<IEnumerable<PedidosEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<PedidosEntity, ClientesEntity, ProductosEntity>
                ("PedidosObtener", "IdCodigo,IdCliente,IdProductos");



                return await result;



            }
            catch (Exception)
            {



                throw;
            }





        }



        public async Task<IEnumerable<PedidosEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<PedidosEntity>("PedidosLista");



                return await result;
            }
            catch (Exception EX)
            {



                throw;
            }
        }



        public async Task<PedidosEntity> GetById(PedidosEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<PedidosEntity>("PedidosObtener", new
                {
                    entity.IdCodigo
                });



                return await result;
            }
            catch (Exception)
            {



                throw;
            }




        }



        public async Task<DBEntity> Create(PedidosEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidosInsertar", new
                {
                    entity.IdCodigo,
                    entity.FechaPedido,
                    entity.Cantidad,
                    entity.SubTotal,
                    entity.Envio,
                    entity.Iva,
                    entity.Total

                });



                return await result;
            }
            catch (Exception)
            {



                throw;
            }




        }



        public async Task<DBEntity> Update(PedidosEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidosActualizar", new
                {
                    entity.IdCodigo,
                    entity.IdClientes,
                    entity.IdProductos,
                    entity.FechaPedido,
                    entity.Cantidad,
                    entity.SubTotal,
                    entity.Envio,
                    entity.Iva,
                    entity.Total

                });



                return await result;
            }
            catch (Exception)
            {



                throw;
            }

        }


        public async Task<DBEntity> Delete(PedidosEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidosEliminar", new
                {
                    entity.IdCodigo
                });



                return await result;
            }
            catch (Exception)
            {



                throw;
            }




        }
    }
}