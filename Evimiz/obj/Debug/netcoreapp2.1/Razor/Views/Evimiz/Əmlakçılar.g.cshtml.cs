#pragma checksum "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Evimiz\Əmlakçılar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1500ffddc37b92f2bd4abca2a45588094ca7cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evimiz_Əmlakçılar), @"mvc.1.0.view", @"/Views/Evimiz/Əmlakçılar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evimiz/Əmlakçılar.cshtml", typeof(AspNetCore.Views_Evimiz_Əmlakçılar))]
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
#line 1 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\_ViewImports.cshtml"
using Evimiz;

#line default
#line hidden
#line 2 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\_ViewImports.cshtml"
using Evimiz.Models;

#line default
#line hidden
#line 3 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\_ViewImports.cshtml"
using Evimiz.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1500ffddc37b92f2bd4abca2a45588094ca7cf", @"/Views/Evimiz/Əmlakçılar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37c7899817733404d3f451f813828106b62ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Evimiz_Əmlakçılar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<İstifadəçi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Əmlakçılar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profilim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-lg-3 col-md-6 col-sm-9  col-10 mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Evimiz\Əmlakçılar.cshtml"
  
    ViewData["Title"] = "Əmlakçılar";

#line default
#line hidden
            BeginContext(78, 401, true);
            WriteLiteral(@"
<!-- Agent start -->
<section id=""Agent"">
    <div class=""container"">
        <div class=""row head"">
            <div class=""col-md-8 col-12 "">
                <i class=""far fa-handshake mr-2 color-blue""></i> Agent
            </div>
            <div class=""col-md-4 col-12  d-md-flex justify-content-end"">
            </div>
        </div>
        <div class=""row  Advertisement-place"">
");
            EndContext();
#line 17 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Evimiz\Əmlakçılar.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(536, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(552, 793, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4931644171745c28efc360cf91e46da", async() => {
                BeginContext(653, 167, true);
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12 \">\r\n                            <div class=\"img\">\r\n                                ");
                EndContext();
                BeginContext(820, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0d99a1c9036b417ab52db1182a66094f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 830, "~/images/Agent/", 830, 15, true);
#line 23 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Evimiz\Əmlakçılar.cshtml"
AddHtmlAttributeValue("", 845, item.AgencyImageUrl, 845, 20, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(891, 207, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-12\">\r\n                            <div class=\"about-agent\">\r\n                                <h3>");
                EndContext();
                BeginContext(1099, 14, false);
#line 28 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Evimiz\Əmlakçılar.cshtml"
                               Write(item.Firstname);

#line default
#line hidden
                EndContext();
                BeginContext(1113, 89, true);
                WriteLiteral(" emlak</h3>\r\n                                <span><i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(1203, 16, false);
#line 29 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Evimiz\Əmlakçılar.cshtml"
                                                                       Write(item.Region.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1219, 122, true);
                WriteLiteral(" </span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1345, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Evimiz\Əmlakçılar.cshtml"
            }

#line default
#line hidden
            BeginContext(1362, 416, true);
            WriteLiteral(@"        </div>
        <div class=""row  Advertisement-place justify-content-center "">
            <div class=""load-more  mt-3 col-md-4 col-6"" data-aos=""fade-left"">
                <a href=""#"" class=""btn Btn-yellow  btn-block"">
                    <i class=""fas fa-plus""></i> Daha
                    çox
                </a>
            </div>
        </div>
    </div>
</section>
<!-- Agent end -->


");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<İstifadəçi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
