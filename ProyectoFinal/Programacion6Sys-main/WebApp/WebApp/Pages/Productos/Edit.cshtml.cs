using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Productos
{
    public class EditModel : PageModel
    {
        private readonly IProductosService ProductosService;
        private readonly IPedidosService PedidosService;

        public EditModel(IProductosService ProductosService, IPedidosService PedidosService)
        {
            this.ProductosService = ProductosService;
            this.PedidosService = PedidosService;
        }

        [BindProperty]
        [FromBody]

        public ProductosEntity Entity { get; set; } = new ProductosEntity();

        public IEnumerable<PedidosEntity> PedidosLista { get; set; } = new List<PedidosEntity>();

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await ProductosService.GetById(new() { IdProductos = id });
                }

                PedidosLista = await PedidosService.GetLista();

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
                if (Entity.IdProductos.HasValue)
                {
                    result = await ProductosService.Update(Entity);


                }
                else
                {
                    result = await ProductosService.Create(Entity);

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
