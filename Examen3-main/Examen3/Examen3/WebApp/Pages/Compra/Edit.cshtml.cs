using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;



namespace WebApp.Pages.Compra
{
    public class EditModel : PageModel
    {
        private readonly ICompraService CompraService;
        private readonly IClientesService ClientesService;
        private readonly IProductoService ProductoService;



        public EditModel(ICompraService CompraService, IClientesService ClientesService, IProductoService ProductoService)
        {
            this.ClientesService = ClientesService;
            this.CompraService = CompraService;
            this.ProductoService = ProductoService;
        }



        [BindProperty]
        [FromBody]



        public CompraEntity Entity { get; set; } = new CompraEntity();



        public IEnumerable<ClientesEntity> ClientesLista { get; set; } = new List<ClientesEntity>();
        public IEnumerable<ProductoEntity> ProductoLista { get; set; } = new List<ProductoEntity>();



        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }



        public async Task<IActionResult> OnGet(IEnumerable<ProductoEntity> ProductoLista)
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await CompraService.GetById(new() { IdCompra = id });
                }



                ClientesLista = await ClientesService.GetLista();
                ProductoLista = await ProductoService.GetLista();



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
                if (Entity.IdCompra.HasValue)
                {
                    result = await CompraService.Update(Entity);




                }
                else
                {
                    result = await CompraService.Create(Entity);



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