#pragma checksum "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac8c664b88c42ed1eff3b7f6b14884c4024c9779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Clientes.Pages_Clientes_Grid), @"mvc.1.0.razor-page", @"/Pages/Clientes/Grid.cshtml")]
namespace WebApp.Pages.Clientes
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac8c664b88c42ed1eff3b7f6b14884c4024c9779", @"/Pages/Clientes/Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00bf7af71607479a423d69b1be2803aaa20ac4f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes_Grid : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/App/Clientes/Grid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"container-fluid\">\n\n    <div class=\"card\">\n        <div class=\"card-header\">\n            Clientes\n        </div>\n        <div class=\"card-body\">\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac8c664b88c42ed1eff3b7f6b14884c4024c97794563", async() => {
                WriteLiteral("\n                <i class=\'bx bxs-add-to-queue\'></i>\n            ");
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
                                <th>ID</th>
                                <th>Compra</th>
                                <th>NombreCompleto</th>
                                <th>Direccion</th>
                                <th>Telefono</th>
                                <th>Acción</th>
                            </tr>
                        </thead>
                        <tboby>

");
#nullable restore
#line 33 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
                             foreach (var item in Model.GridList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 36 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
                               Write(item.ClientesId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 37 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
                               Write(item.Compra.IdCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 38 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
                               Write(item.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 39 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
                               Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 40 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
                               Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac8c664b88c42ed1eff3b7f6b14884c4024c97798610", async() => {
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
#line 42 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
                                                                                 WriteLiteral(item.ClientesId);

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
            WriteLiteral("\n\n                                    <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1661, "\"", 1717, 3);
            WriteAttributeValue("", 1671, "ClientesGrid.OnClickEliminar(", 1671, 29, true);
#nullable restore
#line 44 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
WriteAttributeValue("", 1700, item.ClientesId, 1700, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1716, ")", 1716, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                        <i class=\'bx bx-trash\'></i>\n                                    </button>\n                                </td>\n                            </tr>");
#nullable restore
#line 48 "C:\Users\pclap\OneDrive\Escritorio\7Cuatri\Programacion 6\Examen3-main\Examen3\Examen3\WebApp\Pages\Clientes\Grid.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tboby>\n                    </table>\n\n                </div>\n            </div>\n\n\n\n        </div>\n    </div>\n\n\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac8c664b88c42ed1eff3b7f6b14884c4024c977912330", async() => {
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
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.Clientes.GridModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Clientes.GridModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Clientes.GridModel>)PageContext?.ViewData;
        public WebApp.Pages.Clientes.GridModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
