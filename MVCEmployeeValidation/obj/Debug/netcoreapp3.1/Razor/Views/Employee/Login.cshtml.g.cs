#pragma checksum "D:\kalyani\.netcore\MVCEmployeeValidation\Views\Employee\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65e0adb1aa6cc2b00b486bd688bd7c370803580"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Login), @"mvc.1.0.view", @"/Views/Employee/Login.cshtml")]
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
#line 1 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\_ViewImports.cshtml"
using MVCEmployeeValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\_ViewImports.cshtml"
using MVCEmployeeValidation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65e0adb1aa6cc2b00b486bd688bd7c370803580", @"/Views/Employee/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965e93bfc003d662c1c3b1fdecdf1db1a80e1a30", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCEmployeeValidation.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\Employee\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 7 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\Employee\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>EMPId</td>\r\n            <td>");
#nullable restore
#line 12 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\Employee\Login.cshtml"
           Write(Html.TextBox("id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <td>Password</td>\r\n            <td>");
#nullable restore
#line 16 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\Employee\Login.cshtml"
           Write(Html.Password("pass"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n             <td colspan=\"2\">\r\n                 <input type=\"submit\" value=\"Login\" class=\"btn btn-primary\" />\r\n             </td>\r\n         </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 24 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\Employee\Login.cshtml"
           Write(Html.ActionLink("NewUser","Register","Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <td>\r\n                <span class=\"text-danger\">");
#nullable restore
#line 28 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\Employee\Login.cshtml"
                                     Write(ViewData["err"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 32 "D:\kalyani\.netcore\MVCEmployeeValidation\Views\Employee\Login.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCEmployeeValidation.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
