#pragma checksum "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e739a67b7c928110b39340730411255ab528ec61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e739a67b7c928110b39340730411255ab528ec61", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d3c187aa4500069d87b03484b0956de02efef2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCUsingModelValidation.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 6 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Details.cshtml"
       Write(Html.DisplayFor(m=>m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<pre>\r\n");
#nullable restore
#line 8 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Details.cshtml"
Write(Html.DisplayFor(m=>m.Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Details.cshtml"
Write(Html.DisplayFor(m=>m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</pre>\r\n\r\n");
#nullable restore
#line 12 "D:\kalyani\.netcore\MVCUsingModelValidation\Views\User\Details.cshtml"
Write(Html.ActionLink("logout","Login","User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCUsingModelValidation.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
