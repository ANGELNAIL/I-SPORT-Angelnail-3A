#pragma checksum "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b0978ed5c9d19cf9db404bb940b803e1e19c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(I_SPORTUI.Pages.I_SPORT.Pages_I_SPORT_Ficha_jugador), @"mvc.1.0.razor-page", @"/Pages/I-SPORT/Ficha_jugador.cshtml")]
namespace I_SPORTUI.Pages.I_SPORT
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
#line 1 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\_ViewImports.cshtml"
using I_SPORTUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b0978ed5c9d19cf9db404bb940b803e1e19c1e", @"/Pages/I-SPORT/Ficha_jugador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b02672604d3b0a3aeb10aa87defab0c4847d37f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_I_SPORT_Ficha_jugador : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-thumbnail imgThumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Containers/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
  
    ViewData["Title"] = "Ficha_jugador";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ficha de jugador</h1>\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 9 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
     foreach (var item in Model.jugadores)
    {
        var imgPath = $"~/images/{(string.IsNullOrEmpty(item.Foto) ? "nonWorkshops.jpg" : item.Foto)}";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card bg-light m-3\" style=\"min-width:18rem; max-width:30.5%\">\r\n            <div class=\"card-header\">\r\n                <h4 class=\"text-center\">Nombre: ");
#nullable restore
#line 14 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65b0978ed5c9d19cf9db404bb940b803e1e19c1e5282", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                                          WriteLiteral(Url.Content(@imgPath));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
AddHtmlAttributeValue("", 624, item.Foto, 624, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 16 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <div><label>Estatura: ");
#nullable restore
#line 18 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                 Write(item.Estatura);

#line default
#line hidden
#nullable disable
            WriteLiteral(" M</label></div>\r\n                <div><label>Fecha de nacimiento: ");
#nullable restore
#line 19 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                            Write(item.Fechanac.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                <div><label>Nacionalidad: ");
#nullable restore
#line 20 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                     Write(item.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                <div><label>Posicion: ");
#nullable restore
#line 21 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                 Write(item.posicion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                <div><label>Identificador: ");
#nullable restore
#line 22 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n");
#nullable restore
#line 23 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                 foreach (var itm in Model.equipos)
                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                  if (item.EquipoId == itm.Id)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><label>Equipo: ");
#nullable restore
#line 26 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                       Write(itm.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n");
#nullable restore
#line 27 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"card-footer text-center\">\r\n                <a href=\"#\" class=\"btn btn-primary m-1\">Edit</a>\r\n                <a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b0978ed5c9d19cf9db404bb940b803e1e19c1e11170", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
                                                    WriteLiteral(item.Nombre);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Ficha_jugador.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<I_SPORTUI.Pages.I_SPORT.Ficha_jugadorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<I_SPORTUI.Pages.I_SPORT.Ficha_jugadorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<I_SPORTUI.Pages.I_SPORT.Ficha_jugadorModel>)PageContext?.ViewData;
        public I_SPORTUI.Pages.I_SPORT.Ficha_jugadorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
