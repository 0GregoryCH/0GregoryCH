using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;



namespace WebApp.Pages.Producto
{
    public class EditModel : PageModel
    {
        private readonly IProductoService ProductoService;
        private readonly ICompraService CompraService;



        public EditModel(IProductoService ProductoService, ICompraService CompraService)
        {
            this.ProductoService = ProductoService;
            this.CompraService = CompraService;
        }



        [BindProperty]
        [FromBody]



        public ProductoEntity Entity { get; set; } = new ProductoEntity();



        public IEnumerable<CompraEntity> CompraLista { get; set; } = new List<CompraEntity>();



        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }



        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await ProductoService.GetById(new() { ProductoId = id });
                }




                CompraLista = await CompraService.GetLista();



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
                if (Entity.ProductoId.HasValue)
                {
                    result = await ProductoService.Update(Entity);




                }
                else
                {
                    result = await ProductoService.Create(Entity);



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