using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Pedidos
{
    public class EditModel : PageModel
    {
        private readonly IPedidosService PedidosService;
        private readonly IClientesService ClientesService;
        private readonly IProductosService ProductosService;

        public EditModel(IPedidosService PedidosService, IClientesService ClientesService, IProductosService ProductosService)
        {
            this.ClientesService = ClientesService;
            this.PedidosService = PedidosService;
            this.ProductosService = ProductosService;
        }

        [BindProperty]
        [FromBody]

        public PedidosEntity Entity { get; set; } = new PedidosEntity();

        public IEnumerable<ClientesEntity> ClientesLista { get; set; } = new List<ClientesEntity>();
        public IEnumerable<ProductosEntity> ProductosLista { get; set; } = new List<ProductosEntity>();

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet(IEnumerable<ProductosEntity> ProductosLista)
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await PedidosService.GetById(new() { IdCodigo = id });
                }

                ClientesLista = await ClientesService.GetLista();
                ProductosLista = await ProductosService.GetLista();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


        }

        public async Task<IActionResult> OnPost()
        {

            try
            {
                var result = new DBEntity();
                if (Entity.IdCodigo.HasValue)
                {
                    result = await PedidosService.Update(Entity);


                }
                else
                {
                    result = await PedidosService.Create(Entity);

                }

                return new JsonResult(result);
            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }


        }

    }
}
