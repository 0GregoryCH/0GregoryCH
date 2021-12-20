using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;





namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly ICompraService CompraService;





        public CompraController(ICompraService CompraService)
        {
            this.CompraService = CompraService;
        }
        //se construyen los metodos
        [HttpGet]
        public async Task<IEnumerable<CompraEntity>> Get()
        {
            try
            {





                return await CompraService.Get();
            }
            catch (Exception ex)
            {





                return new List<CompraEntity>();
            }







        }
        [HttpGet("{id}")]
        public async Task<CompraEntity> Get(int id)
        {
            try
            {





                return await CompraService.GetById(new CompraEntity { IdCompra = id });
            }
            catch (Exception ex)
            {





                return new CompraEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }







        }
        [HttpPost]
        public async Task<DBEntity> Create(CompraEntity entity)
        {
            try
            {





                return await CompraService.Create(entity);
            }
            catch (Exception ex)
            {





                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }





        }
        [HttpPut]
        public async Task<DBEntity> Update(CompraEntity entity)
        {
            try
            {





                return await CompraService.Update(entity);
            }
            catch (Exception ex)
            {





                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }





        }
        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {





                return await CompraService.Delete(new CompraEntity { IdCompra = id });
            }
            catch (Exception ex)
            {





                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }





        }
    }
}