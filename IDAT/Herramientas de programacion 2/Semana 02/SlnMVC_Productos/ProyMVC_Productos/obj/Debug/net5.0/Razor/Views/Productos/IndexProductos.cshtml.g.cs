#pragma checksum "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0cee7ada1580156ad5cfd0c49ab57750f88fb0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_IndexProductos), @"mvc.1.0.view", @"/Views/Productos/IndexProductos.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\_ViewImports.cshtml"
using ProyMVC_Productos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\_ViewImports.cshtml"
using ProyMVC_Productos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cee7ada1580156ad5cfd0c49ab57750f88fb0a", @"/Views/Productos/IndexProductos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"922f7d418c59fa1f30f04fdb34c8555982599d3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_IndexProductos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyMVC_Productos.Models.Productos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
  
    // bloque de codigo razor
    ViewData["Title"] = "IndexProductos";

    // definir una variable entera para la cantidad de
    // elementos de los datos del modelo enviado "Model"
    int contador = Model.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>IndexProductos</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0cee7ada1580156ad5cfd0c49ab57750f88fb0a4160", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayNameFor(model => model.cod_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayNameFor(model => model.nom_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayNameFor(model => model.pre_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayNameFor(model => model.stk_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayNameFor(model => model.fecha_cad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayFor(modelItem => item.cod_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayFor(modelItem => item.nom_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayFor(modelItem => item.pre_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayFor(modelItem => item.stk_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.DisplayFor(modelItem => item.fecha_cad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 58 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 59 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<br/>\r\n<div>\r\n    <p>\r\n        Cantidad 1: ");
#nullable restore
#line 69 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
               Write(ViewBag.CANTIDAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        Cantidad 2: ");
#nullable restore
#line 72 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
               Write(ViewBag.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        Cantidad 3: ");
#nullable restore
#line 75 "C:\Users\Usuario\Downloads\Herramientas de programacion 2\Semana 02\SlnMVC_Productos\ProyMVC_Productos\Views\Productos\IndexProductos.cshtml"
               Write(contador);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyMVC_Productos.Models.Productos>> Html { get; private set; }
    }
}
#pragma warning restore 1591