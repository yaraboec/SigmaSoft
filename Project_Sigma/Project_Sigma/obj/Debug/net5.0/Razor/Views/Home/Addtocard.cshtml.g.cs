#pragma checksum "C:\Users\yaros\Desktop\Project_Sigma\Project_Sigma\Views\Home\Addtocard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0609cad3d16f73211418d49f36ba43b08724d2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Addtocard), @"mvc.1.0.view", @"/Views/Home/Addtocard.cshtml")]
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
#line 1 "C:\Users\yaros\Desktop\Project_Sigma\Project_Sigma\Views\_ViewImports.cshtml"
using Project_Sigma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yaros\Desktop\Project_Sigma\Project_Sigma\Views\_ViewImports.cshtml"
using Project_Sigma.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0609cad3d16f73211418d49f36ba43b08724d2e", @"/Views/Home/Addtocard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859b24073eb2b443143313e3141f0b414f867d7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Addtocard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Sigma.Models.Pizza>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yaros\Desktop\Project_Sigma\Project_Sigma\Views\Home\Addtocard.cshtml"
 using (@Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0609cad3d16f73211418d49f36ba43b08724d2e3437", async() => {
                WriteLiteral("\r\n    <div class=\"row justify-content-center m-3\">\r\n        <div class=\"ol-sm-8\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header text-center\">\r\n                    <h1>Название пиццы: ");
#nullable restore
#line 10 "C:\Users\yaros\Desktop\Project_Sigma\Project_Sigma\Views\Home\Addtocard.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n                    <h2>Цена: ");
#nullable restore
#line 12 "C:\Users\yaros\Desktop\Project_Sigma\Project_Sigma\Views\Home\Addtocard.cshtml"
                         Write(Model.ResultPrice.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                </div>
                <div class=""card-body text-center"">
                  Количество  <input type=""number"" name=""qty"" value=""1"" min=""1"" max=""100"" id=""qty"" />
                </div>
                <div class=""card-footer text-center"">
                    <input type=""submit"" value=""Submit"" class=""btn btn-primary"" />
                    </div>
                </div>
            </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "C:\Users\yaros\Desktop\Project_Sigma\Project_Sigma\Views\Home\Addtocard.cshtml"
        WriteLiteral(Model.IdPizza);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\yaros\Desktop\Project_Sigma\Project_Sigma\Views\Home\Addtocard.cshtml"
}

#line default
#line hidden
#nullable disable
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
