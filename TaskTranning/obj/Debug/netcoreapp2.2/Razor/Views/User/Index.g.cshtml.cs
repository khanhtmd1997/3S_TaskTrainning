#pragma checksum "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a40fea878eb071011a60a6af8e7d6560e4a319f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 2 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
using TaskTranning.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40fea878eb071011a60a6af8e7d6560e4a319f2", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5150a7bc51847e0bdcea41547885033983a2d189", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TaskTranning.ViewModels.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/create.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/key.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
  
    ViewBag.Title = Localizer.GetLocalizedHtmlString("t_user");
    Layout = "_NavbarDataTable";

#line default
#line hidden
            BeginContext(294, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(625, 12, true);
            WriteLiteral("﻿ \n        \n");
            EndContext();
#line 17 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
      if (TempData["succcessMessage"] != null)
     {

#line default
#line hidden
            BeginContext(691, 45, true);
            WriteLiteral("         <h5 class=\"text-danger text-center\">");
            EndContext();
            BeginContext(737, 27, false);
#line 19 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                                        Write(TempData["succcessMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(764, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 20 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
     }

#line default
#line hidden
            BeginContext(777, 57, true);
            WriteLiteral("<div class=\"sectionContent\">\n    <h3 class=\"text-center\">");
            EndContext();
            BeginContext(835, 42, false);
#line 22 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                       Write(Localizer.GetLocalizedHtmlString("t_user"));

#line default
#line hidden
            EndContext();
            BeginContext(877, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 23 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
     if (ViewBag.Count == 0)
    {

#line default
#line hidden
            BeginContext(918, 30, true);
            WriteLiteral("        <p class=\"text-right\">");
            EndContext();
            BeginContext(949, 49, false);
#line 25 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                         Write(Localizer.GetLocalizedHtmlString("p_error_table"));

#line default
#line hidden
            EndContext();
            BeginContext(998, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1001, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a40fea878eb071011a60a6af8e7d6560e4a319f29131", async() => {
                BeginContext(1024, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a40fea878eb071011a60a6af8e7d6560e4a319f29395", async() => {
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
            BeginContext(1070, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 26 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1096, 30, true);
            WriteLiteral("        <p class=\"text-right\">");
            EndContext();
            BeginContext(1127, 42, false);
#line 29 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                         Write(Localizer.GetLocalizedHtmlString("p_find"));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1172, 13, false);
#line 29 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                                                                      Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1185, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1187, 42, false);
#line 29 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                                                                                     Write(Localizer.GetLocalizedHtmlString("p_user"));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1232, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a40fea878eb071011a60a6af8e7d6560e4a319f213032", async() => {
                BeginContext(1255, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a40fea878eb071011a60a6af8e7d6560e4a319f213297", async() => {
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
            BeginContext(1301, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 30 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1312, 120, true);
            WriteLiteral("    <table id=\"table_id\" class=\"table table-bordered\">\n        <thead class=\"text-center\">\n        <tr>\n            <th>");
            EndContext();
            BeginContext(1433, 44, false);
#line 34 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_email"));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1500, 47, false);
#line 35 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_password"));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1570, 47, false);
#line 36 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_fullName"));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1640, 44, false);
#line 37 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_phone"));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1707, 46, false);
#line 38 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_picture"));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1776, 46, false);
#line 39 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_address"));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1845, 47, false);
#line 40 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_isActive"));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1915, 48, false);
#line 41 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_storeName"));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(1986, 45, false);
#line 42 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
           Write(Localizer.GetLocalizedHtmlString("th_action"));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 53, true);
            WriteLiteral("</th>\n        </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 46 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
         foreach (var item  in Model)
        {

#line default
#line hidden
            BeginContext(2132, 82, true);
            WriteLiteral("                <tr>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(2215, 40, false);
#line 50 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2255, 258, true);
            WriteLiteral(@"
                    </td >
                    <td scope=""row"">
                        <div id=""modal-placeholder""></div>
                        <button type=""button"" class=""btn btn-primary"" data-toggle=""ajax-modal"" data-target=""#edit-password"" data-url=""");
            EndContext();
            BeginContext(2514, 47, false);
#line 54 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                                                                                                                                 Write(Url.Action("EditPassword", new {id = @item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 31, true);
            WriteLiteral("\">\n                            ");
            EndContext();
            BeginContext(2592, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a40fea878eb071011a60a6af8e7d6560e4a319f220741", async() => {
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
            BeginContext(2631, 123, true);
            WriteLiteral("\n                        </button>\n\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(2755, 43, false);
#line 60 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2798, 88, true);
            WriteLiteral("\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(2887, 40, false);
#line 63 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2927, 92, true);
            WriteLiteral("\n                    </td>\n                    <td scope=\"row\">\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3019, "\"", 3076, 2);
            WriteAttributeValue("", 3025, "/images/", 3025, 8, true);
#line 66 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
WriteAttributeValue("", 3033, Html.DisplayFor(modelItem => item.Picture), 3033, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3077, 113, true);
            WriteLiteral(" width=\"50\" height=\"50\"/>\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(3191, 42, false);
#line 69 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3233, 88, true);
            WriteLiteral("\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(3322, 43, false);
#line 72 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(3365, 88, true);
            WriteLiteral("\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(3454, 50, false);
#line 75 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Store.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(3504, 88, true);
            WriteLiteral("\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(3592, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a40fea878eb071011a60a6af8e7d6560e4a319f224988", async() => {
                BeginContext(3637, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a40fea878eb071011a60a6af8e7d6560e4a319f225253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
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
            BeginContext(3681, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(3706, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a40fea878eb071011a60a6af8e7d6560e4a319f228435", async() => {
                BeginContext(3826, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(3855, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a40fea878eb071011a60a6af8e7d6560e4a319f228843", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3896, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3762, "return", 3762, 6, true);
            AddHtmlAttributeValue(" ", 3768, "confirm(\'", 3769, 10, true);
#line 79 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 3778, Localizer.GetLocalizedHtmlString("msg_del"), 3778, 44, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3822, "\')", 3822, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3925, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 84 "C:\Users\Admin\Desktop\3STask\3S\TaskTranning\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3984, 1216, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>
<script>
    $(function () {
        var placeholderElement = $('#modal-placeholder');

        $('button[data-toggle=""ajax-modal""]').click(function (event) {
            var url = $(this).data('url');
            $.get(url).done(function (data) {
                placeholderElement.html(data);
                placeholderElement.find('.modal').modal('show');
            });
        });

        placeholderElement.on('click', '[data-save=""modal""]', function (event) {
            event.preventDefault();

            var form = $(this).parents('.modal').find('form');
            var actionUrl = form.attr('action');
            var dataToSend = form.serialize();

            $.post(actionUrl, dataToSend).done(function (data) {
                var newBody = $('.modal-body', data);
                placeholderElement.find('.modal-body').replaceWith(newBody);

                var isValid = newBody.find('[name=""IsValid""]').val() == 'True';
                if (isValid) {
            ");
            WriteLiteral("        $(\'#modal-placeholder\').text(\'Successfully!\');\n                    placeholderElement.find(\'.modal\').modal(\'hide\');\n                }\n            });\n        });\n    });\n</script>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TaskTranning.ViewModels.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
