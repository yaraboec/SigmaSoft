#pragma checksum "C:\Users\yaros\Documents\GitHub\SigmaSoft\Project_Sigma\Project_Sigma\Views\Add\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "538d59ea87dd029331aef4194b1e6c4bb36a6221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Add_Details), @"mvc.1.0.view", @"/Views/Add/Details.cshtml")]
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
#line 1 "C:\Users\yaros\Documents\GitHub\SigmaSoft\Project_Sigma\Project_Sigma\Views\_ViewImports.cshtml"
using Project_Sigma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yaros\Documents\GitHub\SigmaSoft\Project_Sigma\Project_Sigma\Views\_ViewImports.cshtml"
using Project_Sigma.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538d59ea87dd029331aef4194b1e6c4bb36a6221", @"/Views/Add/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859b24073eb2b443143313e3141f0b414f867d7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Add_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Sigma.Models.Pizza>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\yaros\Documents\GitHub\SigmaSoft\Project_Sigma\Project_Sigma\Views\Add\Details.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Пицца ");
#nullable restore
#line 5 "C:\Users\yaros\Documents\GitHub\SigmaSoft\Project_Sigma\Project_Sigma\Views\Add\Details.cshtml"
     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<div class=""row justify-content-center m-3"">
    <div class=""ol-sm-8"">
        <div class=""card"">
            <div class=""card-header"">
                <h1>Дополнительная информация</h1>
            </div>
            <div class=""card-body text-center"">
                <h4>Цена за изговление пиццы : ");
#nullable restore
#line 13 "C:\Users\yaros\Documents\GitHub\SigmaSoft\Project_Sigma\Project_Sigma\Views\Add\Details.cshtml"
                                          Write(Model.PriceWork);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                <h4>Итоговая сумма : ");
#nullable restore
#line 14 "C:\Users\yaros\Documents\GitHub\SigmaSoft\Project_Sigma\Project_Sigma\Views\Add\Details.cshtml"
                                Write(Model.ResultPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                <h4>Состав : ");
#nullable restore
#line 15 "C:\Users\yaros\Documents\GitHub\SigmaSoft\Project_Sigma\Project_Sigma\Views\Add\Details.cshtml"
                        Write(Model.Sostav);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n            </div>\r\n            <div class=\"card-footer text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "538d59ea87dd029331aef4194b1e6c4bb36a62215853", async() => {
                WriteLiteral("Вернуться");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_Sigma.Models.Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
