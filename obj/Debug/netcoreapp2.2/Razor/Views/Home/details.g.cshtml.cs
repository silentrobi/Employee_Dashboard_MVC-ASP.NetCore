#pragma checksum "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be51dd8c47f2b461c43186e0ff3a49ece1a7d7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_details), @"mvc.1.0.view", @"/Views/Home/details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/details.cshtml", typeof(AspNetCore.Views_Home_details))]
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
#line 3 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\_ViewImports.cshtml"
using EmployeeDashboard.ViewModels;

#line default
#line hidden
#line 4 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\_ViewImports.cshtml"
using EmployeeDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be51dd8c47f2b461c43186e0ff3a49ece1a7d7f", @"/Views/Home/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ffec8d8b87717cb5c43ad6a7b68ae05a203ddd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/photo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllEmployees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
   
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Employee Detail";

#line default
#line hidden
            BeginContext(125, 242, true);
            WriteLiteral("    <!-- _Layout.cshtml has the common html codes for the all cshtml files.-->\r\n<div class=\"row justify-content-center m-3\">\r\n    <div class=\" col-sm-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <h1>");
            EndContext();
            BeginContext(368, 19, false);
#line 11 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
               Write(Model.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(387, 95, true);
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\" card-body text-center\">\r\n\r\n                ");
            EndContext();
            BeginContext(482, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9be51dd8c47f2b461c43186e0ff3a49ece1a7d7f6363", async() => {
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
            BeginContext(535, 35, true);
            WriteLiteral("\r\n                <h4>Employee ID: ");
            EndContext();
            BeginContext(571, 17, false);
#line 16 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
                            Write(Model.Employee.Id);

#line default
#line hidden
            EndContext();
            BeginContext(588, 43, true);
            WriteLiteral("</h4>\r\n                <h4>Employee Email: ");
            EndContext();
            BeginContext(632, 20, false);
#line 17 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
                               Write(Model.Employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(652, 48, true);
            WriteLiteral("</h4>\r\n                <h4>Employee Department: ");
            EndContext();
            BeginContext(701, 25, false);
#line 18 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
                                    Write(Model.Employee.Department);

#line default
#line hidden
            EndContext();
            BeginContext(726, 96, true);
            WriteLiteral("</h4>\r\n\r\n            </div>\r\n            <div class=\"card-footer text-center\">\r\n                ");
            EndContext();
            BeginContext(822, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be51dd8c47f2b461c43186e0ff3a49ece1a7d7f8939", async() => {
                BeginContext(897, 5, true);
                WriteLiteral(" Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(906, 195, true);
            WriteLiteral("\r\n                <a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n                <a href=\"#\" class=\"btn btn-danger\">Delete</a>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n    <h3>");
            EndContext();
            BeginContext(1102, 15, false);
#line 31 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
   Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1117, 21, true);
            WriteLiteral("</h3>\r\n    <p> Name: ");
            EndContext();
            BeginContext(1139, 19, false);
#line 32 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
         Write(Model.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1158, 22, true);
            WriteLiteral(" </p>\r\n    <p> Email: ");
            EndContext();
            BeginContext(1181, 20, false);
#line 33 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
          Write(Model.Employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 27, true);
            WriteLiteral(" </p>\r\n    <p> Department: ");
            EndContext();
            BeginContext(1229, 25, false);
#line 34 "G:\Borda Intership\Cient-Server Application\EmployeeDashboard\Views\Home\details.cshtml"
               Write(Model.Employee.Department);

#line default
#line hidden
            EndContext();
            BeginContext(1254, 57, true);
            WriteLiteral(" </p>\r\n<!-- redering means adding script to the file-->\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1333, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1343, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be51dd8c47f2b461c43186e0ff3a49ece1a7d7f12505", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1387, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            BeginContext(1396, 7, true);
            WriteLiteral("       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
