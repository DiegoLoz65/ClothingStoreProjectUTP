#pragma checksum "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff29118ae0801338a406b2766954f0034b284c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BubbleSort), @"mvc.1.0.view", @"/Views/Home/BubbleSort.cshtml")]
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
#line 1 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\_ViewImports.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff29118ae0801338a406b2766954f0034b284c9", @"/Views/Home/BubbleSort.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BubbleSort : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml"
  
    ViewData["Title"] = "BubbleSort";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""font-weight-bold display-4"">BubbleSort</h2>


<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Nombre</th>
      <th scope=""col"">Precio $</th>
      <th scope=""col"">Color</th>
      <th scope=""col"">Talla</th>
      <th scope=""col"">Unidades</th>
    </tr>
  </thead>
  <tbody>

");
#nullable restore
#line 20 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml"
 foreach (producto item in Model)
    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <td>");
#nullable restore
#line 23 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml"
     Write(item.tmpnombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 24 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml"
     Write(item.tmpprecio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 25 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml"
     Write(item.tmpcolor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 26 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml"
     Write(item.tmptalla);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 27 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml"
     Write(item.tmpunidades);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\BubbleSort.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
