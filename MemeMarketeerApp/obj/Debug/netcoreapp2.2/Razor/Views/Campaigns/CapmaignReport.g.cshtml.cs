#pragma checksum "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4fe4b97fe02379f3a09b0ca83b0c9bb10bb44df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaigns_CapmaignReport), @"mvc.1.0.view", @"/Views/Campaigns/CapmaignReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Campaigns/CapmaignReport.cshtml", typeof(AspNetCore.Views_Campaigns_CapmaignReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4fe4b97fe02379f3a09b0ca83b0c9bb10bb44df", @"/Views/Campaigns/CapmaignReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdbd2659d5bc1cd8cbf9f9eefe1782a8efa3036", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaigns_CapmaignReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemeMarketeerApp.Models.Campaign>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("report-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/asset/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Campaigns", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CapmaignReportWithImpression", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CapmaignReportNoDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/jquery.dataTables.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/dataTables.bootstrap4.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/window.print.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(101, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(169, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(188, 740, true);
                WriteLiteral(@"
    <style>
        .topActionFallbackUrl {
            display: none;
        }

        #table_1 thead:first-child tr th:first-child {
            width: 90%
        }

        div.dt-loading {
            display: none;
        }

        .report-logo {
            width: 200px;
            height: 55px;
        }

        .bn-logo {
            width: 75px;
        }

        .cash-pay {
            border: 1px solid #000;
            padding: 0 5px 0 5px;
        }
        .costPerSomething {
            background-color: #74F700;
        }

        .bottom-info {
            padding-left: 10px
        }

        .received-by {
            border: 1px solid #000;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(931, 208, true);
            WriteLiteral("\r\n<div class=\"card-body px-0 pb-2 pt-3\" id=\"main_content\">\r\n\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"row justify-content-center\">\r\n\r\n            <div class=\"col-lg-12 text-center\">\r\n                ");
            EndContext();
            BeginContext(1139, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4fe4b97fe02379f3a09b0ca83b0c9bb10bb44df9590", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1201, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1312, 213, true);
            WriteLiteral("\r\n                <p class=\"text-center mb-0 print-style5\">\"Traffic that matters\"</p>\r\n                <h2 class=\"h2 text-center text-uppercase mb-3 mt-2 print-style6 cash-pay d-inline-block\">Campaingn Report for ");
            EndContext();
            BeginContext(1526, 28, false);
#line 63 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                                                                                                                         Write(ViewBag.Campaign.Client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1554, 207, true);
            WriteLiteral("</h2>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row mx-0\">\r\n            <div class=\"col-lg-6 text-left\">\r\n                <div class=\"mt-0 mb-4\">\r\n");
            EndContext();
            BeginContext(1843, 77, true);
            WriteLiteral("                    <h3 class=\"mb-0 mt-0\" style=\"font-weight:700\">Greetings, ");
            EndContext();
            BeginContext(1921, 28, false);
#line 74 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                                                                        Write(ViewBag.Campaign.Client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1949, 282, true);
            WriteLiteral(@"</h3>
                    <br />
                    <h3 class=""mb-0 mt-0"" style=""font-weight:400"">We have successfully completed your order.</h3>
                </div>
            </div>
            <div class=""col-lg-6 text-right"">
                <div class=""mt-0 mb-4"">
");
            EndContext();
            BeginContext(2313, 79, true);
            WriteLiteral("                    <h5 class=\"mb-0 mt-0\" style=\"font-weight:400\">Start Date : ");
            EndContext();
            BeginContext(2393, 45, false);
#line 82 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                                                                          Write(String.Format("{0:dd-MM-yyyy}", DateTime.Now));

#line default
#line hidden
            EndContext();
            BeginContext(2438, 85, true);
            WriteLiteral(" </h5>\r\n                    <h5 class=\"mb-0 mt-0\" style=\"font-weight:400\">End Date : ");
            EndContext();
            BeginContext(2524, 45, false);
#line 83 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                                                                        Write(String.Format("{0:dd-MM-yyyy}", DateTime.Now));

#line default
#line hidden
            EndContext();
            BeginContext(2569, 673, true);
            WriteLiteral(@"</h5>
                </div>
            </div>

        </div>
    </div>

    <div class=""table-responsive"">
        <table id=""tabl"" class=""table align-items-center table-hover table-striped table-bordered"">


            <thead class=""thead-light"">
                <tr>
                    <th colspan=""6"" class=""text-center border-bottom ac-head-title"">Order Details</th>
                </tr>

            </thead>
            <tbody>

                <tr>
                    <td  class=""text-center"">
                        Budget
                    </td>

                    <td colspan=""2"" class=""text-center"">
                        ");
            EndContext();
            BeginContext(3243, 28, false);
#line 108 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                   Write(ViewBag.Campaign.TotalBudget);

#line default
#line hidden
            EndContext();
            BeginContext(3271, 234, true);
            WriteLiteral(" ₹\r\n                    </td>\r\n                    <td colspan=\"2\" class=\"text-center\">\r\n                        Expected impressions\r\n                    </td>\r\n\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(3506, 33, false);
#line 115 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                   Write(ViewBag.Campaign.TargetImpression);

#line default
#line hidden
            EndContext();
            BeginContext(3539, 1141, true);
            WriteLiteral(@"
                    </td>
                </tr>
            </tbody>
            <thead class=""thead-light"">
                <tr>
                    <th colspan=""7"" class=""text-center border-bottom ac-head-title"">Results</th>
                </tr>

            </thead>
            <tbody>
                <tr>
                    <td class=""text-center"">
                        Followers Generated
                    </td>
                    <td class=""text-center"">
                        Impressions Generated
                    </td>
                    <td class=""text-center"">
                        Link Clicks
                    </td>
                    <td class=""text-center"">
                        CPF
                    </td>
                    <td class=""text-center"">
                        CPM
                    </td>
                    <td class=""text-center"">
                        CPC
                    </td>
                  


                 

");
            WriteLiteral("\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(4681, 40, false);
#line 154 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                   Write(ViewBag.Campaign.TotalFollowerIncreament);

#line default
#line hidden
            EndContext();
            BeginContext(4721, 99, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(4821, 27, false);
#line 157 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                   Write(ViewBag.GeneratedImpression);

#line default
#line hidden
            EndContext();
            BeginContext(4848, 101, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(4950, 33, false);
#line 161 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                   Write(ViewBag.Campaign.TotalLinkClicked);

#line default
#line hidden
            EndContext();
            BeginContext(4983, 99, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(5083, 48, false);
#line 164 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                   Write(String.Format("{0:.##}", ViewBag.CostPerFollwer));

#line default
#line hidden
            EndContext();
            BeginContext(5131, 106, true);
            WriteLiteral("  ₹\r\n                    </td>\r\n\r\n\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(5238, 55, false);
#line 169 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                   Write(String.Format("{0:.##}", ViewBag.CostPer1000Impression));

#line default
#line hidden
            EndContext();
            BeginContext(5293, 34, true);
            WriteLiteral("  ₹\r\n                    </td>\r\n\r\n");
            EndContext();
#line 172 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                     if (ViewBag.CostPerClick == 0)
                    {

#line default
#line hidden
            BeginContext(5403, 114, true);
            WriteLiteral("                        <td class=\"text-center\">\r\n                            N/A\r\n                        </td>\r\n");
            EndContext();
#line 177 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(5589, 78, true);
            WriteLiteral("                        <td class=\"text-center\">\r\n                            ");
            EndContext();
            BeginContext(5668, 46, false);
#line 181 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                       Write(String.Format("{0:.##}", ViewBag.CostPerClick));

#line default
#line hidden
            EndContext();
            BeginContext(5714, 36, true);
            WriteLiteral("  ₹\r\n                        </td>\r\n");
            EndContext();
#line 183 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                    }

#line default
#line hidden
            BeginContext(5773, 385, true);
            WriteLiteral(@"                </tr>

            </tbody>

            <thead class=""thead-light"">

                <tr>
                    <th colspan=""4"" class=""text-center border-bottom ac-head-title"">Page</th>
                    <th colspan=""3"" class=""text-center border-bottom ac-head-title"">Post Type</th>
                </tr>



            </thead>
            <tbody>


");
            EndContext();
#line 201 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                 foreach (var post in ViewBag.Campaign.Posts)
                {

#line default
#line hidden
            BeginContext(6240, 116, true);
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"4\" class=\"text-center\">\r\n                            ");
            EndContext();
            BeginContext(6357, 19, false);
#line 205 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                       Write(post.Affiliate.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6376, 123, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td colspan=\"3\" class=\"text-center\">\r\n                            ");
            EndContext();
            BeginContext(6500, 18, false);
#line 208 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                       Write(post.PostType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6518, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 211 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                }

#line default
#line hidden
            BeginContext(6597, 790, true);
            WriteLiteral(@"

            </tbody>
        </table>
    </div>
    <div class=""container"">
        <div class=""row mx-0"">
            <div class=""col-lg-12"">
                <div class=""mt-4"">
                    <h4 class=""mb-0 mt-0"" style=""font-weight:600"">We hope you are happy with the results.</h4>
                    <h4 class=""mb-0 mt-0"" style=""font-weight:600"">Thank you for trusting TRAFIKGRAM. We look forward to work with you again.</h4>
                    <h4 class=""mb-0 mt-0"" style=""font-weight:400"">**CPC- cost per click</h4>
                    <h4 class=""mb-0 mt-0"" style=""font-weight:400"">**CPF-cost per follower</h4>
                    <h4 class=""mb-0 mt-0"" style=""font-weight:400"">**CPM- cost per 1000 impressions</h4>
                </div>
            </div>

");
            EndContext();
            BeginContext(7805, 241, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n<div id=\"editor\"></div>\r\n<div class=\"col-lg-12\">\r\n    <div class=\"text-center my-3\">\r\n        <button class=\"btn btn-info\" onclick=\"pop_print()\"><i class=\"fa fa-print mr-2\"></i>Print</button>\r\n        ");
            EndContext();
            BeginContext(8046, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4fe4b97fe02379f3a09b0ca83b0c9bb10bb44df23650", async() => {
                BeginContext(8178, 12, true);
                WriteLiteral("With Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 246 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                                                                                  WriteLiteral(ViewBag.Campaign.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8194, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(8204, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4fe4b97fe02379f3a09b0ca83b0c9bb10bb44df26336", async() => {
                BeginContext(8331, 15, true);
                WriteLiteral("With No Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 247 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
                                                                             WriteLiteral(ViewBag.Campaign.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8350, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8390, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8396, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4fe4b97fe02379f3a09b0ca83b0c9bb10bb44df29215", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 251 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8515, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8521, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4fe4b97fe02379f3a09b0ca83b0c9bb10bb44df31376", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 252 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8644, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8650, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4fe4b97fe02379f3a09b0ca83b0c9bb10bb44df33538", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 253 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8720, 683, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf/0.9.0rc1/jspdf.min.js""></script>
    <script>


        function pop_print() {
            w = window.open(null, 'Print_Page', 'scrollbars=yes');
            var custom = '<style>' +
                '.table-bordered th.ac-head-title{border-left:0!important;border-right:0!important;padding-top: 5px;padding-bottom: 5px;}.table-responsive{display:block;width:100%}table{border-collapse:collapse}.table td, .table th{padding:3px}.table .thead-light th{color:#fff;background:#355C7D;border-bottom:0;border-top:0}.print-style1{margin-top:4rem!important}.print-style5{margin-top: 0!important;} ");
                EndContext();
                BeginContext(9404, 1098, true);
                WriteLiteral(@"@page{size:auto;margin:0}.table thead th{font-size:12px}.table thead th{border-top: 1px solid #000!important;}.table-bordered td,.table-bordered th{border:1px solid #000!important;font-size: 13px;}table{width:100%}table tr{height:20px}.btn-default{display:none}.col-6{text-align:center}.mb-0{margin-bottom:0!important}.col-6 h4{margin-top:0;font-size: .9375rem;font-weight: 600;line-height: 1.5;}.col-6 h2{margin-top: 0;font-size: 1.25rem;font-weight: 600;line-height: 1.5;}.employee-photo{display:block;margin: auto auto 30px auto;width: 150px;}.avatar-upload{display:none}.table thead:first-child tr th:first-child{width:90%} .cash-pay {border: 1px solid #000;padding: 0 5px 0 5px;display: inline-block;}td.taka{text-align:right}.table tr th {font-size:13px}.table{width:100%;}.report-logo{width:200px;height: 55px;}.bn-logo{width:75px}.customstyle1print{display:none}.btn-info{display:none}.text-primary{color:#000!important;margin: 0 auto;}.print-style1{margin-top:4rem!important}.print-style5{margin-top:0px!important}.");
                WriteLiteral("print-style6{margin-top:10px!important}.print-style2{margin-left: -11px;} ");
                EndContext();
                BeginContext(10503, 330, true);
                WriteLiteral(@"@page{size:auto;margin-left: 7mm;}.received-by{border:1px solid #000}.costPerSomething{background-color: #74F700 !important;}'
                + '</style>';
            w.document.write(custom + windowPrint + jQuery('#main_content').html());
            w.document.close();
            w.print();
        }

    </script>
");
                EndContext();
#line 269 "D:\MemeMarketeerApp\MemeMarketeerApp\Views\Campaigns\CapmaignReport.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemeMarketeerApp.Models.Campaign> Html { get; private set; }
    }
}
#pragma warning restore 1591
