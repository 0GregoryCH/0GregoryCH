#pragma checksum "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc866beee966d6fe1f14876f7ded4a5899aef63c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Compra.Pages_Compra_Grid), @"mvc.1.0.razor-page", @"/Pages/Compra/Grid.cshtml")]
namespace WebApp.Pages.Compra
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc866beee966d6fe1f14876f7ded4a5899aef63c", @"/Pages/Compra/Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00bf7af71607479a423d69b1be2803aaa20ac4f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Compra_Grid : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/App/Compra/Grid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container-fluid\">\r\n\r\n\r\n\r\n\r\n\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            Compra\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n\r\n\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc866beee966d6fe1f14876f7ded4a5899aef63c4591", async() => {
                WriteLiteral("\r\n                <i class=\'bx bxs-add-to-queue\'></i>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"





            <div class=""row"">
                <div class=""col-12"">
                    <table id=""GridView"" class=""table table-bordered table table-striped table table-hover"">
                        <thead>
                            <tr>
                                <th>IDCompra</th>
                                <th>Cliente</th>
                                <th>Producto</th>
                                <th>Fecha Compra</th>
                                <th>Monto</th>
                                <th>Impuesto</th>
                                <th>Total</th>
                                <th>Observaciones</th>
                                <th>Estado</th>
                            </tr>
                        </thead>
                        <tboby>
");
#nullable restore
#line 46 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                             foreach (var item in Model.GridList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 49 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.IdCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.ClientesId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 51 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.ProductoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 52 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.FechaCompra.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 53 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 54 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.Impuesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 55 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 56 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.Observaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 57 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                   Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc866beee966d6fe1f14876f7ded4a5899aef63c10264", async() => {
                WriteLiteral("<i class=\'bx bx-edit-alt\'></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                                                                                     WriteLiteral(item.IdCompra);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                                        <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2185, "\"", 2237, 3);
            WriteAttributeValue("", 2195, "CompraGrid.OnClickEliminar(", 2195, 27, true);
#nullable restore
#line 71 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
WriteAttributeValue("", 2222, item.IdCompra, 2222, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2236, ")", 2236, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\'bx bx-trash\'></i>\r\n                                        </button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 76 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Compra\Grid.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tboby>\r\n                    </table>\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc866beee966d6fe1f14876f7ded4a5899aef63c14136", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.Compra.GridModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Compra.GridModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Compra.GridModel>)PageContext?.ViewData;
        public WebApp.Pages.Compra.GridModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
