#pragma checksum "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d187c2387a1239ca58c62872194349f99d1ff287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Detail), @"mvc.1.0.view", @"/Views/Employee/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Detail.cshtml", typeof(AspNetCore.Views_Employee_Detail))]
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
#line 1 "C:\Projects\easyPayApp\easyPay\Views\_ViewImports.cshtml"
using easyPay;

#line default
#line hidden
#line 2 "C:\Projects\easyPayApp\easyPay\Views\_ViewImports.cshtml"
using easyPay.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d187c2387a1239ca58c62872194349f99d1ff287", @"/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095305759145e3d906a0a5849de690750cb6f764", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 246, true);
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin grind-margin-md-0\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <nav aria-label=\"breadcrumb\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(278, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d187c2387a1239ca58c62872194349f99d1ff2874014", async() => {
                BeginContext(322, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(330, 55, true);
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(385, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d187c2387a1239ca58c62872194349f99d1ff2875643", async() => {
                BeginContext(407, 13, true);
                WriteLiteral("Employee List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(424, 344, true);
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Employee Details</li>
                </ol>
            </nav><br /><br />
            <div class=""wrap d-flex justify-content-start justify-content-sm-center flex-wrap"">
                <img class=""rounded-circle shadow-lg"" style=""width:300px; height:350px""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 768, "\"", 802, 1);
#line 14 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 774, Url.Content(Model.ImageUrl), 774, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(803, 156, true);
            WriteLiteral(" alt=\"\" />\r\n                <div class=\"wrap align-items-center ml-5\">\r\n                    <p class=\"font-weight-bold text-success\" style=\"font-size:20px\">");
            EndContext();
            BeginContext(960, 14, false);
#line 16 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                                               Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(974, 62, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Role: ");
            EndContext();
            BeginContext(1037, 17, false);
#line 17 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                   Write(Model.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(1054, 64, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Gender: ");
            EndContext();
            BeginContext(1119, 12, false);
#line 18 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                     Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1131, 71, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Date Of Birth: ");
            EndContext();
            BeginContext(1203, 32, false);
#line 19 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                            Write(Model.DOB.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 69, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Employee Id: ");
            EndContext();
            BeginContext(1305, 16, false);
#line 20 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                          Write(Model.EmployeeNo);

#line default
#line hidden
            EndContext();
            BeginContext(1321, 61, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">SSN: ");
            EndContext();
            BeginContext(1383, 26, false);
#line 21 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                  Write(Model.SocialSecurityNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1409, 75, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Email: <a href=\"#\">");
            EndContext();
            BeginContext(1485, 11, false);
#line 22 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                                Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1496, 69, true);
            WriteLiteral("</a></p>\r\n                    <p class=\"font-weight-normal\">Phone: <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1565, "\"", 1588, 2);
            WriteAttributeValue("", 1572, "tel:", 1572, 4, true);
#line 23 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 1576, Model.Phone, 1576, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1589, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1591, 11, false);
#line 23 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                                               Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1602, 241, true);
            WriteLiteral("</a></p>\r\n                    <br /><br />\r\n                    <p class=\"font-weight-bold\"> Pay & Deductions</p>\r\n                    <hr style=\"background-color:crimson\" />\r\n                    <p class=\"font-weight-bold\"> Payment Method: ");
            EndContext();
            BeginContext(1844, 19, false);
#line 27 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                            Write(Model.PaymentMethod);

#line default
#line hidden
            EndContext();
            BeginContext(1863, 69, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\"> Student Loan: ");
            EndContext();
            BeginContext(1933, 17, false);
#line 28 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                          Write(Model.StudentLoan);

#line default
#line hidden
            EndContext();
            BeginContext(1950, 69, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\"> Union Member: ");
            EndContext();
            BeginContext(2020, 17, false);
#line 29 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                                          Write(Model.UnionMember);

#line default
#line hidden
            EndContext();
            BeginContext(2037, 137, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\"><i class=\"fas fa-envelope\" style=\"margin-right:0.6em; color:cornflowerblue\"></i> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2174, "\"", 2254, 7);
            WriteAttributeValue("", 2181, "mailto:", 2181, 7, true);
#line 30 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 2188, Model.Email, 2188, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2200, "?subject=Payslip&body=Attached", 2200, 30, true);
            WriteAttributeValue(" ", 2230, "within", 2231, 7, true);
            WriteAttributeValue(" ", 2237, "is", 2238, 3, true);
            WriteAttributeValue(" ", 2240, "your", 2241, 5, true);
            WriteAttributeValue(" ", 2245, "payslip.", 2246, 9, true);
            EndWriteAttribute();
            BeginContext(2255, 230, true);
            WriteLiteral(">Send Payslip</a></p>\r\n                    <br /><br />\r\n\r\n                    <p class=\"font-weight-bold\"> Address</p>\r\n                    <hr style=\"background-color:crimson\" />\r\n                    <p class=\"font-weight-bold\">");
            EndContext();
            BeginContext(2486, 13, false);
#line 35 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2499, 54, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\">");
            EndContext();
            BeginContext(2554, 10, false);
#line 36 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                           Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(2564, 54, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-bold\">");
            EndContext();
            BeginContext(2619, 14, false);
#line 37 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
                                           Write(Model.Postcode);

#line default
#line hidden
            EndContext();
            BeginContext(2633, 144, true);
            WriteLiteral("</p>\r\n                    <br />\r\n                    <br />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2794, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "C:\Projects\easyPayApp\easyPay\Views\Employee\Detail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
