#pragma checksum "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b5b878e0ef2f4c11a4e1150ff26e4d61cb599a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(I_SPORTUI.Pages.I_SPORT.Pages_I_SPORT_Verestadistica), @"mvc.1.0.razor-page", @"/Pages/I-SPORT/Verestadistica.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b5b878e0ef2f4c11a4e1150ff26e4d61cb599a", @"/Pages/I-SPORT/Verestadistica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b02672604d3b0a3aeb10aa87defab0c4847d37f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_I_SPORT_Verestadistica : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jspdf.debug.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
  
    ViewData["Title"] = "Verestadistica";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b5b878e0ef2f4c11a4e1150ff26e4d61cb599a3543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function demoFromHTML() {
            var pdf = new jsPDF('letter');
            // source can be HTML-formatted string, or a reference
            // to an actual DOM element from which the text will be scraped.
            source = $('#reporte')[0];

            // we support special element handlers. Register them with jQuery-style
            // ID selector for either ID or node name. (""#iAmID"", ""div"", ""span"" etc.)
            // There is no support for any other type of selectors
            // (class, of compound) at this time.
            specialElementHandlers = {
                // element with id of ""bypass"" - jQuery style selector
                '#bypassme': function (element, renderer) {
                    // true = ""handled elsewhere, bypass text extraction""
                    return true
                }
            };
            margins = {
                top: 10,
                bottom: 10,
                left: 30,
                width: 150");
                WriteLiteral(@"
            };
            // all coords and widths are in jsPDF instance's declared units
            // 'inches' in this case
            pdf.fromHTML(
                source, // HTML string or DOM elem ref.
                margins.left, // x coord
                margins.top, { // y coord
                'width': margins.width, // max width of content on PDF
                'elementHandlers': specialElementHandlers
            },

                function (dispose) {
                    // dispose: object with X, Y of the last line add to the PDF
                    //          this allow the insertion of new lines after html
                    pdf.save('Reporte jugadores.pdf');
                }, margins);
        }
    </script>
");
            }
            );
            WriteLiteral(@"
<div id=""reporte"">
    <h1 class=""text-center"">Estadística  por partido</h1>
    <br />
    <table class=""table  table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Jugador</th>
                <th scope=""col"">Goles</th>
                <th scope=""col"">Autogoles</th>
                <th scope=""col"">Tarjetas Amarillas</th>
                <th scope=""col"">Tarjetas Rojas</th>
                <th scope=""col"">Tiempo Jugado</th>
                <th scope=""col"">Fecha y Hora partido</th>
            </tr>
        </thead>
");
#nullable restore
#line 66 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
         foreach (var item in Model.Estadisticas)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
             foreach (var tm in Model.Jugadores)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                 if (item.idjugador == tm.Id)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                     foreach (var part in Model.partidos)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                         if (item.Idpartido == part.Id)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody>\r\n                                <tr>\r\n                                    <td>");
#nullable restore
#line 78 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                                   Write(Html.DisplayFor(m => tm.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 79 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                                   Write(Html.DisplayFor(m => item.Goles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 80 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                                   Write(Html.DisplayFor(m => item.Autogoles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 81 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                                   Write(Html.DisplayFor(m => item.TAmarillas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 82 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                                   Write(Html.DisplayFor(m => item.TRojas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 83 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                                   Write(Html.DisplayFor(m => item.Tjugado));

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</td>\r\n                                    <td>");
#nullable restore
#line 84 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                                   Write(Html.DisplayFor(m => part.Fechapartido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                            </tbody>\r\n");
#nullable restore
#line 87 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verestadistica.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<button onclick=\"javascript:demoFromHTML();\">Descargar PDF</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<I_SPORTUI.Pages.I_SPORT.VerestadisticaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<I_SPORTUI.Pages.I_SPORT.VerestadisticaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<I_SPORTUI.Pages.I_SPORT.VerestadisticaModel>)PageContext?.ViewData;
        public I_SPORTUI.Pages.I_SPORT.VerestadisticaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
