using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Pedidos
{
    public class GridModel : PageModel
    {
        private readonly IPedidosService PedidosService;

        public GridModel(IPedidosService PedidosService)
        {
            this.PedidosService = PedidosService;
        }


        public IEnumerable<PedidosEntity> GridList { get; set; } = new List<PedidosEntity>();

        public string Mensaje { get; set; } = "";
        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await PedidosService.Get();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }

                TempData.Clear();

                return Page();

            }
            catch (Exception ex)
            {

               return Content(ex.Message) ;
            }

        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {

            try
            {
                var result = await PedidosService.Delete( new() { IdCodigo= id});

                if (result.CodeError!=0)
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
