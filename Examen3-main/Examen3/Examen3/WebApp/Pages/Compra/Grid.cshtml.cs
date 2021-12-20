using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;



namespace WebApp.Pages.Compra
{
    public class GridModel : PageModel
    {
        private readonly ICompraService CompraService;



        public GridModel(ICompraService CompraService)
        {
            this.CompraService = CompraService;
        }




        public IEnumerable<CompraEntity> GridList { get; set; } = new List<CompraEntity>();



        public string Mensaje { get; set; } = "";
        public async Task<IActionResult> OnGet()
        {



            try
            {
                GridList = await CompraService.Get();



                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }



                TempData.Clear();



                return Page();



            }
            catch (Exception ex)
            {



                return Content(ex.Message);
            }



        }



        public async Task<IActionResult> OnGetEliminar(int id)
        {



            try
            {
                var result = await CompraService.Delete(new() { IdCompra = id });



                if (result.CodeError != 0)
                {
                    throw new Exception(result.MsgError);
                }



                TempData["Msg"] = "Se elimino correctamente";



                return Redirect("Grid");



            }
            catch (Exception ex)
            {



                return Content(ex.Message);
            }



        }
    }
}