#pragma checksum "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0bc3800f46f33ac94cb28b2b83b42b50c918e92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0bc3800f46f33ac94cb28b2b83b42b50c918e92", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<producto>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Buscar";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0bc3800f46f33ac94cb28b2b83b42b50c918e923491", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
  <meta http-equiv=""x-ua-compatible"" content=""ie=edge"">
  <title>Material Design Bootstrap</title>
  <!-- Font Awesome -->
  <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.2/css/all.css"">
  <!-- Bootstrap core CSS -->
  <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
  <!-- Material Design Bootstrap -->
  <link href=""css/mdb.min.css"" rel=""stylesheet"">
  <!-- Your custom styles (optional) -->
  <link href=""css/style.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0bc3800f46f33ac94cb28b2b83b42b50c918e925083", async() => {
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 26 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
 foreach (producto item in Model)
    {   
    if(@item.tmpnombre != null){

#line default
#line hidden
#nullable disable
                WriteLiteral(@"      <div class=""container my-1 py-1 z-depth-1"">


  <!--Section: Content-->
  <section class=""text-center"">

    <!-- Section heading -->
    <h2 class=""font-weight-bold mb-5"">Detalles del Producto</h2>

    <div class=""row"">

      <div class=""col-lg-6"">

        <!--Carousel Wrapper-->
        <div id=""carousel-thumb"" class=""carousel slide carousel-fade carousel-thumbnails"" data-ride=""carousel"">

          <!--Slides-->
          <div class=""carousel-inner text-center text-md-left"" role=""listbox"">
            <div class=""carousel-item active"">
              <img");
                BeginWriteAttribute("src", " src=", 1407, "", 1427, 1);
#nullable restore
#line 48 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
WriteAttributeValue("", 1412, item.tmpimagen, 1412, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                alt=""First slide"" class=""img-fluid"">
            </div>
          </div>
          <!--/.Slides-->

          <!--Thumbnails-->
          <a class=""carousel-control-prev"" href=""#carousel-thumb"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
          </a>
          <a class=""carousel-control-next"" href=""#carousel-thumb"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
          </a>
          <!--/.Thumbnails-->

        </div>
        <!--/.Carousel Wrapper-->

      </div>

      <div class=""col-lg-5 text-center text-md-left"">

        <h1>
          <strong>");
#nullable restore
#line 73 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
             Write(item.tmpnombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n        </h1>\r\n        <span class=\"badge badge-danger product mb-1 ml-xl-0 ml-1\">Más vendido</span>\r\n        <h1 >\r\n          <span >\r\n            <strong>$");
#nullable restore
#line 78 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
                Write(item.tmpprecio);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
          </span>
        </h1>

        <!--Accordion wrapper-->
        <div class=""accordion md-accordion"" id=""accordionEx"" role=""tablist"" aria-multiselectable=""true"">

          <!-- Accordion card -->
          <div class=""card"">

            <!-- Card header -->
            <div class=""card-header"" role=""tab"" id=""headingOne1"">
              <a data-toggle=""collapse"" data-parent=""#accordionEx"" href=""#collapseOne1"" aria-expanded=""true""
                aria-controls=""collapseOne1"">
                <h5 class=""mb-0"" style=""color: #000000;"">
                  Descripción
                  <i class=""fas fa-angle-down rotate-icon""></i>
                </h5>
              </a>
            </div>

            <!-- Card body -->
            <div id=""collapseOne1"" class=""collapse show"" role=""tabpanel"" aria-labelledby=""headingOne1""
              data-parent=""#accordionEx"">
              <div class=""card-body"">
                Talla: ");
#nullable restore
#line 103 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
                  Write(item.tmptalla);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br>\r\n                Color: ");
#nullable restore
#line 105 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
                  Write(item.tmpcolor);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br>\r\n                Unidades Disponibles:");
#nullable restore
#line 107 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
                                Write(item.tmpunidades);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
              </div>
            </div>
          </div>
          <!-- Accordion card -->

          <!-- Accordion card -->
          <div class=""card"">

            <!-- Card header -->
            <div class=""card-header"" role=""tab"" id=""headingTwo2"">
              <a class=""collapsed"" data-toggle=""collapse"" data-parent=""#accordionEx"" href=""#collapseTwo2""
                aria-expanded=""false"" aria-controls=""collapseTwo2"">
                <h5 class=""mb-0"" style=""color: #000000;"">
                  Políticas de envío
                  <i class=""fas fa-angle-down rotate-icon""></i>
                </h5>
              </a>
            </div>

            <!-- Card body -->
            <div id=""collapseTwo2"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingTwo2""
              data-parent=""#accordionEx"">
              <div class=""card-body"">
                El tiempo de entrega empezará a contar a partir de la confirmación exitosa del pago, que recibirás en el correo electrónico c");
                WriteLiteral(@"on el cual realizaste tu compra.
              </div>
            </div>
          </div>
          <!-- Accordion card -->

          <!-- Accordion card -->
          <div class=""card"">

            <!-- Card header -->
            <div class=""card-header"" role=""tab"" id=""headingThree3"">
              <a class=""collapsed"" data-toggle=""collapse"" data-parent=""#accordionEx"" href=""#collapseThree3""
                aria-expanded=""false"" aria-controls=""collapseThree3"">
                <h5 class=""mb-0"" style=""color: #000000;"">
                  Cuidados
                  <i class=""fas fa-angle-down rotate-icon""></i>
                </h5>
              </a>
            </div>

            <!-- Card body -->
            <div id=""collapseThree3"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingThree3""
              data-parent=""#accordionEx"">
              <div class=""card-body"">
                - No secar en maquina
                <br>
                - No usar blanqueador, ni deterg");
                WriteLiteral(@"entes.
              </div>
            </div>
          </div>
          <!-- Accordion card -->

        </div>
        <!--/.Accordion wrapper-->
         <div class=""row mt-3"">
              <div class=""col-md-12 text-center text-md-left text-md-right"">
                <button class=""btn btn-dark btn-rounded"">
                  <i class=""fas fa-cart-plus mr-2"" aria-hidden=""true""></i> Añadir al carrito</button>
              </div>
            </div>
      </div>

    </div>

  </section>
  <!--Section: Content-->

</div>
");
#nullable restore
#line 179 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
    }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("      <h2 class=\"font-weight-bold display-4\">No se ha encontrado ningun producto con el nombre que ingresaste :,(</h2>\r\n");
#nullable restore
#line 181 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\Search.cshtml"
    }
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<!-- SCRIPTS -->
  <!-- JQuery -->
  <script type=""text/javascript"" src=""js/jquery-3.4.1.min.js""></script>
  <!-- Bootstrap tooltips -->
  <script type=""text/javascript"" src=""js/popper.min.js""></script>
  <!-- Bootstrap core JavaScript -->
  <script type=""text/javascript"" src=""js/bootstrap.min.js""></script>
  <!-- MDB core JavaScript -->
  <script type=""text/javascript"" src=""js/mdb.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
