using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Productos
{
    public class GridModel : PageModel
    {
        private readonly IProductosService productosService;

        public GridModel(IProductosService productosService)
        {
            this.productosService = productosService;
        }

        public IEnumerable<ProductosEntity> GridList { get; set; } = new List<ProductosEntity>();

        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await productosService.Get();


                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnDeleteEliminar(int id)
        {

            try
            {
                var result = await productosService.Delete(new() { IdProductos = id });

                return new JsonResult(result);


            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }

        }









    }
}