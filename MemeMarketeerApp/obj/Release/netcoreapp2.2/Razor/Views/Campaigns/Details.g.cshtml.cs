#pragma checksum "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb8902550ad769d2f8e2e4b257ab8099d896b06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaigns_Details), @"mvc.1.0.view", @"/Views/Campaigns/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Campaigns/Details.cshtml", typeof(AspNetCore.Views_Campaigns_Details))]
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
#line 1 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\_ViewImports.cshtml"
using MemeMarketeerApp;

#line default
#line hidden
#line 2 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\_ViewImports.cshtml"
using MemeMarketeerApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb8902550ad769d2f8e2e4b257ab8099d896b06", @"/Views/Campaigns/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdbd2659d5bc1cd8cbf9f9eefe1782a8efa3036", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaigns_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/vendor/chart.js/Chart.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Campaigns", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-fromHome", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/chart.js/Chart.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/chart.js/utils.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
  
    ViewData["Title"] = "Campaign";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(60, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(66, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbb8902550ad769d2f8e2e4b257ab8099d896b066490", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
#line 6 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(155, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(177, 105, true);
                WriteLiteral("\r\n    <style>\r\n        .gcb-table {\r\n            padding: 3px 10px !important;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(285, 599, true);
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""row"">
                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Campaign Title</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(885, 22, false);
#line 27 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.Campaign.Title);

#line default
#line hidden
            EndContext();
            BeginContext(907, 963, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">
                                        <i class=""far fa-image""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Client Name</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(1871, 28, false);
#line 45 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.Campaign.Client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1899, 963, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">
                                        <i class=""far fa-user""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Total Budget</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(2863, 28, false);
#line 63 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.Campaign.TotalBudget);

#line default
#line hidden
            EndContext();
            BeginContext(2891, 976, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">
                                        <i class=""far fa-money-bill""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Target Impression</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(3868, 33, false);
#line 82 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.Campaign.TargetImpression);

#line default
#line hidden
            EndContext();
            BeginContext(3901, 980, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">
                                        <i class=""far fa-user""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Total Impressions Generated</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(4882, 23, false);
#line 101 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.TotalImpression);

#line default
#line hidden
            EndContext();
            BeginContext(4905, 973, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">
                                        <i class=""far fa-thumbs-up""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Total Link Clicks</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(5879, 22, false);
#line 119 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.TotalLinkClick);

#line default
#line hidden
            EndContext();
            BeginContext(5901, 987, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">
                                        <i class=""far fa-mouse-pointer""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Total Followers Generated</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(6889, 31, false);
#line 138 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.TotalFollowersGenerated);

#line default
#line hidden
            EndContext();
            BeginContext(6920, 619, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">

                                        <i class=""far fa-user-plus""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
");
            EndContext();
#line 154 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                         if (ViewBag.Campaign.BitlyLink != "" && ViewBag.Campaign.BitlyLink != null)
                        {

#line default
#line hidden
            BeginContext(7668, 899, true);
            WriteLiteral(@"                            <a href=""ViewBag.Campaign.BitlyLink"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col"">
                                            <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Campaign Link</h5>

                                        </div>
                                        <div class=""col-auto"">
                                            <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">

                                                <i class=""far fa-link""></i>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </a>
");
            EndContext();
#line 173 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(8651, 850, true);
            WriteLiteral(@"                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col"">
                                        <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Campaign Link</h5>
                                        <span class=""h2 font-weight-bold mb-0 text-white"">N/A</span>
                                    </div>
                                    <div class=""col-auto"">
                                        <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">

                                            <i class=""far fa-link""></i>
                                        </div>
                                    </div>
                                </div>

                            </div>
");
            EndContext();
#line 191 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"

                        }

#line default
#line hidden
            BeginContext(9530, 535, true);
            WriteLiteral(@"                    </div>
                </div>





                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-indigo"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Total Expense</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(10066, 20, false);
#line 206 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.TotalExpense);

#line default
#line hidden
            EndContext();
            BeginContext(10086, 970, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">

                                        <i class=""far fa-exchange""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class=""col-xl-6 col-md-6"">
                    <div class=""card card-stats bg-gradient-success"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0 text-white"">Total Profit</h5>
                                    <span class=""h2 font-weight-bold mb-0 text-white"">");
            EndContext();
            BeginContext(11057, 19, false);
#line 225 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                 Write(ViewBag.TotalProfit);

#line default
#line hidden
            EndContext();
            BeginContext(11076, 1131, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-white text-default rounded-circle shadow"">

                                        <i class=""far fa-rupee-sign""></i>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-header p-3 border-0"">
                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""text-left"">
                                <h3 class=""mb-0 skewed skewed-green d-inline-block text-white ls-1 text-uppercase"">Affiliates Used</h3>
                            </div>
                        </div>
                        ");
            WriteLiteral("<div class=\"col-6\">\r\n                            <div class=\"text-right\">\r\n                                ");
            EndContext();
            BeginContext(12207, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb8902550ad769d2f8e2e4b257ab8099d896b0625382", async() => {
                BeginContext(12345, 13, true);
                WriteLiteral("View Activity");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 252 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                                         WriteLiteral(ViewBag.Campaign.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-fromHome", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fromHome"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12362, 853, true);
            WriteLiteral(@"
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table align-items-center table-flush"">
                        <thead class=""thead-custom"">


                            <tr>
                                <th class=""text-center align-middle"">Name</th>
                                <th class=""text-center align-middle"">Catagory</th>
                                <th class=""text-center align-middle"">Language</th>
                                <th class=""text-center align-middle"">WhatsApp</th>
                                <th class=""text-center align-middle"">Email</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 272 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                             foreach (var affiliate in ViewBag.Affiliates)
                            {

#line default
#line hidden
            BeginContext(13322, 113, true);
            WriteLiteral("                                <tr>\r\n\r\n                                    <td class=\"text-center align-middle\">");
            EndContext();
            BeginContext(13436, 14, false);
#line 276 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                    Write(affiliate.Name);

#line default
#line hidden
            EndContext();
            BeginContext(13450, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 277 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                     if (affiliate.Catagory != null)
                                    {

#line default
#line hidden
            BeginContext(13566, 77, true);
            WriteLiteral("                                        <td class=\"text-center align-middle\">");
            EndContext();
            BeginContext(13644, 23, false);
#line 279 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                        Write(affiliate.Catagory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(13667, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 280 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(13794, 87, true);
            WriteLiteral("                                        <td class=\"text-center align-middle\">N/A</td>\r\n");
            EndContext();
#line 284 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(13920, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 285 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                     if (affiliate.AffiliateLanguage != null)
                                    {

#line default
#line hidden
            BeginContext(14038, 77, true);
            WriteLiteral("                                        <td class=\"text-center align-middle\">");
            EndContext();
            BeginContext(14116, 32, false);
#line 287 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                        Write(affiliate.AffiliateLanguage.Name);

#line default
#line hidden
            EndContext();
            BeginContext(14148, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 288 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(14275, 87, true);
            WriteLiteral("                                        <td class=\"text-center align-middle\">N/A</td>\r\n");
            EndContext();
#line 292 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(14401, 75, true);
            WriteLiteral("\r\n                                    <td class=\"text-center align-middle\">");
            EndContext();
            BeginContext(14477, 18, false);
#line 294 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                    Write(affiliate.WANumber);

#line default
#line hidden
            EndContext();
            BeginContext(14495, 80, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center align-middle\">");
            EndContext();
            BeginContext(14576, 15, false);
#line 295 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                                                                    Write(affiliate.Email);

#line default
#line hidden
            EndContext();
            BeginContext(14591, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 297 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(14668, 150, true);
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(14836, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(14842, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb8902550ad769d2f8e2e4b257ab8099d896b0634861", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 309 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14922, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(14928, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb8902550ad769d2f8e2e4b257ab8099d896b0636929", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 310 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(15004, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(15112, 393, true);
                WriteLiteral(@"
    <script>


                                                //var purple_orange_gradient = ctx.createLinearGradient(100, 0, 100, 700);
                                                //purple_orange_gradient.addColorStop(0, 'rgba(255,165,0,0.5)');
                                                //purple_orange_gradient.addColorStop(1, 'rgba(199, 34, 184, 0.5)');

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
