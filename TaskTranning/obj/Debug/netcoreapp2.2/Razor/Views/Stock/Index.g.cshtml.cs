#pragma checksum "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352236be9165730aa4045e7342abe103fe2c153f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stock_Index), @"mvc.1.0.view", @"/Views/Stock/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stock/Index.cshtml", typeof(AspNetCore.Views_Stock_Index))]
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
#line 1 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\_ViewImports.cshtml"
using TaskTranning;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\_ViewImports.cshtml"
using TaskTranning.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
using TaskTranning.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352236be9165730aa4045e7342abe103fe2c153f", @"/Views/Stock/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5150a7bc51847e0bdcea41547885033983a2d189", @"/Views/_ViewImports.cshtml")]
    public class Views_Stock_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TaskTranning.ViewModels.StockViewModel.StockViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/create.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
  
    ViewBag.Title = Localizer.GetLocalizedHtmlString("t_stock");
    Layout = "_NavbarDataTable";

#line default
#line hidden
            BeginContext(236, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 9 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
     if (TempData["succcessMessage"] != null)
    {

#line default
#line hidden
            BeginContext(289, 44, true);
            WriteLiteral("        <h5 class=\"text-danger text-center\">");
            EndContext();
            BeginContext(334, 27, false);
#line 11 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                                       Write(TempData["succcessMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(361, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 12 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(373, 65, true);
            WriteLiteral("    <div class=\"sectionContent\">\n        <h3 class=\"text-center\">");
            EndContext();
            BeginContext(439, 43, false);
#line 14 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                           Write(Localizer.GetLocalizedHtmlString("t_stock"));

#line default
#line hidden
            EndContext();
            BeginContext(482, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 15 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
         if (ViewBag.Count == 0)
        {

#line default
#line hidden
            BeginContext(531, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(547, 49, false);
#line 17 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
          Write(Localizer.GetLocalizedHtmlString("p_error_table"));

#line default
#line hidden
            EndContext();
            BeginContext(596, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(599, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "352236be9165730aa4045e7342abe103fe2c153f8336", async() => {
                BeginContext(622, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "352236be9165730aa4045e7342abe103fe2c153f8599", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(668, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 18 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(706, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(722, 42, false);
#line 21 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
          Write(Localizer.GetLocalizedHtmlString("p_find"));

#line default
#line hidden
            EndContext();
            BeginContext(764, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(767, 13, false);
#line 21 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                                                       Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(780, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(782, 43, false);
#line 21 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                                                                      Write(Localizer.GetLocalizedHtmlString("p_stock"));

#line default
#line hidden
            EndContext();
            BeginContext(825, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(828, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "352236be9165730aa4045e7342abe103fe2c153f12182", async() => {
                BeginContext(851, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "352236be9165730aa4045e7342abe103fe2c153f12446", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(897, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 22 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(912, 124, true);
            WriteLiteral("        <table id=\"table_id\" class=\"table table-bordered\">\n            <thead>\n                <tr>\n                    <th>");
            EndContext();
            BeginContext(1037, 48, false);
#line 26 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                   Write(Localizer.GetLocalizedHtmlString("th_storeName"));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 30, true);
            WriteLiteral("</th>\n                    <th>");
            EndContext();
            BeginContext(1116, 50, false);
#line 27 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                   Write(Localizer.GetLocalizedHtmlString("th_productName"));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 30, true);
            WriteLiteral("</th>\n                    <th>");
            EndContext();
            BeginContext(1197, 47, false);
#line 28 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                   Write(Localizer.GetLocalizedHtmlString("th_quantity"));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 30, true);
            WriteLiteral("</th>\n                    <th>");
            EndContext();
            BeginContext(1275, 45, false);
#line 29 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                   Write(Localizer.GetLocalizedHtmlString("th_action"));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 69, true);
            WriteLiteral("</th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 33 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
             foreach (var item  in Model)
            {

#line default
#line hidden
            BeginContext(1445, 94, true);
            WriteLiteral("                    <tr>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(1540, 50, false);
#line 37 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Store.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 100, true);
            WriteLiteral("\n                        </td>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(1691, 54, false);
#line 40 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 101, true);
            WriteLiteral("\n                        </td >\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(1847, 43, false);
#line 43 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 101, true);
            WriteLiteral("\n                        </td >\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(1991, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "352236be9165730aa4045e7342abe103fe2c153f18417", async() => {
                BeginContext(2084, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "352236be9165730aa4045e7342abe103fe2c153f18682", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                                                          WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                                                                                              WriteLiteral(item.StoreId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-storeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2128, 29, true);
            WriteLiteral("\n                            ");
            EndContext();
            BeginContext(2157, 275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "352236be9165730aa4045e7342abe103fe2c153f22640", async() => {
                BeginContext(2325, 33, true);
                WriteLiteral("\n                                ");
                EndContext();
                BeginContext(2358, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "352236be9165730aa4045e7342abe103fe2c153f23052", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2399, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                                                            WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
                                                                                                WriteLiteral(item.StoreId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-storeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2261, "return", 2261, 6, true);
            AddHtmlAttributeValue(" ", 2267, "confirm(\'", 2268, 10, true);
#line 47 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
AddHtmlAttributeValue("", 2277, Localizer.GetLocalizedHtmlString("msg_del"), 2277, 44, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2321, "\')", 2321, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2432, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 52 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Stock\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2503, 48, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ResourcesServices Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TaskTranning.ViewModels.StockViewModel.StockViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591