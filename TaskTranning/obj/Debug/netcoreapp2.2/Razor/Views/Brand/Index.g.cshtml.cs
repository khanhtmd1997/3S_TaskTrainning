#pragma checksum "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "462451ae8eb0f4be72f5e0751e0a0bf72a145620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brand_Index), @"mvc.1.0.view", @"/Views/Brand/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Brand/Index.cshtml", typeof(AspNetCore.Views_Brand_Index))]
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
#line 2 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
using TaskTranning.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462451ae8eb0f4be72f5e0751e0a0bf72a145620", @"/Views/Brand/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5150a7bc51847e0bdcea41547885033983a2d189", @"/Views/_ViewImports.cshtml")]
    public class Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TaskTranning.ViewModels.BrandViewModel.BrandViewModel>>
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
#line 4 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
  
    ViewBag.Title = Localizer.GetLocalizedHtmlString("t_brand");
    Layout = "_NavbarDataTable";

#line default
#line hidden
            BeginContext(236, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 10 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
     if (TempData["succcessMessage"] != null)
    {

#line default
#line hidden
            BeginContext(290, 44, true);
            WriteLiteral("        <h5 class=\"text-danger text-center\">");
            EndContext();
            BeginContext(335, 27, false);
#line 12 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
                                       Write(TempData["succcessMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(362, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 13 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(374, 65, true);
            WriteLiteral("    <div class=\"sectionContent\">\n        <h3 class=\"text-center\">");
            EndContext();
            BeginContext(440, 43, false);
#line 15 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
                           Write(Localizer.GetLocalizedHtmlString("t_brand"));

#line default
#line hidden
            EndContext();
            BeginContext(483, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 16 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
         if (ViewBag.Count == 0)
        {

#line default
#line hidden
            BeginContext(532, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(548, 49, false);
#line 18 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
          Write(Localizer.GetLocalizedHtmlString("p_error_table"));

#line default
#line hidden
            EndContext();
            BeginContext(597, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(600, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "462451ae8eb0f4be72f5e0751e0a0bf72a1456208339", async() => {
                BeginContext(623, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "462451ae8eb0f4be72f5e0751e0a0bf72a1456208602", async() => {
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
            BeginContext(669, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 19 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(707, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(723, 42, false);
#line 22 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
          Write(Localizer.GetLocalizedHtmlString("p_find"));

#line default
#line hidden
            EndContext();
            BeginContext(765, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(768, 13, false);
#line 22 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
                                                       Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(781, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(783, 43, false);
#line 22 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
                                                                      Write(Localizer.GetLocalizedHtmlString("p_brand"));

#line default
#line hidden
            EndContext();
            BeginContext(826, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(829, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "462451ae8eb0f4be72f5e0751e0a0bf72a14562012185", async() => {
                BeginContext(852, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "462451ae8eb0f4be72f5e0751e0a0bf72a14562012449", async() => {
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
            BeginContext(898, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 23 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(913, 117, true);
            WriteLiteral("\n        <table id=\"table_id\" class=\"table table-bordered\">\n            <thead>\n            <tr>\n                <th>");
            EndContext();
            BeginContext(1031, 48, false);
#line 28 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("th_brandName"));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 26, true);
            WriteLiteral("</th>\n                <th>");
            EndContext();
            BeginContext(1106, 45, false);
#line 29 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("th_action"));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 65, true);
            WriteLiteral("</th>\n            </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 33 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
             foreach (var item  in Model)
            {

#line default
#line hidden
            BeginContext(1272, 94, true);
            WriteLiteral("                    <tr>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(1367, 44, false);
#line 37 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 128, true);
            WriteLiteral("\n                        </td >\n                        <td scope=\"row\" style=\"text-align: center\">\n                            ");
            EndContext();
            BeginContext(1539, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "462451ae8eb0f4be72f5e0751e0a0bf72a14562016683", async() => {
                BeginContext(1584, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "462451ae8eb0f4be72f5e0751e0a0bf72a14562016948", async() => {
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
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
            BeginContext(1628, 29, true);
            WriteLiteral("\n                            ");
            EndContext();
            BeginContext(1657, 227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "462451ae8eb0f4be72f5e0751e0a0bf72a14562020139", async() => {
                BeginContext(1777, 33, true);
                WriteLiteral("\n                                ");
                EndContext();
                BeginContext(1810, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "462451ae8eb0f4be72f5e0751e0a0bf72a14562020551", async() => {
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
                BeginContext(1851, 29, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1713, "return", 1713, 6, true);
            AddHtmlAttributeValue(" ", 1719, "confirm(\'", 1720, 10, true);
#line 41 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
AddHtmlAttributeValue("", 1729, Localizer.GetLocalizedHtmlString("msg_del"), 1729, 44, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1773, "\')", 1773, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1884, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 46 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\Brand\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1955, 48, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TaskTranning.ViewModels.BrandViewModel.BrandViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591