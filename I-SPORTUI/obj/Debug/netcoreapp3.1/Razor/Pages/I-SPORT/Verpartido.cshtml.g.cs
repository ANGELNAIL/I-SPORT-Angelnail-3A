#pragma checksum "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a06c78df2323972a9161def3f636b014e5b7db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(I_SPORTUI.Pages.I_SPORT.Pages_I_SPORT_Verpartido), @"mvc.1.0.razor-page", @"/Pages/I-SPORT/Verpartido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a06c78df2323972a9161def3f636b014e5b7db", @"/Pages/I-SPORT/Verpartido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b02672604d3b0a3aeb10aa87defab0c4847d37f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_I_SPORT_Verpartido : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Containers/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
  
    ViewData["Title"] = "Verpartido";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Verpartido</h1>\r\n\r\n<div class=\"card bg-light m-3\" style=\"min-width:18rem; max-width:30.5%\">\r\n");
#nullable restore
#line 11 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
     foreach (var item in Model.partidos)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
         foreach (var tm in Model.equipos)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
             if (tm.Id == item.Equipolocal)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
                 foreach (var at in Model.equipos)
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
                     if (at.Id == item.Equipovisitante)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-header\">\r\n                            <div class=\"card-body\">\r\n                                <div><label>Fecha partido: ");
#nullable restore
#line 22 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
                                                      Write(item.Fechapartido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                                <div><label>Equipo Local: ");
#nullable restore
#line 23 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
                                                     Write(tm.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                                <div>vz</div>\r\n                                <div><label>Posicion: ");
#nullable restore
#line 25 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
                                                 Write(at.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label></div>
                            </div>
                            <div class=""card-footer text-center"">
                                <a href=""#"" class=""btn btn-primary m-1"">Edit</a>
                                <a href=""#"" class=""btn btn-danger m-1"">Delete</a>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a06c78df2323972a9161def3f636b014e5b7db6781", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>                 \r\n");
#nullable restore
#line 33 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
  
                     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
                      
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ANGEL NAIL\Documents\I-SPORT-Angelnail-3A\I-SPORTUI\Pages\I-SPORT\Verpartido.cshtml"
              
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<I_SPORTUI.Pages.I_SPORT.VerpartidoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<I_SPORTUI.Pages.I_SPORT.VerpartidoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<I_SPORTUI.Pages.I_SPORT.VerpartidoModel>)PageContext?.ViewData;
        public I_SPORTUI.Pages.I_SPORT.VerpartidoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
