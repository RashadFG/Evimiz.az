#pragma checksum "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a35fa49fd727c8d56c5225c280310d1d1be7f450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elan_AllVilla), @"mvc.1.0.view", @"/Views/Elan/AllVilla.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elan/AllVilla.cshtml", typeof(AspNetCore.Views_Elan_AllVilla))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a35fa49fd727c8d56c5225c280310d1d1be7f450", @"/Views/Elan/AllVilla.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37c7899817733404d3f451f813828106b62ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Elan_AllVilla : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Elan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Haqqında", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
  
    ViewData["Title"] = "AllVilla";

#line default
#line hidden
            BeginContext(62, 447, true);
            WriteLiteral(@"
<!-- Villa Advertisement start -->
<section id=""advertisement"">
    <div class=""container"">
        <div class=""row head"">
            <div class=""col-md-8 col-12 "">
                <i class=""fas fa-hotel mr-2 color-blue""></i> Villa
            </div>
            <div class=""col-md-4 col-12  d-md-flex justify-content-end"">
            </div>
        </div>
        <div class=""row Advertisement-place justify-content-center Villa"">
");
            EndContext();
#line 17 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
             foreach (var item in Model.Advertisements.Where(x => x.CategoryId == 3 && x.IsPremium == false && x.IsVip == false).Take(20))
            {

#line default
#line hidden
            BeginContext(664, 241, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 col-sm-9  col-10 mt-3\" data-aos=\"fade-up\">\r\n                    <i class=\"fas fa-heart heart fa-2x d-none\"></i>\r\n                    <i class=\"far fa-heart heart fa-2x\"></i>\r\n                    ");
            EndContext();
            BeginContext(905, 3252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ccf171b4b3f4964adfd1d42db73efc6", async() => {
                BeginContext(976, 183, true);
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-12 \">\r\n                                <div class=\"img\">\r\n                                    ");
                EndContext();
                BeginContext(1159, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93bef24b9c9e49ca9c629111df447404", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1169, "~/images/Advertisement/", 1169, 23, true);
#line 26 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
AddHtmlAttributeValue("", 1192, Model.Images.FirstOrDefault(x=>x.AdvertisementId==item.Id && x.IsMainPhoto==true).Name, 1192, 87, false);

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
                BeginContext(1305, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                     if (item.PropertyCategory.Id == 1)
                                    {

#line default
#line hidden
                BeginContext(1419, 71, true);
                WriteLiteral("                                        <div class=\"Rent\">Satış</div>\r\n");
                EndContext();
#line 30 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(1610, 72, true);
                WriteLiteral("                                        <div class=\"Sell\">Kirayə</div>\r\n");
                EndContext();
#line 34 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1721, 55, true);
                WriteLiteral("                                    <div class=\"Price\">");
                EndContext();
                BeginContext(1777, 10, false);
#line 35 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1787, 12, true);
                WriteLiteral(" Azn</div>\r\n");
                EndContext();
#line 36 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                     if (item.PropertyDocument.Id == 6)
                                    {

#line default
#line hidden
                BeginContext(1911, 94, true);
                WriteLiteral("                                        <i class=\"fas fa-file-signature document fa-1x\"></i>\r\n");
                EndContext();
#line 39 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                    }

#line default
#line hidden
                BeginContext(2044, 319, true);
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""about-advertisement"">
                                    <div class=""location"">
                                        <div class=""col-12 p-0"">
");
                EndContext();
#line 46 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                             if (item.CityId == 10)
                                            {

#line default
#line hidden
                BeginContext(2479, 86, true);
                WriteLiteral("                                                <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(2566, 16, false);
#line 48 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                                                                 Write(item.Region.Name);

#line default
#line hidden
                EndContext();
#line 48 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                                                                                       
                                            }
                                            else
                                            {

#line default
#line hidden
                BeginContext(2728, 86, true);
                WriteLiteral("                                                <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(2815, 14, false);
#line 52 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                                                                 Write(item.City.Name);

#line default
#line hidden
                EndContext();
#line 52 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                                                                                     
                                            }

#line default
#line hidden
                BeginContext(2878, 196, true);
                WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                    <div class=\"detail\">\r\n                                        <span>");
                EndContext();
                BeginContext(3075, 15, false);
#line 57 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                         Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3090, 66, true);
                WriteLiteral(" otaqlı </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(3157, 9, false);
#line 58 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                          Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3166, 73, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                        <span> ");
                EndContext();
                BeginContext(3240, 16, false);
#line 59 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                          Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3256, 157, true);
                WriteLiteral(" m</span>\r\n                                    </div>\r\n                                    <div class=\"date\">\r\n                                        <span>");
                EndContext();
                BeginContext(3414, 14, false);
#line 62 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                         Write(item.City.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3428, 56, true);
                WriteLiteral(",</span>\r\n                                        <span>");
                EndContext();
                BeginContext(3485, 49, false);
#line 63 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                         Write(String.Format("{0:MM/dd/yyyy}", item.PublishDate));

#line default
#line hidden
                EndContext();
                BeginContext(3534, 53, true);
                WriteLiteral("</span>\r\n                                    </div>\r\n");
                EndContext();
#line 65 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                     if (item.IsVip == true)
                                    {

#line default
#line hidden
                BeginContext(3688, 72, true);
                WriteLiteral("                                        <i class=\"fas fa-gem gem\"></i>\r\n");
                EndContext();
#line 68 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                    }
                                    else if (item.IsPremium == true)
                                    {

#line default
#line hidden
                BeginContext(3908, 78, true);
                WriteLiteral("                                        <i class=\"fas fa-crown premium\"></i>\r\n");
                EndContext();
#line 72 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                    }

#line default
#line hidden
                BeginContext(4025, 128, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4157, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 78 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
            }

#line default
#line hidden
            BeginContext(4198, 166, true);
            WriteLiteral("        </div>\r\n        <div class=\"row Advertisement-place justify-content-center\">\r\n            <div class=\"load-more  mt-3 col-md-4 col-6 \" data-aos=\"fade-left\">\r\n");
            EndContext();
#line 82 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                 if (Model.Advertisements.Where(x => x.CategoryId == 3 && x.IsPremium == false && x.IsVip == false).Count() > 20)
                {

#line default
#line hidden
            BeginContext(4514, 117, true);
            WriteLiteral("                    <input type=\"hidden\" value=\"20\" id=\"changeSkipVilla\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4631, "\"", 4742, 1);
#line 85 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
WriteAttributeValue("", 4639, Model.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false && x.CategoryId == 3).Count(), 4639, 103, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4743, 197, true);
            WriteLiteral(" />\r\n                    <a class=\"btn Btn-yellow  btn-block load-more-btn-Villa\">\r\n                        <i class=\"fas fa-plus\"></i> Daha\r\n                        çox\r\n                    </a>\r\n");
            EndContext();
#line 90 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllVilla.cshtml"
                }

#line default
#line hidden
            BeginContext(4959, 94, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!-- Villa Advertisement end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
