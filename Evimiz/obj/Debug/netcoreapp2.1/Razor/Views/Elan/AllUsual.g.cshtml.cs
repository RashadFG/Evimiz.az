#pragma checksum "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40ae05482c84771b96d2beb50a680ff8f4a0b147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elan_AllUsual), @"mvc.1.0.view", @"/Views/Elan/AllUsual.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elan/AllUsual.cshtml", typeof(AspNetCore.Views_Elan_AllUsual))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ae05482c84771b96d2beb50a680ff8f4a0b147", @"/Views/Elan/AllUsual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37c7899817733404d3f451f813828106b62ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Elan_AllUsual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
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
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
  
    ViewData["Title"] = "AllUsual";

#line default
#line hidden
            BeginContext(64, 460, true);
            WriteLiteral(@"
<!-- last Advertisement start -->
<section id=""advertisement"">
    <div class=""container"">
        <div class=""row head"">
            <div class=""col-md-8 col-12 "">
                <i class=""fas fa-hourglass-end mr-2 color-blue""></i> Son elanlar
            </div>
            <div class=""col-md-4 col-12  d-md-flex justify-content-end"">
            </div>
        </div>
        <div class=""row Advertisement-place justify-content-center Usual"">
");
            EndContext();
#line 18 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
             foreach (var item in Model.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false ).OrderByDescending(x => x.PublishDate).Take(20))
            {

#line default
#line hidden
            BeginContext(697, 241, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 col-sm-9  col-10 mt-3\" data-aos=\"fade-up\">\r\n                    <i class=\"fas fa-heart heart fa-2x d-none\"></i>\r\n                    <i class=\"far fa-heart heart fa-2x\"></i>\r\n                    ");
            EndContext();
            BeginContext(938, 7172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0b32ec87e94977b69eef3359f2f63a", async() => {
                BeginContext(1009, 183, true);
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-12 \">\r\n                                <div class=\"img\">\r\n                                    ");
                EndContext();
                BeginContext(1192, 146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8af3c7b1870a49d5b9099f16afc0e91b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1202, "~/images/Advertisement/", 1202, 23, true);
#line 27 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
AddHtmlAttributeValue("", 1225, Model.Images.FirstOrDefault(x=>x.AdvertisementId==item.Id && x.IsMainPhoto==true).Name, 1225, 87, false);

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
                BeginContext(1338, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                     if (item.PropertyCategory.Id == 1)
                                    {

#line default
#line hidden
                BeginContext(1452, 71, true);
                WriteLiteral("                                        <div class=\"Rent\">Satış</div>\r\n");
                EndContext();
#line 31 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(1643, 72, true);
                WriteLiteral("                                        <div class=\"Sell\">Kirayə</div>\r\n");
                EndContext();
#line 35 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1754, 55, true);
                WriteLiteral("                                    <div class=\"Price\">");
                EndContext();
                BeginContext(1810, 10, false);
#line 36 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1820, 12, true);
                WriteLiteral(" Azn</div>\r\n");
                EndContext();
#line 37 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                     if (item.PropertyDocument.Id == 6)
                                    {

#line default
#line hidden
                BeginContext(1944, 94, true);
                WriteLiteral("                                        <i class=\"fas fa-file-signature document fa-1x\"></i>\r\n");
                EndContext();
#line 40 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }

#line default
#line hidden
                BeginContext(2077, 319, true);
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""about-advertisement"">
                                    <div class=""location"">
                                        <div class=""col-12 p-0"">
");
                EndContext();
#line 47 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                             if (item.CityId == 10)
                                            {

#line default
#line hidden
                BeginContext(2512, 86, true);
                WriteLiteral("                                                <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(2599, 16, false);
#line 49 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                 Write(item.Region.Name);

#line default
#line hidden
                EndContext();
#line 49 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                                       
                                            }
                                            else
                                            {

#line default
#line hidden
                BeginContext(2761, 86, true);
                WriteLiteral("                                                <i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(2848, 14, false);
#line 53 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                 Write(item.City.Name);

#line default
#line hidden
                EndContext();
#line 53 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                                                     
                                            }

#line default
#line hidden
                BeginContext(2911, 92, true);
                WriteLiteral("                                        </div>\r\n                                    </div>\r\n");
                EndContext();
#line 57 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                     if (item.CategoryId == 1)
                                    {

#line default
#line hidden
                BeginContext(3106, 112, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(3219, 15, false);
#line 60 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3234, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(3305, 9, false);
#line 61 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3314, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(3392, 16, false);
#line 62 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3408, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(3410, 15, false);
#line 62 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3425, 59, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n");
                EndContext();
#line 64 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else if (item.CategoryId == 2)
                                    {

#line default
#line hidden
                BeginContext(3630, 112, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(3743, 15, false);
#line 68 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3758, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(3829, 9, false);
#line 69 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(3838, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(3916, 16, false);
#line 70 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3932, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(3934, 15, false);
#line 70 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3949, 59, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n");
                EndContext();
#line 72 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else if (item.CategoryId == 4)
                                    {

#line default
#line hidden
                BeginContext(4154, 112, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(4267, 15, false);
#line 76 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4282, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(4353, 9, false);
#line 77 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(4362, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(4440, 16, false);
#line 78 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4456, 59, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n");
                EndContext();
#line 80 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else if (item.CategoryId == 3)
                                    {

#line default
#line hidden
                BeginContext(4661, 112, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(4774, 15, false);
#line 84 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4789, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(4860, 9, false);
#line 85 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(4869, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(4947, 16, false);
#line 86 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4963, 59, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n");
                EndContext();
#line 88 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else if (item.CategoryId == 5)
                                    {

#line default
#line hidden
                BeginContext(5168, 112, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(5281, 15, false);
#line 92 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5296, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(5367, 9, false);
#line 93 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(5376, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(5454, 16, false);
#line 94 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5470, 59, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n");
                EndContext();
#line 96 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else if (item.CategoryId == 6)
                                    {

#line default
#line hidden
                BeginContext(5675, 112, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(5788, 15, false);
#line 100 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5803, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(5874, 9, false);
#line 101 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(5883, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(5961, 16, false);
#line 102 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5977, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(5979, 15, false);
#line 102 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5994, 59, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n");
                EndContext();
#line 104 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else if (item.CategoryId == 7)
                                    {

#line default
#line hidden
                BeginContext(6199, 113, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span> ");
                EndContext();
                BeginContext(6313, 9, false);
#line 108 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(6322, 72, true);
                WriteLiteral(" m<sup>2</sup> </span>\r\n                                        </div>\r\n");
                EndContext();
#line 110 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else if (item.CategoryId == 8)
                                    {

#line default
#line hidden
                BeginContext(6540, 113, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span> ");
                EndContext();
                BeginContext(6654, 9, false);
#line 114 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(6663, 64, true);
                WriteLiteral(" sot </span> |\r\n                                        </div>\r\n");
                EndContext();
#line 116 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(6847, 112, true);
                WriteLiteral("                                        <div class=\"detail\">\r\n                                            <span>");
                EndContext();
                BeginContext(6960, 15, false);
#line 120 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                             Write(item.Room.Count);

#line default
#line hidden
                EndContext();
                BeginContext(6975, 70, true);
                WriteLiteral(" otaqlı </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(7046, 9, false);
#line 121 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Area);

#line default
#line hidden
                EndContext();
                BeginContext(7055, 77, true);
                WriteLiteral(" m<sup>2</sup> </span> |\r\n                                            <span> ");
                EndContext();
                BeginContext(7133, 16, false);
#line 122 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                              Write(item.Floor.Count);

#line default
#line hidden
                EndContext();
                BeginContext(7149, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(7151, 15, false);
#line 122 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                                                Write(item.Rank.Count);

#line default
#line hidden
                EndContext();
                BeginContext(7166, 59, true);
                WriteLiteral(" m</span>\r\n                                        </div>\r\n");
                EndContext();
#line 124 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }

#line default
#line hidden
                BeginContext(7264, 102, true);
                WriteLiteral("                                    <div class=\"date\">\r\n                                        <span>");
                EndContext();
                BeginContext(7367, 14, false);
#line 126 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(item.City.Name);

#line default
#line hidden
                EndContext();
                BeginContext(7381, 56, true);
                WriteLiteral(",</span>\r\n                                        <span>");
                EndContext();
                BeginContext(7438, 49, false);
#line 127 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                         Write(String.Format("{0:MM/dd/yyyy}", item.PublishDate));

#line default
#line hidden
                EndContext();
                BeginContext(7487, 53, true);
                WriteLiteral("</span>\r\n                                    </div>\r\n");
                EndContext();
#line 129 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                     if (item.IsVip == true)
                                    {

#line default
#line hidden
                BeginContext(7641, 72, true);
                WriteLiteral("                                        <i class=\"fas fa-gem gem\"></i>\r\n");
                EndContext();
#line 132 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }
                                    else if (item.IsPremium == true)
                                    {

#line default
#line hidden
                BeginContext(7861, 78, true);
                WriteLiteral("                                        <i class=\"fas fa-crown premium\"></i>\r\n");
                EndContext();
#line 136 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                                    }

#line default
#line hidden
                BeginContext(7978, 128, true);
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
#line 23 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
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
            BeginContext(8110, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 142 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
            }

#line default
#line hidden
            BeginContext(8151, 166, true);
            WriteLiteral("        </div>\r\n        <div class=\"row Advertisement-place justify-content-center\">\r\n            <div class=\"load-more  mt-3 col-md-4 col-6 \" data-aos=\"fade-left\">\r\n");
            EndContext();
#line 146 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                 if (Model.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false).Count() > 20)
                {

#line default
#line hidden
            BeginContext(8446, 117, true);
            WriteLiteral("                    <input type=\"hidden\" value=\"20\" id=\"changeSkipUsual\" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8563, "\"", 8653, 1);
#line 149 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
WriteAttributeValue("", 8571, Model.Advertisements.Where(x => x.IsPremium == false && x.IsVip == false).Count(), 8571, 82, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8654, 197, true);
            WriteLiteral(" />\r\n                    <a class=\"btn Btn-yellow  btn-block load-more-btn-Usual\">\r\n                        <i class=\"fas fa-plus\"></i> Daha\r\n                        çox\r\n                    </a>\r\n");
            EndContext();
#line 154 "C:\Users\Fuad\Desktop\Evimiz\Evimiz\Views\Elan\AllUsual.cshtml"
                }

#line default
#line hidden
            BeginContext(8870, 93, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- last Advertisement end -->\r\n");
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
