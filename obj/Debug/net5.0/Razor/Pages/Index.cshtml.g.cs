#pragma checksum "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6687f546a3980dac971fbf7c6aec61c931201de2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aplikacja_pogodowa.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace aplikacja_pogodowa.Pages
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
#line 1 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/_ViewImports.cshtml"
using aplikacja_pogodowa;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6687f546a3980dac971fbf7c6aec61c931201de2", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49fad91be276ccd4ab89f1e371652d59418aeead", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "metric", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "imperial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
  
    var temUnit = Model.unit == "imperial" ? "F" : "C";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css"" rel=""stylesheet""
    integrity=""sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl"" crossorigin=""anonymous"">
<div class=""container"">
    <div class=""row"">
        &nbsp;
    </div>
    <div >
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6687f546a3980dac971fbf7c6aec61c931201de25846", async() => {
                WriteLiteral("\n     <div class=\"form-group mx-sm-3 mb-2\">\n            <input name=\"location\" placeholder=\"Podaj lokalizację\"");
                BeginWriteAttribute("value", " value=\"", 592, "\"", 623, 1);
#nullable restore
#line 19 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
WriteAttributeValue("", 600, Model.Model.location, 600, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" >\n        </div>\n         <div class=\"form-group mx-sm-3 mb-2\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6687f546a3980dac971fbf7c6aec61c931201de26692", async() => {
                    WriteLiteral("\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6687f546a3980dac971fbf7c6aec61c931201de26972", async() => {
                        WriteLiteral("Metryczny");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6687f546a3980dac971fbf7c6aec61c931201de28260", async() => {
                        WriteLiteral("Imperial");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 22 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.unit);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n         </div>\n        <div class=\"form-group mx-sm-3 mb-2\">\n            <input id=\"getWeatherBtn\" type=\"submit\" value=\"Pobierz prognozę\" class=\"btn btn-primary\" />\n        </div>\n        \n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    \n    </div>\n    <div class=\"row\">\n        <p></p>\n    </div>\n    <div class=\"row\">\n");
#nullable restore
#line 38 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
        if( Model.Model.cod == 200) {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\">\n            <tbody>\n                <h4>Ogólne:</h4>\n          \n                <tr>\n                    <td>Ciśnienie</td>\n                    <td>");
#nullable restore
#line 46 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                   Write(Model.Model.main.pressure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Wilgotność</td>\n                    <td>");
#nullable restore
#line 50 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                   Write(Model.Model.main.humidity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
        <table class=""table"">
            <tbody>
                <h4>Temperatury:</h4>
               
                <tr>
                    <td>Temperatura </td>
                    <td>");
#nullable restore
#line 60 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                   Write(Model.Model.main.temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp; ");
#nullable restore
#line 60 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                                                Write(temUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Maksymalna temperatura</td>\n                    <td>");
#nullable restore
#line 64 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                   Write(Model.Model.main.temp_max);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Minimalna temperatura</td>\n                    <td>");
#nullable restore
#line 68 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                   Write(Model.Model.main.temp_min);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Odczuwalna temperatura</td>\n                    <td>");
#nullable restore
#line 72 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                   Write(Model.Model.main.feels_like);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n            </tbody>\n        </table>\n          <table class=\"table\">\n            <tbody>\n                <h4>Wiatr:</h4>\n          \n                <tr>\n                    <td>Prędkość</td>\n                    <td>");
#nullable restore
#line 82 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                   Write(Model.Model.wind.speed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Kierunek</td>\n                    <td>");
#nullable restore
#line 86 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
                   Write(Model.Model.wind.deg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n            </tbody>\n        </table>\n");
#nullable restore
#line 90 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
               } else if( Model.Model.location != null ) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"alert alert-danger\" role=\"alert\">\n                    ");
#nullable restore
#line 92 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
               Write(Model.Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n                    </div>\n");
#nullable restore
#line 94 "/Users/michalgredziak/Documents/GitHub/Pogoda/Pages/Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
