#pragma checksum "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e167e7e331a511a0727688522c9c0e3e5c57cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InlineEditor), @"mvc.1.0.view", @"/Views/Home/InlineEditor.cshtml")]
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
#line 1 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\_ViewImports.cshtml"
using MVC1P;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\_ViewImports.cshtml"
using MVC1P.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\_ViewImports.cshtml"
using MVC1P.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e167e7e331a511a0727688522c9c0e3e5c57cb", @"/Views/Home/InlineEditor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74ad27fb74a64b34ebce730129e3d9395046d90", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InlineEditor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListAndCategory>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-1 font-weight-bold\">Id</div>\r\n    <div class=\"col font-weight-bold\">Name</div>\r\n    <div class=\"col font-weight-bold\">Purchase Price</div>\r\n    <div class=\"col font-weight-bold\">Retail Price</div>\r\n</div>\r\n");
#nullable restore
#line 10 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
   int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e167e7e331a511a0727688522c9c0e3e5c57cb5422", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
     foreach (Product p in Model.Products)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row p-2\">\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 17 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
           Write(p.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 517, "\"", 539, 3);
                WriteAttributeValue("", 524, "Products[", 524, 9, true);
#nullable restore
#line 18 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
WriteAttributeValue("", 533, i, 533, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 535, "].Id", 535, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 540, "\"", 553, 1);
#nullable restore
#line 18 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
WriteAttributeValue("", 548, p.Id, 548, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 653, "\"", 677, 3);
                WriteAttributeValue("", 660, "Products[", 660, 9, true);
#nullable restore
#line 21 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
WriteAttributeValue("", 669, i, 669, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 671, "].Name", 671, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 678, "\"", 693, 1);
#nullable restore
#line 21 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
WriteAttributeValue("", 686, p.Name, 686, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <select class=\"form-control\">\r\n");
#nullable restore
#line 26 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
                         if (p.ProductCategory.Id == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e167e7e331a511a0727688522c9c0e3e5c57cb8481", async() => {
                    WriteLiteral("Chooese Category");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
                         foreach (Category c in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e167e7e331a511a0727688522c9c0e3e5c57cb10645", async() => {
                    WriteLiteral(" c.Name");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
AddHtmlAttributeValue("", 1167, p.ProductCategory?.Id == c.Id , 1167, 33, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
                                                                          WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 33 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n            <div class=\"col\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1409, "\"", 1442, 3);
                WriteAttributeValue("", 1416, "Products[", 1416, 9, true);
#nullable restore
#line 38 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
WriteAttributeValue("", 1425, i, 1425, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1427, "].PurchasePrice", 1427, 15, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1443, "\"", 1467, 1);
#nullable restore
#line 38 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
WriteAttributeValue("", 1451, p.PurchasePrice, 1451, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1567, "\"", 1598, 3);
                WriteAttributeValue("", 1574, "Products[", 1574, 9, true);
#nullable restore
#line 41 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
WriteAttributeValue("", 1583, i, 1583, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1585, "].RetailPrice", 1585, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1599, "\"", 1621, 1);
#nullable restore
#line 41 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
WriteAttributeValue("", 1607, p.RetailPrice, 1607, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 44 "D:\Calismalar\Mvc02042022\MVC1\MVC1P\MVC1P\Views\Home\InlineEditor.cshtml"
        i++;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"text-center mt-2\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">Save All</button>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e167e7e331a511a0727688522c9c0e3e5c57cb15436", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListAndCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591