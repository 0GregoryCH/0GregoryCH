using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Clientes
{
    public class EditModel : PageModel
    {
        private readonly IClientesService ClientesService;
        private readonly IPedidosService PedidosService;

        public EditModel(IClientesService ClientesService, IPedidosService PedidosService)
        {
            this.ClientesService = ClientesService;
            this.PedidosService = PedidosService;
        }

        [BindProperty]
        [FromBody]

        public ClientesEntity Entity { get; set; } = new ClientesEntity();

        public IEnumerable<PedidosEntity> PedidosLista { get; set; } = new List<PedidosEntity>();

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await ClientesService.GetById(new() { IdClientes = id });
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
                if (Entity.IdClientes.HasValue)
                {
                     result = await ClientesService.Update(Entity);

               
                }
                else
                {
                     result = await ClientesService.Create(Entity);

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
