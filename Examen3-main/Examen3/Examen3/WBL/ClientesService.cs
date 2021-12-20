using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IClientesService
    {
        Task<DBEntity> Create(ClientesEntity entity);
        Task<DBEntity> Delete(ClientesEntity entity);
        Task<IEnumerable<ClientesEntity>> Get();
        Task<ClientesEntity> GetById(ClientesEntity entity);
        Task<DBEntity> Update(ClientesEntity entity);
        Task<IEnumerable<ClientesEntity>> GetLista();
    }

    public class ClientesService : IClientesService
    {
        private readonly IDataAccess sql;

        public ClientesService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<ClientesEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ClientesEntity, CompraEntity>("acc.ClientesObtener", "ClientesId,IdCompra");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<ClientesEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<ClientesEntity>("ClientesLista");



                return await result;
            }
            catch (Exception EX)
            {



                throw;
            }
        }

        //Metodo GetById
        public async Task<ClientesEntity> GetById(ClientesEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ClientesEntity>("acc.ClientesObtener", new
                { entity.ClientesId });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("acc.ClientesInsertar", new
                {
                    entity.ClientesId,
                    entity.NombreCompleto,
                    entity.Direccion,
                    entity.Telefono


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("acc.ClientesActualizar", new
                {
                    entity.ClientesId,
                    entity.NombreCompleto,
                    entity.Direccion,
                    entity.Telefono


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("acc.ClientesEliminar", new
                {
                    entity.ClientesId,



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }






        #endregion
    }
}
