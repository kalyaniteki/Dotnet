#pragma checksum "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69fa97be344dae76e20815aa6056875c245f59b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Register), @"mvc.1.0.view", @"/Views/User/Register.cshtml")]
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
#line 1 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\_ViewImports.cshtml"
using MVCUsingModelValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\_ViewImports.cshtml"
using MVCUsingModelValidation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69fa97be344dae76e20815aa6056875c245f59b3", @"/Views/User/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d3c187aa4500069d87b03484b0956de02efef2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Register</h1>\r\n");
#nullable restore
#line 7 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
 using(Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 11 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 16 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 21 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.DisplayNameFor(m => m.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Dob,null,new { @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 26 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.DisplayNameFor(m => m.Phno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Phno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Phno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 31 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.DisplayNameFor(m => m.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.DropDownListFor(m => m.Country,new SelectList(new string[] { " ","India", "USA", "UK" })));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 36 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.DisplayNameFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 41 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.DisplayNameFor(m => m.Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 42 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.PasswordFor(m => m.Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 43 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"
       Write(Html.ValidationMessageFor(m => m.Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\">\r\n            <input type=\"submit\" value=\"Register\" />\r\n\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 52 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Register.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591